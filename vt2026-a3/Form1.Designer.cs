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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            exitTsmi = new ToolStripMenuItem();
            fileTsmi = new ToolStripMenuItem();
            saveTsmi = new ToolStripMenuItem();
            saveAsTsmi = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            loadTsmi = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            newTsmi = new ToolStripMenuItem();
            aniTsmi = new ToolStripMenuItem();
            playTsmi = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            fpmsTsmi = new ToolStripMenuItem();
            fpmsTstb = new ToolStripTextBox();
            frmCountTsmi = new ToolStripMenuItem();
            frmcountTstb = new ToolStripTextBox();
            txtfeildTxb = new TextBox();
            statusStrip1 = new StatusStrip();
            charTssl = new ToolStripStatusLabel();
            exCharTssl = new ToolStripStatusLabel();
            wordsTssl = new ToolStripStatusLabel();
            linesTssl = new ToolStripStatusLabel();
            aniTsmiTt = new ToolTip(components);
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            toolTip4 = new ToolTip(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { exitTsmi, fileTsmi, aniTsmi });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(776, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // exitTsmi
            // 
            exitTsmi.AutoToolTip = true;
            exitTsmi.Name = "exitTsmi";
            exitTsmi.Size = new Size(47, 24);
            exitTsmi.Text = "Exit";
            exitTsmi.ToolTipText = "closes application";
            exitTsmi.Click += exitTsmi_Click;
            // 
            // fileTsmi
            // 
            fileTsmi.AutoToolTip = true;
            fileTsmi.DropDownItems.AddRange(new ToolStripItem[] { saveTsmi, saveAsTsmi, toolStripSeparator1, loadTsmi, toolStripSeparator2, newTsmi });
            fileTsmi.Name = "fileTsmi";
            fileTsmi.Size = new Size(46, 24);
            fileTsmi.Text = "File";
            fileTsmi.ToolTipText = "all the options abt files, saving loading ect ect ";
            // 
            // saveTsmi
            // 
            saveTsmi.Name = "saveTsmi";
            saveTsmi.Size = new Size(139, 26);
            saveTsmi.Text = "save";
            saveTsmi.Click += saveTsmi_Click;
            // 
            // saveAsTsmi
            // 
            saveAsTsmi.Name = "saveAsTsmi";
            saveAsTsmi.Size = new Size(139, 26);
            saveAsTsmi.Text = "save as";
            saveAsTsmi.Click += saveAsTsmi_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(136, 6);
            // 
            // loadTsmi
            // 
            loadTsmi.Name = "loadTsmi";
            loadTsmi.Size = new Size(139, 26);
            loadTsmi.Text = "load";
            loadTsmi.Click += loadTsmi_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(136, 6);
            // 
            // newTsmi
            // 
            newTsmi.Name = "newTsmi";
            newTsmi.Size = new Size(139, 26);
            newTsmi.Text = "new";
            newTsmi.Click += newTsmi_Click;
            // 
            // aniTsmi
            // 
            aniTsmi.DropDownItems.AddRange(new ToolStripItem[] { playTsmi, toolStripSeparator3, fpmsTsmi, frmCountTsmi });
            aniTsmi.Name = "aniTsmi";
            aniTsmi.Size = new Size(90, 24);
            aniTsmi.Text = "animation";
            // 
            // playTsmi
            // 
            playTsmi.Name = "playTsmi";
            playTsmi.Size = new Size(241, 26);
            playTsmi.Text = "play";
            playTsmi.Click += playToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(238, 6);
            // 
            // fpmsTsmi
            // 
            fpmsTsmi.DropDownItems.AddRange(new ToolStripItem[] { fpmsTstb });
            fpmsTsmi.Name = "fpmsTsmi";
            fpmsTsmi.Size = new Size(241, 26);
            fpmsTsmi.Text = "ms / frame";
            // 
            // fpmsTstb
            // 
            fpmsTstb.Name = "fpmsTstb";
            fpmsTstb.Size = new Size(100, 27);
            fpmsTstb.Text = "16";
            fpmsTstb.TextChanged += fpmsTstb_TextChanged;
            // 
            // frmCountTsmi
            // 
            frmCountTsmi.DropDownItems.AddRange(new ToolStripItem[] { frmcountTstb });
            frmCountTsmi.Name = "frmCountTsmi";
            frmCountTsmi.Size = new Size(241, 26);
            frmCountTsmi.Text = "show framecount (y/n)";
            // 
            // frmcountTstb
            // 
            frmcountTstb.Name = "frmcountTstb";
            frmcountTstb.Size = new Size(100, 27);
            frmcountTstb.Text = "y";
            frmcountTstb.TextChanged += frmcountTstb_TextChanged;
            // 
            // txtfeildTxb
            // 
            txtfeildTxb.Dock = DockStyle.Fill;
            txtfeildTxb.Font = new Font("Monospac821 BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtfeildTxb.Location = new Point(0, 28);
            txtfeildTxb.Multiline = true;
            txtfeildTxb.Name = "txtfeildTxb";
            txtfeildTxb.ScrollBars = ScrollBars.Vertical;
            txtfeildTxb.Size = new Size(776, 417);
            txtfeildTxb.TabIndex = 1;
            txtfeildTxb.TextChanged += textBox1_TextChanged;
            txtfeildTxb.DragDrop += txtfeildTxb_DragDrop;
            txtfeildTxb.DragEnter += txtfeildTxb_DragEnter;
            txtfeildTxb.DragOver += txtfeildTxb_DragOver;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { charTssl, exCharTssl, wordsTssl, linesTssl });
            statusStrip1.Location = new Point(0, 419);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(776, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // charTssl
            // 
            charTssl.Name = "charTssl";
            charTssl.Padding = new Padding(10, 0, 10, 0);
            charTssl.Size = new Size(115, 20);
            charTssl.Text = "characters:    ";
            // 
            // exCharTssl
            // 
            exCharTssl.Name = "exCharTssl";
            exCharTssl.Padding = new Padding(10, 0, 10, 0);
            exCharTssl.Size = new Size(146, 20);
            exCharTssl.Text = "(excl whitspace):  ";
            // 
            // wordsTssl
            // 
            wordsTssl.Name = "wordsTssl";
            wordsTssl.Padding = new Padding(10, 0, 10, 0);
            wordsTssl.Size = new Size(80, 20);
            wordsTssl.Text = "words:  ";
            // 
            // linesTssl
            // 
            linesTssl.Name = "linesTssl";
            linesTssl.Padding = new Padding(10, 0, 10, 0);
            linesTssl.Size = new Size(66, 20);
            linesTssl.Text = "lines: ";
            // 
            // aniTsmiTt
            // 
            aniTsmiTt.OwnerDraw = true;
            aniTsmiTt.Tag = "aniTsmiTt";
            aniTsmiTt.ToolTipTitle = "options for animating a file displaing it as several frames \\n add \"-animation-\" followed by a two char uint to the file name (doesnt matter where) to enable this";
            // 
            // toolTip1
            // 
            toolTip1.OwnerDraw = true;
            toolTip1.Tag = "aniTsmiTt";
            toolTip1.ToolTipTitle = "options for animating a file displaing it as several frames \\n add \"-animation-\" followed by a two char uint to the file name (doesnt matter where) to enable this";
            // 
            // toolTip2
            // 
            toolTip2.OwnerDraw = true;
            toolTip2.Tag = "aniTsmiTt";
            toolTip2.ToolTipTitle = "options for animating a file displaing it as several frames \\n add \"-animation-\" followed by a two char uint to the file name (doesnt matter where) to enable this";
            // 
            // toolTip3
            // 
            toolTip3.OwnerDraw = true;
            toolTip3.Tag = "aniTsmiTt";
            toolTip3.ToolTipTitle = "options for animating a file displaing it as several frames \\n add \"-animation-\" followed by a two char uint to the file name (doesnt matter where) to enable this";
            // 
            // toolTip4
            // 
            toolTip4.OwnerDraw = true;
            toolTip4.Tag = "aniTsmiTt";
            toolTip4.ToolTipTitle = "options for animating a file displaing it as several frames \\n add \"-animation-\" followed by a two char uint to the file name (doesnt matter where) to enable this";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 445);
            Controls.Add(statusStrip1);
            Controls.Add(txtfeildTxb);
            Controls.Add(menuStrip1);
            Font = new Font("Monospac821 BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "not a bloatpad (tm)";
            FormClosing += Form1_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel charTssl;
        private ToolStripStatusLabel exCharTssl;
        private ToolStripStatusLabel wordsTssl;
        private ToolStripStatusLabel linesTssl;
        private ToolStripMenuItem aniTsmi;
        private ToolStripMenuItem playTsmi;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem fpmsTsmi;
        private ToolStripMenuItem frmCountTsmi;
        private ToolStripTextBox fpmsTstb;
        private ToolStripTextBox frmcountTstb;
        private ToolTip aniTsmiTt;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
        private ToolTip toolTip4;
    }
}
