using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace vt2026_a3
{
    internal class SaveManager
    {
        //singelton ↓↓↓↓
        private static SaveManager? instance;
        private SaveManager(TextBox inputfeild) {
            this.inputfeild = inputfeild;
            this.filename = null;
            this.altered = false;
        }
        static internal SaveManager getInstance(TextBox inputfeild) { return instance ?? (instance = new(inputfeild)); }
        //singelton ↑↑↑↑

        private const string defaultname = "newfile.txt";
        private TextBox inputfeild;
        private string? initialText;
        private string? filename;
        private bool altered;
        internal string? InitialText { get {return initialText; }}
        internal string? Filename { get{return filename??defaultname; }}
        internal bool Altered { get{return altered; }}

        /// <summary>
        /// pre: true
        /// post: saves and stuff 
        /// (pretty short just look at the code, using words will take longer to understand)
        /// </summary>
        internal void Save()
        {
            if (filename == null) { SaveAs(); return; }
            if (!altered) {return; }
            using (StreamWriter writer=new(filename))
            {
                writer.Write(inputfeild.Text);
            }
            initialText = inputfeild.Text;
            altered = false;
        }
        /// <summary>
        /// pre: permission by os to write files
        /// post: allows user to save files with specified location and name 
        /// currently an issue with the name including the file path, will work on it later
        /// </summary>
        internal void SaveAs()
        {
            SaveFileDialog saveFileDialog = new()
            {
                InitialDirectory=Application.StartupPath,
                //InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments),
                Filter = "txt files (*.txt)|*.txt",
                AddToRecent = true,
                FileName = filename ?? defaultname
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK) 
            {
                try
                {//try catch for safety and unknown risks abt file streaming, how this all is done is inspired by a previous project i have worked on
                    using (StreamWriter writer = new(saveFileDialog.FileName))
                    {
                        writer.Write(initialText);
                    }
                    initialText = inputfeild.Text;
                    altered=false;
                    filename = saveFileDialog.FileName;
                }
                catch (Exception) { }
            }
        }
        /// <summary>
        /// pre: permission by os to read files
        /// post: loads a textfile if one is selected by user
        /// </summary>
        internal void Load()
        {
            OpenFileDialog openFileDialog = new()
            {

                InitialDirectory = Application.StartupPath,
                //InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments),
                Filter = "txt files (*.txt)|*.txt",
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {//try catch just in case idk file reading can be quirky and im not too familiar
                    using (StreamReader reader = new(openFileDialog.FileName))
                    {
                        inputfeild.Text = reader.ReadToEnd();//self explantory
                    }
                    initialText = inputfeild.Text;
                    altered=false;
                    filename = openFileDialog.FileName;
                }
                catch (Exception) { }
            }
        }
        /// <summary>
        /// pre: true
        /// post: makes a new yk thingy blank page
        /// </summary>
        internal void New()
        {
            if (altered) { SaveAs(); }
            inputfeild.Text = "";
            initialText = inputfeild.Text;
            filename = null;
            altered = false;
        }
        /// <summary>
        /// pre: title!=null
        /// post: title and altered updated, asterisk added if changed since last save, removed if not 
        /// </summary>
        /// <param name="title"></param>
        internal void Titleasterisk(Form frm)
        {
            switch (altered, inputfeild.Text == initialText)
            {
                case (true, true): altered = false; frm.Text = filename??defaultname; break;
                case (false, false): altered = true; frm.Text = "*" + filename; break;
            }
        }
    }
}
