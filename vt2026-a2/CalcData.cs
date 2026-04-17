using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vt2026_a2
{
    internal class CalcData
    {
        private List<string> entries;
        private static string[] symbols = { "+", "-", "*", "^", "E", "/", "?", "(", ")" };
        internal List<string> Entries { get { return entries; } set { entries = value; } }
        public CalcData()
        {
            entries = new();
        }
        //pre: input only contains chars in symbols and numbers ('.' is ok if in fraction)
        //post: mathamatically evaluated expression (string)
        internal string CalcExpression(string input) 
        {
            return HandelTokens(MakeTokens(input));
        }
        private List<string> MakeTokens(string input)
        {
            int start = 0;
            List<string> tokens = new();
            for (int i = 0; i < input.Length; i++)
            {
                if (symbols.Contains(input[i].ToString()))
                {
                    if (start != i)
                        tokens.Add(input.Substring(start, i - start));
                    tokens.Add(input[i].ToString());
                    start = i + 1;
                }
            }
            return tokens;
        }
        //pre: input only contains managable tokens
        //post: mathamatically evaluated expression (string)
        private string HandelTokens(List<string> tokens)
        {
            CorrectSyntax(tokens);
            OrderOfOpperations(tokens);
            return tokens.Count > 0 ? tokens.First() : "";
        }
        //pre: tokens[i]=="("
        //post: tokens[i]=handeltokens() <- everythigninside parenthesis
        private void HandelParenthesis(List<string> tokens, int i)
        {
            for (int j = i; j < tokens.Count; j++)
            {//looks for ending of parenthesis or end of msg and calculates it as its own expression
                switch (tokens[j])
                {
                    case ")":
                    case "?":
                        tokens[i] = HandelTokens(tokens.GetRange(i + 1, j - i));
                        for (int k = j; k > i; k--)
                        {//removes everything in the parenthesis from outside to in
                            tokens.RemoveAt(k);
                        }
                        break;
                }
            }
            CorrectSyntax(tokens);
        }
        //pre: valid list of tokens
        //post: replaces opperations with their result, following order of opperations
        private void OrderOfOpperations(List<string> tokens)
        {
            try
            {//try catch to deal with weird inconsistent errors where the correctsyntax method or the handel parenthesis let opperation characters stack up causing an error when the theyre being resolved
                for (int i = 0; i < tokens.Count; i++)
                {//for parenthesis
                    if (!tokens.Contains("(") || !tokens.Contains(")")) { break; }
                    switch (tokens[i])
                    {
                        case "(": HandelParenthesis(tokens, i); CorrectSyntax(tokens)/*test*/; break;
                    }
                }
                for (int i = 0; i < tokens.Count; i++)
                {//for exponents (and roots)
                    if (!tokens.Contains("^")) { break; }
                    switch (tokens[i])
                    {
                        case "^": tokens[i] = pow(tokens[i - 1], tokens[i + 1]); tokens.RemoveAt(i + 1); tokens.RemoveAt(i - 1); i -= 2; break;
                    }
                }
                for (int i = 0; i < tokens.Count; i++)
                {//for * and /
                    if (!tokens.Contains("*") && !tokens.Contains("/")) { break; }
                    switch (tokens[i])
                    {
                        case "*": tokens[i] = mult(tokens[i - 1], tokens[i + 1]); tokens.RemoveAt(i + 1); tokens.RemoveAt(i - 1); i -= 2; break;
                        case "/": tokens[i] = div(tokens[i - 1], tokens[i + 1]); tokens.RemoveAt(i + 1); tokens.RemoveAt(i - 1); i -= 2; break;
                    }
                }
                for (int i = 0; i < tokens.Count; i++)
                {//for + and -
                    if (!tokens.Contains("+") && !tokens.Contains("-")) { break; }
                    switch (tokens[i])
                    {
                        case "+": tokens[i] = add(tokens[i - 1], tokens[i + 1]); tokens.RemoveAt(i + 1); tokens.RemoveAt(i - 1); i -= 2; break;
                        case "-": tokens[i] = sub(tokens[i - 1], tokens[i + 1]); tokens.RemoveAt(i + 1); tokens.RemoveAt(i - 1); i -= 2; break;
                    }
                }
            }
            catch { Debug.WriteLine(tokens); }
        }
        //pre: tokens initilaized
        //post: corrected syntax that can compute
        private void CorrectSyntax(List<string> tokens) 
        {
            for (int i = 0; i < tokens.Count; i++)
            {
                if (!symbols.Contains(tokens[i])) { continue; }     //if not a symbol, continue
                if (tokens[0] == "-") { tokens.Insert(0, "0"); i++; continue; } //adds 0 first if expression starts with a negative number (instead of deleting the '-')
                if (symbols.Contains(tokens[0])) { tokens.RemoveAt(0); i--; continue; }  //if a symbol is in first pos, delete it
                if (tokens[i] == "E") { tokens[i] = "*"; tokens.Insert(i + 1, "^"); tokens.Insert(i + 1, "10"); } //to handel scientific E notation
                switch (tokens[i - 1], tokens[i])
                {//for doubled up symbols like for adding special interactions :3
                    case ("+", "+"):                    tokens.RemoveAt(i);     i--; break;
                    case ("-", "+"):                    tokens.RemoveAt(i);     i--; break;
                    case ("*", "+"):                    tokens.RemoveAt(i);     i--; break;
                    case ("/", "+"):                    tokens.RemoveAt(i);     i--; break;
                    case ("^", "+"):                    tokens.RemoveAt(i);     i--; break;
                    case ("+", "-"):                    tokens.RemoveAt(i - 1); i--; break;
                    case ("-", "-"): tokens[i] = "+";   tokens.RemoveAt(i - 1); i--; break;
                    case ("*", "-"):                    tokens.RemoveAt(i);     i--; break;
                    case ("/", "-"):                    tokens.RemoveAt(i);     i--; break;
                    case ("^", "-"):                    tokens.RemoveAt(i);     i--; break;
                    case ("+", "*"):                    tokens.RemoveAt(i);     i--; break;
                    case ("-", "*"):                    tokens.RemoveAt(i);     i--; break;
                    case ("*", "*"): tokens[i] = "^";   tokens.RemoveAt(i - 1); i--; break;
                    case ("/", "*"):                    tokens.RemoveAt(i);     i--; break; 
                    case ("^", "*"):                    tokens.RemoveAt(i);     i--; break;
                    case ("+", "/"):                    tokens.RemoveAt(i);     i--; break;
                    case ("-", "/"):                    tokens.RemoveAt(i);     i--; break;
                    case ("*", "/"):                    tokens.RemoveAt(i);     i--; break;
                    case ("/", "/"):                    tokens.RemoveAt(i);     i--; break;
                    case ("^", "/"):                    tokens.RemoveAt(i);     i--; break;
                    case ("+", "^"):                    tokens.RemoveAt(i);     i--; break;
                    case ("-", "^"):                    tokens.RemoveAt(i);     i--; break;
                    case ("*", "^"):                    tokens.RemoveAt(i);     i--; break;
                    case ("/", "^"):                    tokens.RemoveAt(i);     i--; break;
                    case ("^", "^"):                    tokens.RemoveAt(i);     i--; break;
                    case ("+", "?"):                    tokens.RemoveAt(i - 1); i--; break;
                    case ("-", "?"):                    tokens.RemoveAt(i - 1); i--; break;
                    case ("*", "?"):                    tokens.RemoveAt(i - 1); i--; break;
                    case ("/", "?"):                    tokens.RemoveAt(i - 1); i--; break;
                    case ("^", "?"):                    tokens.RemoveAt(i - 1); i--; break;
                    case ("+", ")"):                    tokens.RemoveAt(i - 1); i--; break;
                    case ("-", ")"):                    tokens.RemoveAt(i - 1); i--; break;
                    case ("*", ")"):                    tokens.RemoveAt(i - 1); i--; break;
                    case ("/", ")"):                    tokens.RemoveAt(i - 1); i--; break;
                    case ("^", ")"):                    tokens.RemoveAt(i - 1); i--; break;
                    case ("(", "+"):                    tokens.RemoveAt(i - 1); i--; break;
                    case ("(", "-"):                    tokens.RemoveAt(i - 1); i--; break;
                    case ("(", "*"):                    tokens.RemoveAt(i - 1); i--; break;
                    case ("(", "/"):                    tokens.RemoveAt(i - 1); i--; break;
                    case ("(", "^"):                    tokens.RemoveAt(i - 1); i--; break;
                }
            }
        }
        //
        //everything below is super self-explanatory 
        //pre: a && b are numbers 
        private static string add(string a, string b) { return (float.Parse(a) + float.Parse(b)).ToString(); }
        private static string sub(string a, string b) { return (float.Parse(a) - float.Parse(b)).ToString(); }
        private static string mult(string a, string b) { return (float.Parse(a) * float.Parse(b)).ToString(); }
        private static string div(string a, string b) { return b == "0" ? "0" : (float.Parse(a) / float.Parse(b)).ToString(); }
        private static string pow(string a, string b) { return Math.Pow(float.Parse(a), float.Parse(b)).ToString(); }
    }
}
