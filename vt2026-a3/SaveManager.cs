using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vt2026_a3
{
    internal class SaveManager
    {
        /**
         * i want to try and implament the singleton pattern in this save manager sine i only rly want one fliereader active at a time
         * otherwise itll cause issues with the buffer
         * 
         * and also its a nice challange sincce i havent ever used it before and seems like
         * itd be a fun challange
         * 
         * if i remember correctly it had a private static constructor and a private static
         * datatype of whatever u wanna keep 
         * 
         *and then also an internal or public method that calls on the preivate constructor
         *and when using this u cant even use the new keyword
         *
         *i feel thisd be neat :3
         *
         */
        private TextBox inputfeild;

        internal string InitialText { get; set; }
        internal string Filename { get; }
        internal bool Altered { get; set; }
        /*/
        //singleton expiriment
        private static object thing;
        private SaveManager() {
        //something 
        }
        internal SaveManager method()
        {
            return thing ?? SaveManager();
        }
        //singelton expiriment 
        //**/
        internal SaveManager(TextBox inputfeild)
        {
            this.inputfeild = inputfeild;

            InitialText = inputfeild.Text;
            Filename = "coolest-ever-document.txt";
            Altered = false;
        }

        internal void Save()
        {
            InitialText = inputfeild.Text;
        }
    }
}
