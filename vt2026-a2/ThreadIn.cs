using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vt2026_a2
{
    internal class ThreadIn
    {
        private uint its;
        private Random r;
        private int?[] num;
        private uint match5,match6,match7;
        private object locker;

        //these are default generated properties 
        internal uint Its { get => its; set => its = value; }
        internal Random R { get => r; set => r = value; }
        internal int?[] Num { get => num; set => num = value; }
        internal uint Match5 { get => match5; set => match5 = value; }
        internal uint Match6 { get => match6; set => match6 = value; }
        internal uint Match7 { get => match7; set => match7 = value; }
        internal object Locker { get => locker; set => locker = value; }

        internal ThreadIn(uint its, Random r, int?[] num, ref uint match5, ref uint match6, ref uint match7, object locker)
        {
            this.its=its;
            this.r=r;
            this.num=num;
            this.match5=match5;
            this.match6=match6;
            this.match7=match7;
            this.locker=locker;
        }
    }
}
