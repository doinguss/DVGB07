namespace vt2026_a4
{
    partial class storeFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(storeFrm));
            tableLayoutPanel1 = new TableLayoutPanel();
            itemsGb = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            searchGb = new GroupBox();
            panel1 = new Panel();
            label1 = new Label();
            bookRbtn = new RadioButton();
            miscRbtn = new RadioButton();
            gameRbtn = new RadioButton();
            movieRbtn = new RadioButton();
            customRbtn = new RadioButton();
            searchNameRbtn = new RadioButton();
            searchPriceRbtn = new RadioButton();
            searchTxb = new TextBox();
            addBtn = new Button();
            itemsLw = new ListView();
            nameHead = new ColumnHeader();
            priceHead = new ColumnHeader();
            categoryHead = new ColumnHeader();
            tagsHead = new ColumnHeader();
            stockHead = new ColumnHeader();
            id = new ColumnHeader();
            productInfoGb = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            stockLbl = new Label();
            nameLbl = new Label();
            categoryLbl = new Label();
            tagsLbl = new Label();
            somethingLbl = new Label();
            topselerLbl = new Label();
            shoppingcartGb = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            totalLbl = new Label();
            buyBtn = new Button();
            recitCb = new CheckBox();
            shoppingcartPnl = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            shoppingcartLw = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            amountHead = new ColumnHeader();
            idHead = new ColumnHeader();
            timeLbl = new Label();
            menuStrip1 = new MenuStrip();
            exitToolStripMenuItem = new ToolStripMenuItem();
            returnItemToolStripMenuItem = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            updateFromDatabaseToolStripMenuItem = new ToolStripMenuItem();
            syncLocalstockToDatabaseToolStripMenuItem = new ToolStripMenuItem();
            showGraphsOfPriceAndAmountToolStripMenuItem = new ToolStripMenuItem();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            tableLayoutPanel1.SuspendLayout();
            itemsGb.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            searchGb.SuspendLayout();
            panel1.SuspendLayout();
            productInfoGb.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            shoppingcartGb.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            shoppingcartPnl.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.7350426F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.8366566F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(itemsGb, 0, 0);
            tableLayoutPanel1.Controls.Add(productInfoGb, 1, 0);
            tableLayoutPanel1.Controls.Add(shoppingcartGb, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 28);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 56.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 43.3333321F));
            tableLayoutPanel1.Size = new Size(1185, 561);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // itemsGb
            // 
            itemsGb.Controls.Add(tableLayoutPanel2);
            itemsGb.Dock = DockStyle.Fill;
            itemsGb.Location = new Point(3, 3);
            itemsGb.Name = "itemsGb";
            tableLayoutPanel1.SetRowSpan(itemsGb, 2);
            itemsGb.Size = new Size(500, 555);
            itemsGb.TabIndex = 0;
            itemsGb.TabStop = false;
            itemsGb.Text = "items for sale";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.15825F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.84175F));
            tableLayoutPanel2.Controls.Add(searchGb, 0, 1);
            tableLayoutPanel2.Controls.Add(itemsLw, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 24);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 205F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(494, 528);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // searchGb
            // 
            tableLayoutPanel2.SetColumnSpan(searchGb, 2);
            searchGb.Controls.Add(panel1);
            searchGb.Controls.Add(customRbtn);
            searchGb.Controls.Add(searchNameRbtn);
            searchGb.Controls.Add(searchPriceRbtn);
            searchGb.Controls.Add(searchTxb);
            searchGb.Controls.Add(addBtn);
            searchGb.Dock = DockStyle.Fill;
            searchGb.Location = new Point(3, 326);
            searchGb.Name = "searchGb";
            searchGb.Size = new Size(488, 199);
            searchGb.TabIndex = 5;
            searchGb.TabStop = false;
            searchGb.Text = "search";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(bookRbtn);
            panel1.Controls.Add(miscRbtn);
            panel1.Controls.Add(gameRbtn);
            panel1.Controls.Add(movieRbtn);
            panel1.Location = new Point(147, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 158);
            panel1.TabIndex = 11;
            panel1.Click += panel1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 10;
            label1.Text = "categories";
            // 
            // bookRbtn
            // 
            bookRbtn.AutoSize = true;
            bookRbtn.Location = new Point(3, 21);
            bookRbtn.Name = "bookRbtn";
            bookRbtn.Size = new Size(71, 24);
            bookRbtn.TabIndex = 6;
            bookRbtn.TabStop = true;
            bookRbtn.Text = "books";
            bookRbtn.UseVisualStyleBackColor = true;
            bookRbtn.CheckedChanged += searchTxb_TextChanged;
            // 
            // miscRbtn
            // 
            miscRbtn.AutoSize = true;
            miscRbtn.Location = new Point(3, 111);
            miscRbtn.Name = "miscRbtn";
            miscRbtn.Size = new Size(60, 24);
            miscRbtn.TabIndex = 9;
            miscRbtn.TabStop = true;
            miscRbtn.Text = "misc";
            miscRbtn.UseVisualStyleBackColor = true;
            miscRbtn.CheckedChanged += searchTxb_TextChanged;
            // 
            // gameRbtn
            // 
            gameRbtn.AutoSize = true;
            gameRbtn.Location = new Point(3, 51);
            gameRbtn.Name = "gameRbtn";
            gameRbtn.Size = new Size(72, 24);
            gameRbtn.TabIndex = 7;
            gameRbtn.TabStop = true;
            gameRbtn.Text = "games";
            gameRbtn.UseVisualStyleBackColor = true;
            gameRbtn.CheckedChanged += searchTxb_TextChanged;
            // 
            // movieRbtn
            // 
            movieRbtn.AutoSize = true;
            movieRbtn.Location = new Point(3, 81);
            movieRbtn.Name = "movieRbtn";
            movieRbtn.Size = new Size(75, 24);
            movieRbtn.TabIndex = 8;
            movieRbtn.TabStop = true;
            movieRbtn.Text = "movies";
            movieRbtn.UseVisualStyleBackColor = true;
            movieRbtn.CheckedChanged += searchTxb_TextChanged;
            // 
            // customRbtn
            // 
            customRbtn.AutoSize = true;
            customRbtn.Location = new Point(3, 148);
            customRbtn.Name = "customRbtn";
            customRbtn.Size = new Size(87, 24);
            customRbtn.TabIndex = 5;
            customRbtn.TabStop = true;
            customRbtn.Text = "custome";
            customRbtn.UseVisualStyleBackColor = true;
            customRbtn.CheckedChanged += searchTxb_TextChanged;
            // 
            // searchNameRbtn
            // 
            searchNameRbtn.AutoSize = true;
            searchNameRbtn.Location = new Point(3, 118);
            searchNameRbtn.Name = "searchNameRbtn";
            searchNameRbtn.Size = new Size(65, 24);
            searchNameRbtn.TabIndex = 4;
            searchNameRbtn.TabStop = true;
            searchNameRbtn.Text = "name";
            searchNameRbtn.UseVisualStyleBackColor = true;
            searchNameRbtn.CheckedChanged += searchTxb_TextChanged;
            // 
            // searchPriceRbtn
            // 
            searchPriceRbtn.AutoSize = true;
            searchPriceRbtn.Location = new Point(3, 88);
            searchPriceRbtn.Name = "searchPriceRbtn";
            searchPriceRbtn.Size = new Size(65, 24);
            searchPriceRbtn.TabIndex = 3;
            searchPriceRbtn.TabStop = true;
            searchPriceRbtn.Text = "price";
            searchPriceRbtn.UseVisualStyleBackColor = true;
            searchPriceRbtn.CheckedChanged += searchTxb_TextChanged;
            // 
            // searchTxb
            // 
            searchTxb.Location = new Point(3, 50);
            searchTxb.Name = "searchTxb";
            searchTxb.Size = new Size(140, 28);
            searchTxb.TabIndex = 1;
            searchTxb.TextChanged += searchTxb_TextChanged;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(147, 0);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(132, 35);
            addBtn.TabIndex = 2;
            addBtn.Text = "add to cart";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // itemsLw
            // 
            itemsLw.Columns.AddRange(new ColumnHeader[] { nameHead, priceHead, categoryHead, tagsHead, stockHead, id });
            tableLayoutPanel2.SetColumnSpan(itemsLw, 2);
            itemsLw.Dock = DockStyle.Fill;
            itemsLw.FullRowSelect = true;
            itemsLw.GridLines = true;
            itemsLw.Location = new Point(3, 3);
            itemsLw.MultiSelect = false;
            itemsLw.Name = "itemsLw";
            itemsLw.Size = new Size(488, 317);
            itemsLw.TabIndex = 6;
            itemsLw.UseCompatibleStateImageBehavior = false;
            itemsLw.View = View.Details;
            itemsLw.SelectedIndexChanged += listView1_SelectedIndexChanged;
            itemsLw.DoubleClick += addBtn_Click;
            // 
            // nameHead
            // 
            nameHead.Text = "name";
            nameHead.Width = 180;
            // 
            // priceHead
            // 
            priceHead.Text = "price";
            // 
            // categoryHead
            // 
            categoryHead.Text = "category";
            // 
            // tagsHead
            // 
            tagsHead.Text = "tags";
            // 
            // stockHead
            // 
            stockHead.Text = "stock";
            // 
            // id
            // 
            id.Text = "id";
            id.Width = 0;
            // 
            // productInfoGb
            // 
            productInfoGb.Controls.Add(tableLayoutPanel4);
            productInfoGb.Dock = DockStyle.Fill;
            productInfoGb.Location = new Point(509, 3);
            productInfoGb.Name = "productInfoGb";
            tableLayoutPanel1.SetRowSpan(productInfoGb, 2);
            productInfoGb.Size = new Size(276, 555);
            productInfoGb.TabIndex = 1;
            productInfoGb.TabStop = false;
            productInfoGb.Text = "information";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(stockLbl, 0, 2);
            tableLayoutPanel4.Controls.Add(nameLbl, 0, 0);
            tableLayoutPanel4.Controls.Add(categoryLbl, 0, 1);
            tableLayoutPanel4.Controls.Add(tagsLbl, 0, 3);
            tableLayoutPanel4.Controls.Add(somethingLbl, 0, 5);
            tableLayoutPanel4.Controls.Add(topselerLbl, 0, 4);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 24);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 6;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 227F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(270, 528);
            tableLayoutPanel4.TabIndex = 0;
            tableLayoutPanel4.Click += panel1_Click;
            // 
            // stockLbl
            // 
            stockLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            stockLbl.AutoSize = true;
            stockLbl.Location = new Point(171, 46);
            stockLbl.Name = "stockLbl";
            stockLbl.Size = new Size(96, 20);
            stockLbl.TabIndex = 0;
            stockLbl.Text = "stock status";
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(3, 0);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(44, 20);
            nameLbl.TabIndex = 1;
            nameLbl.Text = "name";
            // 
            // categoryLbl
            // 
            categoryLbl.AutoSize = true;
            categoryLbl.Location = new Point(3, 20);
            categoryLbl.Name = "categoryLbl";
            categoryLbl.Size = new Size(71, 20);
            categoryLbl.TabIndex = 2;
            categoryLbl.Text = "category";
            // 
            // tagsLbl
            // 
            tagsLbl.AutoSize = true;
            tagsLbl.Location = new Point(3, 72);
            tagsLbl.Name = "tagsLbl";
            tagsLbl.Size = new Size(39, 20);
            tagsLbl.TabIndex = 3;
            tagsLbl.Text = "tags";
            // 
            // somethingLbl
            // 
            somethingLbl.AutoSize = true;
            somethingLbl.Location = new Point(3, 341);
            somethingLbl.Name = "somethingLbl";
            somethingLbl.Size = new Size(242, 60);
            somethingLbl.TabIndex = 4;
            somethingLbl.Text = "error log:\r\n (top sellers is error prone due to new id system)";
            // 
            // topselerLbl
            // 
            topselerLbl.AutoSize = true;
            topselerLbl.Dock = DockStyle.Fill;
            topselerLbl.Location = new Point(3, 114);
            topselerLbl.Name = "topselerLbl";
            topselerLbl.Size = new Size(264, 227);
            topselerLbl.TabIndex = 5;
            topselerLbl.Text = "top sellers:";
            // 
            // shoppingcartGb
            // 
            shoppingcartGb.Controls.Add(tableLayoutPanel3);
            shoppingcartGb.Dock = DockStyle.Fill;
            shoppingcartGb.Location = new Point(791, 3);
            shoppingcartGb.Name = "shoppingcartGb";
            tableLayoutPanel1.SetRowSpan(shoppingcartGb, 2);
            shoppingcartGb.Size = new Size(391, 555);
            shoppingcartGb.TabIndex = 2;
            shoppingcartGb.TabStop = false;
            shoppingcartGb.Text = "shoppingcart";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 87F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 124F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(totalLbl, 2, 1);
            tableLayoutPanel3.Controls.Add(buyBtn, 1, 1);
            tableLayoutPanel3.Controls.Add(recitCb, 0, 1);
            tableLayoutPanel3.Controls.Add(shoppingcartPnl, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 24);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(385, 528);
            tableLayoutPanel3.TabIndex = 0;
            tableLayoutPanel3.Click += panel1_Click;
            // 
            // totalLbl
            // 
            totalLbl.Anchor = AnchorStyles.Left;
            totalLbl.AutoSize = true;
            totalLbl.Location = new Point(214, 492);
            totalLbl.Name = "totalLbl";
            totalLbl.Size = new Size(51, 20);
            totalLbl.TabIndex = 2;
            totalLbl.Text = "total: ";
            // 
            // buyBtn
            // 
            buyBtn.Anchor = AnchorStyles.Right;
            buyBtn.Location = new Point(102, 488);
            buyBtn.Name = "buyBtn";
            buyBtn.Size = new Size(106, 29);
            buyBtn.TabIndex = 1;
            buyBtn.Text = "buy";
            buyBtn.UseVisualStyleBackColor = true;
            buyBtn.Click += buyBtn_Click;
            // 
            // recitCb
            // 
            recitCb.AutoSize = true;
            recitCb.Location = new Point(3, 480);
            recitCb.Name = "recitCb";
            recitCb.Size = new Size(65, 24);
            recitCb.TabIndex = 8;
            recitCb.Text = "print";
            recitCb.UseVisualStyleBackColor = true;
            // 
            // shoppingcartPnl
            // 
            tableLayoutPanel3.SetColumnSpan(shoppingcartPnl, 3);
            shoppingcartPnl.Controls.Add(tableLayoutPanel5);
            shoppingcartPnl.Dock = DockStyle.Fill;
            shoppingcartPnl.Location = new Point(3, 3);
            shoppingcartPnl.Name = "shoppingcartPnl";
            shoppingcartPnl.Size = new Size(379, 471);
            shoppingcartPnl.TabIndex = 9;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tableLayoutPanel5.Controls.Add(shoppingcartLw, 0, 1);
            tableLayoutPanel5.Controls.Add(timeLbl, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 8.115942F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 91.8840561F));
            tableLayoutPanel5.Size = new Size(379, 471);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // shoppingcartLw
            // 
            shoppingcartLw.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, amountHead, idHead });
            shoppingcartLw.Dock = DockStyle.Fill;
            shoppingcartLw.FullRowSelect = true;
            shoppingcartLw.GridLines = true;
            shoppingcartLw.Location = new Point(3, 41);
            shoppingcartLw.MultiSelect = false;
            shoppingcartLw.Name = "shoppingcartLw";
            shoppingcartLw.Size = new Size(373, 427);
            shoppingcartLw.TabIndex = 7;
            shoppingcartLw.UseCompatibleStateImageBehavior = false;
            shoppingcartLw.View = View.Details;
            shoppingcartLw.DoubleClick += shoppingcartLsbx_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.DisplayIndex = 2;
            columnHeader1.Text = "price";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.DisplayIndex = 0;
            columnHeader2.Text = "#";
            columnHeader2.Width = 20;
            // 
            // amountHead
            // 
            amountHead.DisplayIndex = 1;
            amountHead.Text = "name";
            amountHead.Width = 150;
            // 
            // idHead
            // 
            idHead.Text = "id";
            idHead.Width = 0;
            // 
            // timeLbl
            // 
            timeLbl.AutoSize = true;
            timeLbl.Dock = DockStyle.Fill;
            timeLbl.Location = new Point(3, 0);
            timeLbl.Name = "timeLbl";
            timeLbl.Size = new Size(373, 38);
            timeLbl.TabIndex = 8;
            timeLbl.Text = "(give it a sec)";
            timeLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { exitToolStripMenuItem, returnItemToolStripMenuItem, printToolStripMenuItem, updateFromDatabaseToolStripMenuItem, syncLocalstockToDatabaseToolStripMenuItem, showGraphsOfPriceAndAmountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1185, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // returnItemToolStripMenuItem
            // 
            returnItemToolStripMenuItem.Name = "returnItemToolStripMenuItem";
            returnItemToolStripMenuItem.Size = new Size(96, 24);
            returnItemToolStripMenuItem.Text = "return item";
            returnItemToolStripMenuItem.Click += returnItemToolStripMenuItem_Click;
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.Size = new Size(54, 24);
            printToolStripMenuItem.Text = "print";
            printToolStripMenuItem.Click += printToolStripMenuItem_Click;
            // 
            // updateFromDatabaseToolStripMenuItem
            // 
            updateFromDatabaseToolStripMenuItem.Name = "updateFromDatabaseToolStripMenuItem";
            updateFromDatabaseToolStripMenuItem.Size = new Size(173, 24);
            updateFromDatabaseToolStripMenuItem.Text = "Update from database";
            updateFromDatabaseToolStripMenuItem.Click += updateFromDatabaseToolStripMenuItem_Click;
            // 
            // syncLocalstockToDatabaseToolStripMenuItem
            // 
            syncLocalstockToDatabaseToolStripMenuItem.Name = "syncLocalstockToDatabaseToolStripMenuItem";
            syncLocalstockToDatabaseToolStripMenuItem.Size = new Size(254, 24);
            syncLocalstockToDatabaseToolStripMenuItem.Text = "uppdate database from local stock";
            syncLocalstockToDatabaseToolStripMenuItem.Click += syncLocalstockToDatabaseToolStripMenuItem_Click;
            // 
            // showGraphsOfPriceAndAmountToolStripMenuItem
            // 
            showGraphsOfPriceAndAmountToolStripMenuItem.Name = "showGraphsOfPriceAndAmountToolStripMenuItem";
            showGraphsOfPriceAndAmountToolStripMenuItem.Size = new Size(199, 24);
            showGraphsOfPriceAndAmountToolStripMenuItem.Text = "show graphs of price stock";
            showGraphsOfPriceAndAmountToolStripMenuItem.Click += showGraphsOfPriceAndAmountToolStripMenuItem_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // storeFrm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 589);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Name = "storeFrm";
            Text = "storeFrm";
            FormClosing += storeFrm_FormClosing;
            Load += storeFrm_Load;
            Click += panel1_Click;
            tableLayoutPanel1.ResumeLayout(false);
            itemsGb.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            searchGb.ResumeLayout(false);
            searchGb.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            productInfoGb.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            shoppingcartGb.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            shoppingcartPnl.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox itemsGb;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox productInfoGb;
        private GroupBox shoppingcartGb;
        private GroupBox searchGb;
        private RadioButton customRbtn;
        private RadioButton searchNameRbtn;
        private RadioButton searchPriceRbtn;
        private TextBox searchTxb;
        private Button addBtn;
        private Label label1;
        private RadioButton miscRbtn;
        private RadioButton movieRbtn;
        private RadioButton gameRbtn;
        private RadioButton bookRbtn;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel3;
        private Button buyBtn;
        private Label totalLbl;
        private Label stockLbl;
        private Label nameLbl;
        private Label categoryLbl;
        private Label tagsLbl;
        private Label somethingLbl;
        private Panel panel1;
        private ListView itemsLw;
        private ColumnHeader nameHead;
        private ColumnHeader priceHead;
        private ColumnHeader categoryHead;
        private ColumnHeader tagsHead;
        private ColumnHeader stockHead;
        private ListView shoppingcartLw;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader amountHead;
        private ColumnHeader id;
        private ColumnHeader idHead;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem returnItemToolStripMenuItem;
        private CheckBox recitCb;
        private ToolStripMenuItem printToolStripMenuItem;
        private Panel shoppingcartPnl;
        private TableLayoutPanel tableLayoutPanel5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label timeLbl;
        private ToolStripMenuItem updateFromDatabaseToolStripMenuItem;
        private ToolStripMenuItem syncLocalstockToDatabaseToolStripMenuItem;
        private ToolStripMenuItem showGraphsOfPriceAndAmountToolStripMenuItem;
        private Label topselerLbl;
    }
}