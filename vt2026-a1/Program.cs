namespace vt2026_a1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\nasigment select (1-9) 0 to exit:");
                switch (Console.ReadLine())
                {
                    case "1": num1(); break;
                    case "2": num2(); break;
                    case "3": num3(); break;
                    case "4": num4(); break;
                    case "5": num5(); break;
                    case "6": num6(); break;
                    case "7": num7(); break;
                    case "8": num8(); break;
                    case "9": num9(); break;
                    default: return;
                }
            }
        }
        /*
         * yo so like i dont rly give a f abt making this asignment look neat when it comes to line spacing ect ect
         * since this is so rudimentary and all
         * but the codes all correct so make of it what u will 
         */
        private static void num1() { for (int i = 0; i < 31; i+=2) { Console.Write(i+" "); } }
        private static void num2() { int input; if (!int.TryParse(Console.ReadLine(), out input)) { Console.WriteLine("error");return; };if (input == 0) { Console.WriteLine("0"); }if (input > 0) { Console.WriteLine("positive"); } if (input < 0) { Console.WriteLine("negative"); } } 
        private static void num3() { int max=0, min=0, input; if (!int.TryParse(Console.ReadLine(), out input)) { Console.WriteLine("error"); return; }; for (int i = input; i > 0; i--) { int temp; if (!int.TryParse(Console.ReadLine(), out temp)) { Console.WriteLine("error"); return; }; if (i==input || temp > max) { max = temp; } if (i==input || temp < min) { min = temp; } } Console.WriteLine("min: " + min + " max: " + max); }
        private static void num4() { int count = 0,temp=0; string input = " "+Console.ReadLine(),key="AB";for (int i = 0; i < input.Length; i++) { if (input[i] == key[temp]) { temp++;} if (temp == key.Length) { temp = 0;count++; } }Console.WriteLine("the search key '"+key+"' appears "+count+" times"); }
        private static void num5() { int[] arr=new int[10]; for (int i = 0; i < 10; i++) { if (!int.TryParse(Console.ReadLine(), out arr[i])) { Console.WriteLine("error"); return; } } arr=arr.Order<int>().ToArray<int>(); Console.WriteLine("avrage "+arr.Average()+" median " + arr[5]); }
        private static void num6() { int arg1, arg2; if (!int.TryParse(Console.ReadLine(), out arg1)|| !int.TryParse(Console.ReadLine(), out arg2)) { Console.WriteLine("error"); return; } Console.WriteLine(num6_1(arg1, arg2)); }
        private static void num7() { Console.WriteLine(IsAlpha((Console.ReadLine()+" ")[0])); }
        private static void num8() { Console.WriteLine("rewriting all previous to be input safe: complete"); }
        private static void num9() { Console.WriteLine("press 0 to escape"); Random r=new Random(DateTime.Now.Second); while ((Console.ReadLine()+" ")[0] != '0') { List<int> restricted=new List<int>(); for (int i = 0; i < 7;) { int j = r.Next(1, 37);if (!restricted.Contains(j)) { restricted.Add(j);i++; } } foreach (int i in restricted) { Console.Write(i+" ");} } }
        private static int num6_1(int a,int b) { return a + b; }
        private static bool IsAlpha(char c) {return char.IsBetween(char.ToLower(c), 'a', 'z'); }

    }
}
