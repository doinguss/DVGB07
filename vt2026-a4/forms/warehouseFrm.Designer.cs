namespace vt2026_a4
{
    partial class warehouseFrm
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
            searchTxb = new TextBox();
            searchBtn = new Button();
            groupBox1 = new GroupBox();
            stockRbtn = new RadioButton();
            sortCustomeRbtn = new RadioButton();
            sortPriceRbtn = new RadioButton();
            sortNameRbtn = new RadioButton();
            deleteBtn = new Button();
            orderBtn = new Button();
            editBtn = new Button();
            stockBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            groupBox4 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            newItemNameTxb = new TextBox();
            newItemPriceTxb = new TextBox();
            nameLbl = new Label();
            priceLbl = new Label();
            addNewItemBtn = new Button();
            groupBox3 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            tagsTxb = new TextBox();
            playtimeDtp = new DateTimePicker();
            authorLbl = new Label();
            authorTxb = new TextBox();
            genreLbl = new Label();
            playtimeLbl = new Label();
            formatTxb = new TextBox();
            genreTxb = new TextBox();
            formatLbl = new Label();
            platformLbl = new Label();
            tagsLbl = new Label();
            platformTxb = new TextBox();
            categoryCbx = new ComboBox();
            itemsLw = new ListView();
            idHead = new ColumnHeader();
            categoryHead = new ColumnHeader();
            nameHead = new ColumnHeader();
            priceHead = new ColumnHeader();
            amountHead = new ColumnHeader();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // searchTxb
            // 
            searchTxb.Location = new Point(7, 26);
            searchTxb.Name = "searchTxb";
            searchTxb.Size = new Size(139, 28);
            searchTxb.TabIndex = 1;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(3, 181);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(132, 35);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(stockRbtn);
            groupBox1.Controls.Add(sortCustomeRbtn);
            groupBox1.Controls.Add(sortPriceRbtn);
            groupBox1.Controls.Add(sortNameRbtn);
            groupBox1.Controls.Add(searchTxb);
            groupBox1.Controls.Add(searchBtn);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(315, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(154, 223);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "search";
            // 
            // stockRbtn
            // 
            stockRbtn.AutoSize = true;
            stockRbtn.Location = new Point(7, 151);
            stockRbtn.Name = "stockRbtn";
            stockRbtn.Size = new Size(69, 24);
            stockRbtn.TabIndex = 6;
            stockRbtn.TabStop = true;
            stockRbtn.Text = "stock";
            stockRbtn.UseVisualStyleBackColor = true;
            // 
            // sortCustomeRbtn
            // 
            sortCustomeRbtn.AutoSize = true;
            sortCustomeRbtn.Location = new Point(7, 121);
            sortCustomeRbtn.Name = "sortCustomeRbtn";
            sortCustomeRbtn.Size = new Size(87, 24);
            sortCustomeRbtn.TabIndex = 5;
            sortCustomeRbtn.TabStop = true;
            sortCustomeRbtn.Text = "custome";
            sortCustomeRbtn.UseVisualStyleBackColor = true;
            // 
            // sortPriceRbtn
            // 
            sortPriceRbtn.AutoSize = true;
            sortPriceRbtn.Location = new Point(7, 91);
            sortPriceRbtn.Name = "sortPriceRbtn";
            sortPriceRbtn.Size = new Size(65, 24);
            sortPriceRbtn.TabIndex = 4;
            sortPriceRbtn.TabStop = true;
            sortPriceRbtn.Text = "price";
            sortPriceRbtn.UseVisualStyleBackColor = true;
            // 
            // sortNameRbtn
            // 
            sortNameRbtn.AutoSize = true;
            sortNameRbtn.Location = new Point(7, 61);
            sortNameRbtn.Name = "sortNameRbtn";
            sortNameRbtn.Size = new Size(65, 24);
            sortNameRbtn.TabIndex = 3;
            sortNameRbtn.TabStop = true;
            sortNameRbtn.Text = "name";
            sortNameRbtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(3, 3);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(106, 29);
            deleteBtn.TabIndex = 5;
            deleteBtn.Text = "delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // orderBtn
            // 
            orderBtn.Location = new Point(3, 38);
            orderBtn.Name = "orderBtn";
            orderBtn.Size = new Size(106, 29);
            orderBtn.TabIndex = 6;
            orderBtn.Text = "order";
            orderBtn.UseVisualStyleBackColor = true;
            orderBtn.Click += orderBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(3, 73);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(106, 29);
            editBtn.TabIndex = 7;
            editBtn.Text = "edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // stockBtn
            // 
            stockBtn.Location = new Point(3, 108);
            stockBtn.Name = "stockBtn";
            stockBtn.Size = new Size(106, 55);
            stockBtn.TabIndex = 8;
            stockBtn.Text = "adjust stock";
            stockBtn.UseVisualStyleBackColor = true;
            stockBtn.Click += stockBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.2706528F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.1819572F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.54739F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox4, 2, 0);
            tableLayoutPanel1.Controls.Add(itemsLw, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 229F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(900, 450);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(deleteBtn);
            panel1.Controls.Add(orderBtn);
            panel1.Controls.Add(stockBtn);
            panel1.Controls.Add(editBtn);
            panel1.Location = new Point(315, 232);
            panel1.Name = "panel1";
            panel1.Size = new Size(119, 172);
            panel1.TabIndex = 10;
            // 
            // groupBox4
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox4, 2);
            groupBox4.Controls.Add(tableLayoutPanel2);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(475, 3);
            groupBox4.Name = "groupBox4";
            tableLayoutPanel1.SetRowSpan(groupBox4, 2);
            groupBox4.Size = new Size(422, 444);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "new product";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ControlLight;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.28821F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.71179F));
            tableLayoutPanel2.Controls.Add(newItemNameTxb, 0, 1);
            tableLayoutPanel2.Controls.Add(newItemPriceTxb, 1, 1);
            tableLayoutPanel2.Controls.Add(nameLbl, 0, 0);
            tableLayoutPanel2.Controls.Add(priceLbl, 1, 0);
            tableLayoutPanel2.Controls.Add(addNewItemBtn, 2, 1);
            tableLayoutPanel2.Controls.Add(groupBox3, 0, 2);
            tableLayoutPanel2.Controls.Add(categoryCbx, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 24);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 56.8807335F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 43.1192665F));
            tableLayoutPanel2.Size = new Size(416, 417);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // newItemNameTxb
            // 
            newItemNameTxb.Location = new Point(3, 29);
            newItemNameTxb.Name = "newItemNameTxb";
            newItemNameTxb.Size = new Size(132, 28);
            newItemNameTxb.TabIndex = 1;
            // 
            // newItemPriceTxb
            // 
            newItemPriceTxb.Location = new Point(143, 29);
            newItemPriceTxb.Name = "newItemPriceTxb";
            newItemPriceTxb.Size = new Size(112, 28);
            newItemPriceTxb.TabIndex = 2;
            // 
            // nameLbl
            // 
            nameLbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(3, 6);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(44, 20);
            nameLbl.TabIndex = 5;
            nameLbl.Text = "name";
            // 
            // priceLbl
            // 
            priceLbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            priceLbl.AutoSize = true;
            priceLbl.Location = new Point(143, 6);
            priceLbl.Name = "priceLbl";
            priceLbl.Size = new Size(44, 20);
            priceLbl.TabIndex = 6;
            priceLbl.Text = "price";
            priceLbl.TextAlign = ContentAlignment.BottomLeft;
            // 
            // addNewItemBtn
            // 
            addNewItemBtn.Dock = DockStyle.Bottom;
            addNewItemBtn.Location = new Point(270, 33);
            addNewItemBtn.Name = "addNewItemBtn";
            addNewItemBtn.Size = new Size(143, 29);
            addNewItemBtn.TabIndex = 4;
            addNewItemBtn.Text = "add new";
            addNewItemBtn.UseVisualStyleBackColor = true;
            addNewItemBtn.Click += addNewItemBtn_Click;
            // 
            // groupBox3
            // 
            tableLayoutPanel2.SetColumnSpan(groupBox3, 3);
            groupBox3.Controls.Add(tableLayoutPanel3);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 68);
            groupBox3.Name = "groupBox3";
            tableLayoutPanel2.SetRowSpan(groupBox3, 2);
            groupBox3.Size = new Size(410, 346);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "tags";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 98F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tagsTxb, 0, 6);
            tableLayoutPanel3.Controls.Add(playtimeDtp, 1, 3);
            tableLayoutPanel3.Controls.Add(authorLbl, 0, 0);
            tableLayoutPanel3.Controls.Add(authorTxb, 1, 0);
            tableLayoutPanel3.Controls.Add(genreLbl, 0, 1);
            tableLayoutPanel3.Controls.Add(playtimeLbl, 0, 3);
            tableLayoutPanel3.Controls.Add(formatTxb, 1, 2);
            tableLayoutPanel3.Controls.Add(genreTxb, 1, 1);
            tableLayoutPanel3.Controls.Add(formatLbl, 0, 2);
            tableLayoutPanel3.Controls.Add(platformLbl, 0, 4);
            tableLayoutPanel3.Controls.Add(tagsLbl, 0, 5);
            tableLayoutPanel3.Controls.Add(platformTxb, 1, 4);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 24);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 7;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(404, 319);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // tagsTxb
            // 
            tableLayoutPanel3.SetColumnSpan(tagsTxb, 2);
            tagsTxb.Dock = DockStyle.Fill;
            tagsTxb.Location = new Point(3, 183);
            tagsTxb.Multiline = true;
            tagsTxb.Name = "tagsTxb";
            tagsTxb.Size = new Size(398, 133);
            tagsTxb.TabIndex = 9;
            // 
            // playtimeDtp
            // 
            playtimeDtp.Dock = DockStyle.Fill;
            playtimeDtp.Enabled = false;
            playtimeDtp.Format = DateTimePickerFormat.Custom;
            playtimeDtp.Location = new Point(101, 93);
            playtimeDtp.Name = "playtimeDtp";
            playtimeDtp.ShowUpDown = true;
            playtimeDtp.Size = new Size(300, 28);
            playtimeDtp.TabIndex = 10;
            // 
            // authorLbl
            // 
            authorLbl.AutoSize = true;
            authorLbl.Location = new Point(3, 0);
            authorLbl.Name = "authorLbl";
            authorLbl.Size = new Size(55, 20);
            authorLbl.TabIndex = 1;
            authorLbl.Text = "author";
            // 
            // authorTxb
            // 
            authorTxb.Dock = DockStyle.Fill;
            authorTxb.Enabled = false;
            authorTxb.Location = new Point(101, 3);
            authorTxb.Name = "authorTxb";
            authorTxb.Size = new Size(300, 28);
            authorTxb.TabIndex = 0;
            // 
            // genreLbl
            // 
            genreLbl.AutoSize = true;
            genreLbl.Location = new Point(3, 30);
            genreLbl.Name = "genreLbl";
            genreLbl.Size = new Size(48, 20);
            genreLbl.TabIndex = 2;
            genreLbl.Text = "genre";
            // 
            // playtimeLbl
            // 
            playtimeLbl.AutoSize = true;
            playtimeLbl.Location = new Point(3, 90);
            playtimeLbl.Name = "playtimeLbl";
            playtimeLbl.Size = new Size(67, 20);
            playtimeLbl.TabIndex = 4;
            playtimeLbl.Text = "playtime";
            // 
            // formatTxb
            // 
            formatTxb.Dock = DockStyle.Fill;
            formatTxb.Enabled = false;
            formatTxb.Location = new Point(101, 63);
            formatTxb.Name = "formatTxb";
            formatTxb.Size = new Size(300, 28);
            formatTxb.TabIndex = 6;
            // 
            // genreTxb
            // 
            genreTxb.Dock = DockStyle.Fill;
            genreTxb.Enabled = false;
            genreTxb.Location = new Point(101, 33);
            genreTxb.Name = "genreTxb";
            genreTxb.Size = new Size(300, 28);
            genreTxb.TabIndex = 5;
            // 
            // formatLbl
            // 
            formatLbl.AutoSize = true;
            formatLbl.Location = new Point(3, 60);
            formatLbl.Name = "formatLbl";
            formatLbl.Size = new Size(58, 20);
            formatLbl.TabIndex = 3;
            formatLbl.Text = "format";
            // 
            // platformLbl
            // 
            platformLbl.AutoSize = true;
            platformLbl.Location = new Point(3, 120);
            platformLbl.Name = "platformLbl";
            platformLbl.Size = new Size(70, 20);
            platformLbl.TabIndex = 8;
            platformLbl.Text = "platform";
            // 
            // tagsLbl
            // 
            tagsLbl.AutoSize = true;
            tagsLbl.Location = new Point(3, 150);
            tagsLbl.Name = "tagsLbl";
            tagsLbl.Size = new Size(39, 20);
            tagsLbl.TabIndex = 11;
            tagsLbl.Text = "tags";
            // 
            // platformTxb
            // 
            platformTxb.Dock = DockStyle.Fill;
            platformTxb.Enabled = false;
            platformTxb.Location = new Point(101, 123);
            platformTxb.Name = "platformTxb";
            platformTxb.Size = new Size(300, 28);
            platformTxb.TabIndex = 12;
            // 
            // categoryCbx
            // 
            categoryCbx.Dock = DockStyle.Left;
            categoryCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryCbx.FormattingEnabled = true;
            categoryCbx.Location = new Point(270, 3);
            categoryCbx.Name = "categoryCbx";
            categoryCbx.Size = new Size(141, 28);
            categoryCbx.TabIndex = 7;
            categoryCbx.SelectedIndexChanged += categoryCbx_SelectedIndexChanged;
            // 
            // itemsLw
            // 
            itemsLw.Alignment = ListViewAlignment.Default;
            itemsLw.AllowColumnReorder = true;
            itemsLw.Columns.AddRange(new ColumnHeader[] { idHead, categoryHead, nameHead, priceHead, amountHead });
            itemsLw.Dock = DockStyle.Fill;
            itemsLw.FullRowSelect = true;
            itemsLw.GridLines = true;
            itemsLw.Location = new Point(3, 3);
            itemsLw.MultiSelect = false;
            itemsLw.Name = "itemsLw";
            tableLayoutPanel1.SetRowSpan(itemsLw, 2);
            itemsLw.Size = new Size(306, 444);
            itemsLw.TabIndex = 13;
            itemsLw.UseCompatibleStateImageBehavior = false;
            itemsLw.View = View.Details;
            // 
            // idHead
            // 
            idHead.Text = "id";
            idHead.Width = 25;
            // 
            // categoryHead
            // 
            categoryHead.Text = "category";
            categoryHead.Width = 70;
            // 
            // nameHead
            // 
            nameHead.Text = "name";
            // 
            // priceHead
            // 
            priceHead.Text = "price";
            priceHead.Width = 75;
            // 
            // amountHead
            // 
            amountHead.Text = "#";
            // 
            // warehouseFrm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 450);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "warehouseFrm";
            Text = "warehouseFrm";
            FormClosing += warehouseFrm_FormClosing;
            Load += warehouseFrm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox searchTxb;
        private Button searchBtn;
        private GroupBox groupBox1;
        private Button stockBtn;
        private Button editBtn;
        private Button orderBtn;
        private Button deleteBtn;
        private RadioButton sortCustomeRbtn;
        private RadioButton sortPriceRbtn;
        private RadioButton sortNameRbtn;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox newItemNameTxb;
        private TextBox newItemPriceTxb;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private TextBox authorTxb;
        private TextBox formatTxb;
        private TextBox genreTxb;
        private Label playtimeLbl;
        private Label formatLbl;
        private Label genreLbl;
        private Label authorLbl;
        private TextBox tagsTxb;
        private Label platformLbl;
        private Button addNewItemBtn;
        private Label nameLbl;
        private Label priceLbl;
        private DateTimePicker playtimeDtp;
        private TableLayoutPanel tableLayoutPanel3;
        private ListView itemsLw;
        private ColumnHeader idHead;
        private ColumnHeader nameHead;
        private ColumnHeader categoryHead;
        private ColumnHeader priceHead;
        private ColumnHeader amountHead;
        private ComboBox categoryCbx;
        private Label tagsLbl;
        private TextBox platformTxb;
        private RadioButton stockRbtn;
    }
}