namespace vt2026_a2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lottoBtn = new Button();
            calcBtn = new Button();
            SuspendLayout();
            // 
            // lottoBtn
            // 
            lottoBtn.AutoSize = true;
            lottoBtn.BackgroundImage = (Image)resources.GetObject("lottoBtn.BackgroundImage");
            lottoBtn.BackgroundImageLayout = ImageLayout.Stretch;
            lottoBtn.Dock = DockStyle.Top;
            lottoBtn.FlatStyle = FlatStyle.Popup;
            lottoBtn.Location = new Point(0, 0);
            lottoBtn.Name = "lottoBtn";
            lottoBtn.Size = new Size(782, 30);
            lottoBtn.TabIndex = 0;
            lottoBtn.Text = "new lotto window";
            lottoBtn.UseVisualStyleBackColor = true;
            lottoBtn.Click += lottoBtn_Click;
            // 
            // calcBtn
            // 
            calcBtn.AutoSize = true;
            calcBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            calcBtn.BackgroundImage = (Image)resources.GetObject("calcBtn.BackgroundImage");
            calcBtn.BackgroundImageLayout = ImageLayout.Stretch;
            calcBtn.Dock = DockStyle.Top;
            calcBtn.FlatAppearance.BorderColor = Color.DarkBlue;
            calcBtn.FlatStyle = FlatStyle.Popup;
            calcBtn.Location = new Point(0, 30);
            calcBtn.Name = "calcBtn";
            calcBtn.Size = new Size(782, 30);
            calcBtn.TabIndex = 1;
            calcBtn.Text = "new calc window";
            calcBtn.UseVisualStyleBackColor = true;
            calcBtn.Click += calcBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 60);
            Controls.Add(calcBtn);
            Controls.Add(lottoBtn);
            MaximumSize = new Size(800, 107);
            MinimumSize = new Size(166, 107);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button lottoBtn;
        private Button calcBtn;
    }
}
