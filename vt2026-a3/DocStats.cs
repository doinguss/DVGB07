using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vt2026_a3
{
    internal static class DocStats
    {
        internal static int SymbolCount(string s) { return s.Count<char>(); }
        internal static int NonWhitspaceCount(string s) { return s.Count<char>() - s.Count<char>(char.IsWhiteSpace); }
        internal static int WordCount(string s)
        {
            int output = 0;
            bool prevwhitspace = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsWhiteSpace(s[i])) { prevwhitspace = true; }
                if (!char.IsWhiteSpace(s[i]) &&prevwhitspace)
                {
                    output++;
                    prevwhitspace = false;
                }
            }
            return output;
        }
        internal static int LineCount(string s) { return s.Count<char>(isNewline); }
        private static bool isNewline(char c) { return c == '\n'; }
        internal static void FixNewLine(ref string s) { s=s.Replace("\n", Environment.NewLine);}
    }
}
