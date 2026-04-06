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
        internal List<string> Entries { get { return entries; } set { entries = value; } }
        public CalcData()
        {
            entries = new ();
        }
        internal string CalcExpression(string input) 
        {
            return HandelTokens(MakeTokens(input));
        }
        private List<string> MakeTokens(string input)
        {
            int start = 0;
            List<string> tokens = new();
            char[] symbols = { '+', '-', '*', '/', '?' };
            for (int i = 0; i < input.Length; i++)
            {
                if (symbols.Contains(input[i]))
                {
                    if (start != i)
                        tokens.Add(input.Substring(start, i - start));
                    tokens.Add(input[i].ToString());
                    start = i + 1;
                }
            }
            return tokens;
        }
        private string HandelTokens(List<string> tokens)
        {
            CorrectSyntax(tokens);
            for (int i = 0; i < tokens.Count; i++)
            {
                switch (tokens[i])
                {
                    case "*": tokens[i] = mult(tokens[i - 1], tokens[i + 1]); tokens.RemoveAt(i + 1); tokens.RemoveAt(i - 1); i -= 2; break;
                    case "/": tokens[i] = div(tokens[i - 1], tokens[i + 1]); tokens.RemoveAt(i + 1); tokens.RemoveAt(i - 1); i -= 2; break;
                }
            }
            for (int i = 0; i < tokens.Count; i++)
            {
                switch (tokens[i])
                {
                    case "+": tokens[i] = add(tokens[i - 1], tokens[i + 1]); tokens.RemoveAt(i + 1); tokens.RemoveAt(i - 1); i -= 2; break;
                    case "-": tokens[i] = sub(tokens[i - 1], tokens[i + 1]); tokens.RemoveAt(i + 1); tokens.RemoveAt(i - 1); i -= 2; break;
                }
            }
            return tokens.First();
        }
        private void CorrectSyntax(List<string> tokens)
        {
            Debug.WriteLine("debugging");
            string[] symbols = { "+", "-", "*", "/", "?" };
            for (int i = 0; i < tokens.Count; i++)
            {
                //if (tokens[i] == string.Empty)    { tokens.RemoveAt(i); i--; continue; }
                if (!symbols.Contains(tokens[i])) { continue; }                           //if not a symbol, continue
                if (tokens[0] == "-") { tokens.Insert(0, "0"); i++; continue; } //adds 0 first if expression starts with a negative number (instead of deleting the '-')
                if (symbols.Contains(tokens[0])) { tokens.RemoveAt(0); i--; continue; }  //if a symbol is in first pos, delete it
                switch (tokens[i - 1], tokens[i])
                {
                    case ("+", "+"): tokens.RemoveAt(i); i--; break;
                    case ("-", "+"): tokens.RemoveAt(i); i--; break;
                    case ("*", "+"): tokens.RemoveAt(i); i--; break;
                    case ("/", "+"): tokens.RemoveAt(i); i--; break;
                    case ("+", "-"): tokens.RemoveAt(i - 1); i--; break;
                    case ("-", "-"): tokens[i] = "+"; tokens.RemoveAt(i - 1); i--; break;
                    case ("*", "-"): tokens.RemoveAt(i); i--; break;
                    case ("/", "-"): tokens.RemoveAt(i); i--; break;
                    case ("+", "*"): tokens.RemoveAt(i); i--; break;
                    case ("-", "*"): tokens.RemoveAt(i); i--; break;
                    case ("*", "*"): tokens[i] = "*"; tokens.RemoveAt(i); i--; break;
                    case ("/", "*"): tokens.RemoveAt(i); i--; break;
                    case ("+", "/"): tokens.RemoveAt(i); i--; break;
                    case ("-", "/"): tokens.RemoveAt(i); i--; break;
                    case ("*", "/"): tokens.RemoveAt(i); i--; break;
                    case ("/", "/"): tokens.RemoveAt(i); i--; break;
                    case ("+", "?"): tokens.RemoveAt(i - 1); i--; break;
                    case ("-", "?"): tokens.RemoveAt(i - 1); i--; break;
                    case ("*", "?"): tokens.RemoveAt(i - 1); i--; break;
                    case ("/", "?"): tokens.RemoveAt(i - 1); i--; break;
                }
            }
        }
        private static string add(string a, string b) { return (float.Parse(a) + float.Parse(b)).ToString(); }
        private static string sub(string a, string b) { return (float.Parse(a) - float.Parse(b)).ToString(); }
        private static string mult(string a, string b) { return (float.Parse(a) * float.Parse(b)).ToString(); }
        private static string div(string a, string b) { return b == "0" ? "0" : (float.Parse(a) / float.Parse(b)).ToString(); }
    }
}
