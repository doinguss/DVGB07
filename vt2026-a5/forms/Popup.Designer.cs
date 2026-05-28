namespace vt2026_a4.forms
{
    partial class Popup
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
            tableLayoutPanel1 = new TableLayoutPanel();
            firstLbl = new Label();
            secondLbl = new Label();
            txb = new TextBox();
            cancelBtn = new Button();
            continueBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.5714283F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 340F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel1.Controls.Add(firstLbl, 1, 0);
            tableLayoutPanel1.Controls.Add(secondLbl, 1, 1);
            tableLayoutPanel1.Controls.Add(txb, 1, 2);
            tableLayoutPanel1.Controls.Add(cancelBtn, 2, 4);
            tableLayoutPanel1.Controls.Add(continueBtn, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.Size = new Size(530, 179);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // firstLbl
            // 
            firstLbl.Anchor = AnchorStyles.Bottom;
            firstLbl.AutoSize = true;
            firstLbl.Location = new Point(199, 15);
            firstLbl.Name = "firstLbl";
            firstLbl.Size = new Size(49, 20);
            firstLbl.TabIndex = 0;
            firstLbl.Text = "label1";
            // 
            // secondLbl
            // 
            secondLbl.Anchor = AnchorStyles.None;
            secondLbl.AutoSize = true;
            secondLbl.Location = new Point(198, 46);
            secondLbl.Name = "secondLbl";
            secondLbl.Size = new Size(51, 20);
            secondLbl.TabIndex = 1;
            secondLbl.Text = "label2";
            // 
            // txb
            // 
            txb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txb.Location = new Point(57, 87);
            txb.Name = "txb";
            txb.Size = new Size(334, 28);
            txb.TabIndex = 2;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.Location = new Point(421, 147);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(106, 29);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // continueBtn
            // 
            continueBtn.Anchor = AnchorStyles.Left;
            continueBtn.Location = new Point(397, 87);
            continueBtn.Name = "continueBtn";
            continueBtn.Size = new Size(106, 29);
            continueBtn.TabIndex = 4;
            continueBtn.Text = "continue";
            continueBtn.UseVisualStyleBackColor = true;
            continueBtn.Click += continueBtn_Click;
            // 
            // Popup
            // 
            AcceptButton = continueBtn;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelBtn;
            ClientSize = new Size(530, 179);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Popup";
            Text = "Popup";
            FormClosing += Popup_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label firstLbl;
        private Label secondLbl;
        private Button cancelBtn;
        private Button continueBtn;
        internal TextBox txb;
    }
}