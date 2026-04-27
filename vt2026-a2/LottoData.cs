using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace vt2026_a2
{
    internal class LottoData
    {
        private readonly object locker;// https://www.geeksforgeeks.org/c-sharp/c-sharp-multithreading/
        private readonly int?[] num; //feilds
        private uint match5;
        private uint match6;
        private uint match7;
        internal uint Match5 { get {return match5; } set { match5 = value; } }
        internal uint Match6 { get {return match6; } set { match6 = value; } }
        internal uint Match7 { get {return match7; } set { match7 = value; } }

        private uint its;
        internal uint Its { get { return its; } set { its = value; } }
        internal LottoData() //constructor
        {
            locker = new();
            num = new int?[7];
            for (int i = 0; i < 7; i++) { num[i] = null; }
        }
        internal int?[] Getnum() {  return num; }//getter
        internal void Setnum(int value, int index) //setter
        {
            if (index < 1 || index > 7) { return; }
            num[index-1] = (Inbounds(value) && !num.Contains(value)) ? value : null;//if value is in bounds and new set it otherwise set null
        }
        internal void Clear() { for (int i=0;i < 7;i++) { num[i] = null; } }
        private bool Inbounds(int? value) {
            return value >= 1 && value <= 35;
        }
        /// <summary>
        /// pre: true (honestly nothings gonna break here)
        /// post: increases matchX if that many are matching 
        /// thing called when playing a game
        /// </summary>
        /// <param name="r"></param>
        private void Gambling(Random r) 
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
                case 5: incrament(ref match5); break;
                case 6: incrament(ref match6); Debug.WriteLine("\t+ (match6) thread" + Thread.CurrentThread.ManagedThreadId); break;
                case 7: incrament(ref match7); Debug.WriteLine("\t\t++ (match7) thread" + Thread.CurrentThread.ManagedThreadId); break;
                default: break;
            }
            incrament(ref its);
        }
        /// <summary>
        /// pre: loker available (othehrewise waits untill it is)
        /// post: incraments val
        /// this is for multithreading the clacs
        /// </summary>
        /// <param name="val"></param>
        private void incrament(ref uint val)
        {
            lock (locker)
            {
                val++;
            }
        }
        /// <summary>
        /// pre:true
        /// post: clacs the gamble multithreded
        /// ok so this is very expiremental, from the testing im not sure if this is atually any faster than what i did before but i have managed to make it work or at least run
        /// i dont rly know a lot abt multithreading the code ive made here is the result of a lot of trail and error 
        /// </summary>
        /// <param name="its"></param>
        internal Task start(uint its,Random r,List<Task> tasks)
        {
            uint i = its;
            match5 = 0;
            match6 = 0;
            match7 = 0;
            this.its = 0;
            Task t1,t2,t3,t4;
            tasks.Add(t1=new Task(() => { gambleBatch((uint)(its / 4), r); }));
            tasks.Add(t2=new Task(() => { gambleBatch((uint)(its / 4), r); }));
            tasks.Add(t3=new Task(() => { gambleBatch((uint)(its / 4), r); }));
            tasks.Add(t4=new Task(() => { gambleBatch(i-3*(uint)(its / 4), r); }));

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            return Task.CompletedTask;
        }
        private Task gambleBatch(uint its, Random r)
        {
            Debug.WriteLine("|thread"+Thread.CurrentThread.ManagedThreadId+ " : start "+its+"|");
            for (int i = 0; i < its; i++)
            {
                Gambling(r);
            }
            Debug.WriteLine("|thread" + Thread.CurrentThread.ManagedThreadId + " : done|");
            return Task.CompletedTask;
        }
    }
}
