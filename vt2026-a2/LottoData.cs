using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vt2026_a2
{
    internal class LottoData
    {
        private int?[] num; //feilds
        internal int match5 { get; set; }
        internal int match6 { get; set; } 
        internal int match7 { get; set; }
        internal LottoData() //constructor
        {
            num = new int?[7];
            for (int i = 0; i < 7; i++) { num[i] = null; }
        }
        internal int?[] Getnum() {  return num; }//getter
        internal void Setnum(int value, int index) //setter
        {
            if (index < 1 || index > 7) { return; }
            num[index-1] = (Inbounds(value) && !num.Contains(value)) ? value : null;
        }
        internal void Clear() { for (int i=0;i < 7;i++) { num[i] = null; } }
        private bool Inbounds(int? value) {
            return value >= 1 && value <= 35;
        }
        internal void Gambling(Random r) 
        {
            int newnum= r.Next(1, 36), matches = 0;
            int[] ints = new int[7];
            for (int i = 0; i < 7; i++) 
            {
                while (ints.Contains(newnum)) { newnum = r.Next(1, 36); }
                if (num.Contains(newnum)) { matches++; }
                ints[i]= newnum;
            }
            switch (matches) 
            {
                case 5: match5++; break;
                case 6: match6++; break;
                case 7: match7++; break;
                default: break;
            }
        }
    }
}
