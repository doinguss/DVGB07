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
        //singelto  ↓↓↓↓
        private static SaveManager? instance;
        private SaveManager(TextBox inputfeild, ToolStripMenuItem aniTsmi)
        {
            this.inputfeild = inputfeild;
            this.aniTsmi = aniTsmi;
            this.FilenameIn("");
            this.altered = false;
            this.initialText = inputfeild.Text;
        }
        static internal SaveManager getInstance(TextBox inputfeild, ToolStripMenuItem aniTsmi) { return instance ?? (instance = new(inputfeild, aniTsmi)); }
        //singelton ↑↑↑↑

        private const string defaultname = "newfile.txt";
        private TextBox inputfeild;
        private string? initialText;
        private string? filename;
        private bool altered;
        private ToolStripMenuItem aniTsmi;
        private System.Windows.Forms.Timer timer;
        private bool animation;
        private byte aniStep;
        private int maxLine;
        private int currentLine;
        private string[] framelines;
        internal ushort AniStep { get { return aniStep; } }
        internal bool Animation { get { return animation; } }
        internal bool Altered { get { return altered; } }
        internal string? InitialText { get { return initialText; } }
        internal string Filename { get { return (filename == string.Empty) || (filename == null) ? defaultname : filename; } }
        private void FilenameIn(string value) { filename = value; Animationcheck(value); } // setter (not property)

        /// <summary>
        /// pre: true
        /// post: saves and stuff 
        /// (pretty short just look at the code, using words will take longer to understand)
        /// </summary>
        internal bool Save()
        {
            if (filename == "" || filename == null || filename == string.Empty) { return SaveAs(); }
            if (!altered) { return true; }
            using (StreamWriter writer = new(filename))
            {
                writer.Write(inputfeild.Text);
            }
            initialText = inputfeild.Text;
            altered = false;
            return true;
        }
        /// <summary>
        /// pre: permission by os to write files
        /// post: allows user to save files with specified location and name 
        /// currently an issue with the name including the file path, will work on it later
        /// </summary>
        internal bool SaveAs()
        {
            SaveFileDialog saveFileDialog = new()
            {
                InitialDirectory = Application.StartupPath,
                //InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments),
                Filter = "txt files (*.txt)|*.txt",
                AddToRecent = true,
                FileName = Filename
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {//try catch for safety and unknown risks abt file streaming, how this all is done is inspired by a previous project i have worked on
                    using (StreamWriter writer = new(saveFileDialog.FileName))
                    {
                        writer.Write(inputfeild.Text);
                    }
                    initialText = inputfeild.Text;
                    altered = false;
                    FilenameIn(saveFileDialog.FileName);

                }
                catch (Exception) { }
                return true;
            }
            return false;
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
                Load(openFileDialog.FileName);
            }
        }
        internal void Load(String path)
        {
            try
            {//try catch just in case idk file reading can be quirky and im not too familiar
                string text;
                using (StreamReader reader = new(path))
                {
                    //inputfeild.Text = reader.ReadLine();
                    text = reader.ReadToEnd();//self explantory
                }
                DocStats.FixNewLine(ref text);
                inputfeild.Text = text;
                initialText = inputfeild.Text;
                altered = false;
                FilenameIn(path);
            }
            catch (Exception) { }
        }
        /// <summary>
        /// pre: true
        /// post: makes a new yk thingy blank page
        /// </summary>
        internal void New()
        {
            inputfeild.Text = "";
            initialText = inputfeild.Text;
            FilenameIn(defaultname);
            altered = false;
        }
        /// <summary>
        /// pre: title!=null
        /// post: title and altered updated, asterisk added if changed since last save, removed if not 
        /// </summary>
        /// <param name="title"></param>
        internal void Titleasterisk(Form frm)
        {
            string name = Filename.Substring(Math.Max(Filename.LastIndexOf('\\') + 1, 0));
            switch (inputfeild.Text == initialText)
            {
                case true: altered = false; frm.Text = name; break;
                case false: altered = true; frm.Text = "*" + name; break;
            }
        }
        /// <summary>
        /// pre: true
        /// post: checks if loded file is made to be an animation if so sets animation to true, enebales the animiation tab, sets animation step and max line
        /// </summary>
        /// <param name="filename"></param>
        private void Animationcheck(string filename)
        {
            aniTsmi.Enabled = false;
            if (filename.Length < 12) { return; }
            if (filename.Contains("-animation-"))
            {
                if (byte.TryParse(filename.Substring(filename.LastIndexOf("-animation-") + 11, 2), out aniStep))
                {
                    animation = true;
                    aniTsmi.Enabled = true;
                    maxLine = DocStats.LineCount(inputfeild.Text);
                }

            }
        }
        /// <summary>
        /// pre: animation==true && aniStep!=(null || <=0) && filename!= invalid
        /// post: displays lines from file as "frames" taking the aniStep variable as an indicator for how many lines are allocated for each frame
        /// some notes, the number after the "-animation-" must be two chars, say 5 would be 05 17 would be 17 ect ect, and this number
        /// represents the number of lines per frame. each line is defined by the line break char \n or enviroment.newline. 
        /// the first line of the file is reserved for comments and or refrenes to where it came from if that is needed.
        /// at lower animation speeds this could be used as an outo scroll, however the timer doesnt care abt what the actuall content being displayed
        /// looks like so it ould be wayy to little time or way too much and it can be hard to tell befroehand 
        /// </summary>
        internal void AnimateStart( bool frmCount,uint mspf)
        {
            altered = true;
            if (filename == null) { return; }
            if (timer!=null&&timer.Enabled) {  timer.Dispose(); }
            currentLine = 0;
            framelines = File.ReadAllLines(filename);//https://stackoverflow.com/questions/20287479/reading-a-specific-line-with-streamreader

            timer = new();
            timer.Interval = (int)Math.Clamp(mspf,1,int.MaxValue);
            timer.Tick += new EventHandler((Object? o, EventArgs e) =>
            {
                if (aniStep <= 0) { timer.Stop(); timer.Dispose(); return; }
                if (currentLine == maxLine) { timer.Stop(); timer.Dispose(); return; }

                string text = "";
                for (int i = 0; i < aniStep && currentLine++ != maxLine-1; i++)
                {
                    //text = File.ReadLines(filename).Skip(currentLine).FirstOrDefault() ?? "";/*https://stackoverflow.com/questions/20287479/reading-a-specific-line-with-streamreader*/
                    text += framelines[currentLine] + Environment.NewLine;
                }
                inputfeild.Text = text;
                if (frmCount)
                    inputfeild.Text += "  (" + currentLine/aniStep + "/" + maxLine / aniStep + ")";

            });
            timer.Start();
        }

    }
}
