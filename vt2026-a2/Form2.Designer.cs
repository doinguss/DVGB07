namespace vt2026_a2
{
    partial class warningFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.szirena_siren;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(720, 436);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(33, 103);
            button1.Margin = new Padding(9);
            button1.Name = "button1";
            button1.Size = new Size(408, 118);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // warningFrm
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(23F, 59F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            CancelButton = button1;
            ClientSize = new Size(720, 436);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Cursor = Cursors.No;
            Font = new Font("Impact", 28.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(9);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "warningFrm";
            ShowInTaskbar = false;
            Text = "[EXTREMLY LOUD INCORRECT BUZZER]";
            TransparencyKey = Color.White;
            FormClosing += warningFrm_FormClosing;
            Load += warningFrm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
    }
}