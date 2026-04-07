namespace vt2026_a3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            exitTsmi = new ToolStripMenuItem();
            fileTsmi = new ToolStripMenuItem();
            saveTsmi = new ToolStripMenuItem();
            saveAsTsmi = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            loadTsmi = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            newTsmi = new ToolStripMenuItem();
            txtfeildTxb = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { exitTsmi, fileTsmi });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // exitTsmi
            // 
            exitTsmi.Name = "exitTsmi";
            exitTsmi.Size = new Size(47, 24);
            exitTsmi.Text = "Exit";
            exitTsmi.Click += exitTsmi_Click;
            // 
            // fileTsmi
            // 
            fileTsmi.DropDownItems.AddRange(new ToolStripItem[] { saveTsmi, saveAsTsmi, toolStripSeparator1, loadTsmi, toolStripSeparator2, newTsmi });
            fileTsmi.Name = "fileTsmi";
            fileTsmi.Size = new Size(46, 24);
            fileTsmi.Text = "File";
            // 
            // saveTsmi
            // 
            saveTsmi.Name = "saveTsmi";
            saveTsmi.Size = new Size(224, 26);
            saveTsmi.Text = "save";
            saveTsmi.Click += saveTsmi_Click;
            // 
            // saveAsTsmi
            // 
            saveAsTsmi.Name = "saveAsTsmi";
            saveAsTsmi.Size = new Size(224, 26);
            saveAsTsmi.Text = "save as";
            saveAsTsmi.Click += saveAsTsmi_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // loadTsmi
            // 
            loadTsmi.Name = "loadTsmi";
            loadTsmi.Size = new Size(224, 26);
            loadTsmi.Text = "load";
            loadTsmi.Click += loadTsmi_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(221, 6);
            // 
            // newTsmi
            // 
            newTsmi.Name = "newTsmi";
            newTsmi.Size = new Size(224, 26);
            newTsmi.Text = "new";
            newTsmi.Click += newTsmi_Click;
            // 
            // txtfeildTxb
            // 
            txtfeildTxb.Dock = DockStyle.Fill;
            txtfeildTxb.Location = new Point(0, 28);
            txtfeildTxb.Multiline = true;
            txtfeildTxb.Name = "txtfeildTxb";
            txtfeildTxb.Size = new Size(800, 422);
            txtfeildTxb.TabIndex = 1;
            txtfeildTxb.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtfeildTxb);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private TextBox txtfeildTxb;
        private ToolStripMenuItem fileTsmi;
        private ToolStripMenuItem exitTsmi;
        private ToolStripMenuItem saveTsmi;
        private ToolStripMenuItem saveAsTsmi;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem loadTsmi;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem newTsmi;
    }
}
