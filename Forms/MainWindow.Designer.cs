namespace _1271713_ADO.NetCCProjectByNewaz
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.newazProjectDBDataSet = new _1271713_ADO.NetCCProjectByNewaz.NewazProjectDBDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBikePrice = new System.Windows.Forms.Label();
            this.lblBikeName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBikeId = new System.Windows.Forms.Label();
            this.txtBikePrice = new System.Windows.Forms.TextBox();
            this.txtBikeName = new System.Windows.Forms.TextBox();
            this.txtBikeId = new System.Windows.Forms.TextBox();
            this.bikeList = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.custIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pic = new System.Windows.Forms.DataGridViewImageColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.lblPayAmount = new System.Windows.Forms.Label();
            this.newazProjectDBDataSet2 = new _1271713_ADO.NetCCProjectByNewaz.Database.NewazProjectDBDataSet();
            this.btnOrder = new System.Windows.Forms.Button();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.picbikeshow = new System.Windows.Forms.PictureBox();
            this.customerTableAdapter = new _1271713_ADO.NetCCProjectByNewaz.NewazProjectDBDataSetTableAdapters.CustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.newazProjectDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newazProjectDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbikeshow)).BeginInit();
            this.SuspendLayout();
            // 
            // newazProjectDBDataSet
            // 
            this.newazProjectDBDataSet.DataSetName = "NewazProjectDBDataSet";
            this.newazProjectDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(116, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // lblBikePrice
            // 
            this.lblBikePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBikePrice.AutoSize = true;
            this.lblBikePrice.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBikePrice.Location = new System.Drawing.Point(179, 358);
            this.lblBikePrice.Name = "lblBikePrice";
            this.lblBikePrice.Size = new System.Drawing.Size(87, 19);
            this.lblBikePrice.TabIndex = 56;
            this.lblBikePrice.Text = "Bike Price:";
            // 
            // lblBikeName
            // 
            this.lblBikeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBikeName.AutoSize = true;
            this.lblBikeName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBikeName.Location = new System.Drawing.Point(179, 315);
            this.lblBikeName.Name = "lblBikeName";
            this.lblBikeName.Size = new System.Drawing.Size(91, 19);
            this.lblBikeName.TabIndex = 57;
            this.lblBikeName.Text = "Bike Name:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(290, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 37);
            this.label7.TabIndex = 58;
            this.label7.Text = "Create Order!!";
            // 
            // lblBikeId
            // 
            this.lblBikeId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBikeId.AutoSize = true;
            this.lblBikeId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBikeId.Location = new System.Drawing.Point(179, 271);
            this.lblBikeId.Name = "lblBikeId";
            this.lblBikeId.Size = new System.Drawing.Size(61, 19);
            this.lblBikeId.TabIndex = 59;
            this.lblBikeId.Text = "BikeId:";
            // 
            // txtBikePrice
            // 
            this.txtBikePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBikePrice.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBikePrice.Location = new System.Drawing.Point(276, 355);
            this.txtBikePrice.Name = "txtBikePrice";
            this.txtBikePrice.ReadOnly = true;
            this.txtBikePrice.Size = new System.Drawing.Size(131, 26);
            this.txtBikePrice.TabIndex = 53;
            this.txtBikePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBikePrice.TextChanged += new System.EventHandler(this.txtBikePrice_TextChanged);
            // 
            // txtBikeName
            // 
            this.txtBikeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBikeName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBikeName.Location = new System.Drawing.Point(276, 312);
            this.txtBikeName.Name = "txtBikeName";
            this.txtBikeName.ReadOnly = true;
            this.txtBikeName.Size = new System.Drawing.Size(131, 26);
            this.txtBikeName.TabIndex = 54;
            this.txtBikeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBikeId
            // 
            this.txtBikeId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBikeId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBikeId.Location = new System.Drawing.Point(276, 268);
            this.txtBikeId.Name = "txtBikeId";
            this.txtBikeId.ReadOnly = true;
            this.txtBikeId.Size = new System.Drawing.Size(131, 26);
            this.txtBikeId.TabIndex = 55;
            this.txtBikeId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bikeList
            // 
            this.bikeList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bikeList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bikeList.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bikeList.FormattingEnabled = true;
            this.bikeList.ItemHeight = 17;
            this.bikeList.Location = new System.Drawing.Point(17, 271);
            this.bikeList.Name = "bikeList";
            this.bikeList.Size = new System.Drawing.Size(142, 106);
            this.bikeList.TabIndex = 52;
            this.bikeList.Tag = "";
            this.bikeList.SelectedIndexChanged += new System.EventHandler(this.bikeList_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(345, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(268, 35);
            this.label9.TabIndex = 51;
            this.label9.Text = "User Information";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Silver;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogout.Location = new System.Drawing.Point(677, 481);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 40);
            this.btnLogout.TabIndex = 50;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.Pic,
            this.Update,
            this.DeleteBtn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(38, 60);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(639, 88);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // custIdDataGridViewTextBoxColumn
            // 
            this.custIdDataGridViewTextBoxColumn.DataPropertyName = "CustId";
            this.custIdDataGridViewTextBoxColumn.HeaderText = "CustId";
            this.custIdDataGridViewTextBoxColumn.Name = "custIdDataGridViewTextBoxColumn";
            this.custIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // Pic
            // 
            this.Pic.DataPropertyName = "Pic";
            this.Pic.HeaderText = "Pic";
            this.Pic.Name = "Pic";
            // 
            // Update
            // 
            this.Update.DataPropertyName = "Update";
            this.Update.HeaderText = "Edit";
            this.Update.Name = "Update";
            this.Update.Text = "Edit";
            this.Update.UseColumnTextForButtonValue = true;
            this.Update.Width = 70;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.DataPropertyName = "Delete";
            this.DeleteBtn.HeaderText = "Delete Account";
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Text = "Delete Account";
            this.DeleteBtn.UseColumnTextForButtonValue = true;
            this.DeleteBtn.Width = 120;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.newazProjectDBDataSet;
            // 
            // txtCustName
            // 
            this.txtCustName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCustName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(135, 212);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.ReadOnly = true;
            this.txtCustName.Size = new System.Drawing.Size(219, 26);
            this.txtCustName.TabIndex = 55;
            this.txtCustName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 59;
            this.label1.Text = "Cutomer Name:";
            // 
            // txtCustAdd
            // 
            this.txtCustAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCustAdd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustAdd.Location = new System.Drawing.Point(519, 212);
            this.txtCustAdd.Name = "txtCustAdd";
            this.txtCustAdd.ReadOnly = true;
            this.txtCustAdd.Size = new System.Drawing.Size(248, 26);
            this.txtCustAdd.TabIndex = 55;
            this.txtCustAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 59;
            this.label2.Text = "Delivary Address:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(654, 294);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(103, 24);
            this.numericUpDown1.TabIndex = 61;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(574, 296);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(78, 19);
            this.lblQuantity.TabIndex = 56;
            this.lblQuantity.Text = "Quantity:";
            // 
            // txtPayAmount
            // 
            this.txtPayAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPayAmount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayAmount.Location = new System.Drawing.Point(619, 411);
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.ReadOnly = true;
            this.txtPayAmount.Size = new System.Drawing.Size(134, 26);
            this.txtPayAmount.TabIndex = 53;
            this.txtPayAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPayAmount
            // 
            this.lblPayAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPayAmount.AutoSize = true;
            this.lblPayAmount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayAmount.Location = new System.Drawing.Point(480, 414);
            this.lblPayAmount.Name = "lblPayAmount";
            this.lblPayAmount.Size = new System.Drawing.Size(133, 19);
            this.lblPayAmount.TabIndex = 56;
            this.lblPayAmount.Text = "Payable Amount:";
            // 
            // newazProjectDBDataSet2
            // 
            this.newazProjectDBDataSet2.DataSetName = "NewazProjectDBDataSet";
            this.newazProjectDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOrder.BackColor = System.Drawing.Color.Green;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrder.Location = new System.Drawing.Point(312, 478);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(145, 43);
            this.btnOrder.TabIndex = 50;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // txtCustId
            // 
            this.txtCustId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCustId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustId.Location = new System.Drawing.Point(16, 186);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.ReadOnly = true;
            this.txtCustId.Size = new System.Drawing.Size(10, 26);
            this.txtCustId.TabIndex = 55;
            this.txtCustId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCustId.Visible = false;
            // 
            // picbikeshow
            // 
            this.picbikeshow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picbikeshow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbikeshow.Location = new System.Drawing.Point(426, 268);
            this.picbikeshow.Name = "picbikeshow";
            this.picbikeshow.Size = new System.Drawing.Size(117, 109);
            this.picbikeshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbikeshow.TabIndex = 62;
            this.picbikeshow.TabStop = false;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(785, 533);
            this.Controls.Add(this.picbikeshow);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPayAmount);
            this.Controls.Add(this.lblBikePrice);
            this.Controls.Add(this.lblBikeName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBikeId);
            this.Controls.Add(this.txtPayAmount);
            this.Controls.Add(this.txtCustAdd);
            this.Controls.Add(this.txtBikePrice);
            this.Controls.Add(this.txtCustId);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.txtBikeName);
            this.Controls.Add(this.txtBikeId);
            this.Controls.Add(this.bikeList);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.Activated += new System.EventHandler(this.MainWindow_Activated);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newazProjectDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newazProjectDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbikeshow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Database.NewazProjectDBDataSet newazProjectDBDataSet2;
        private NewazProjectDBDataSet newazProjectDBDataSet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBikePrice;
        private System.Windows.Forms.Label lblBikeName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBikeId;
        private System.Windows.Forms.TextBox txtBikePrice;
        private System.Windows.Forms.TextBox txtBikeName;
        private System.Windows.Forms.TextBox txtBikeId;
        private System.Windows.Forms.ListBox bikeList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtPayAmount;
        private System.Windows.Forms.Label lblPayAmount;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.PictureBox picbikeshow;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private NewazProjectDBDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Pic;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteBtn;
    }
}