namespace Final0105
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.fillBy_CountryToolStrip = new System.Windows.Forms.ToolStrip();
            this.countryToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.countryToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy_CountryToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.site_infoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.site_infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.site_info = new Final0105.Site_info();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.listToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.listToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.computer_info1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computer_info1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.computer_info = new Final0105.Computer_info();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.site_infoTableAdapter = new Final0105.Site_infoTableAdapters.Site_infoTableAdapter();
            this.tableAdapterManager = new Final0105.Site_infoTableAdapters.TableAdapterManager();
            this.computer_infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computer_infoTableAdapter = new Final0105.Computer_infoTableAdapters.Computer_infoTableAdapter();
            this.tableAdapterManager1 = new Final0105.Computer_infoTableAdapters.TableAdapterManager();
            this.computer_info1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computer_info1TableAdapter = new Final0105.Computer_infoTableAdapters.Computer_info1TableAdapter();
            this.listBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.list = new Final0105.List();
            this.listTableAdapter = new Final0105.ListTableAdapters.ListTableAdapter();
            this.tableAdapterManager2 = new Final0105.ListTableAdapters.TableAdapterManager();
            this.list1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.list1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.list1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.listDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.listToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.listToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.minRankToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.minRankToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.maxRankToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.maxRankToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.fillBy_CountryToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.site_infoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.site_infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.site_info)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computer_info1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer_info1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer_info)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computer_infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer_info1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listDataGridView)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("新細明體", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1110, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.fillBy_CountryToolStrip);
            this.tabPage1.Controls.Add(this.site_infoDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1102, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "(3)SearchCountry";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // fillBy_CountryToolStrip
            // 
            this.fillBy_CountryToolStrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fillBy_CountryToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillBy_CountryToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fillBy_CountryToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countryToolStripLabel,
            this.countryToolStripTextBox,
            this.fillBy_CountryToolStripButton});
            this.fillBy_CountryToolStrip.Location = new System.Drawing.Point(57, 45);
            this.fillBy_CountryToolStrip.Name = "fillBy_CountryToolStrip";
            this.fillBy_CountryToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.fillBy_CountryToolStrip.Size = new System.Drawing.Size(242, 32);
            this.fillBy_CountryToolStrip.TabIndex = 1;
            this.fillBy_CountryToolStrip.Text = "fillBy_CountryToolStrip";
            // 
            // countryToolStripLabel
            // 
            this.countryToolStripLabel.Name = "countryToolStripLabel";
            this.countryToolStripLabel.Size = new System.Drawing.Size(82, 27);
            this.countryToolStripLabel.Text = "Country:";
            // 
            // countryToolStripTextBox
            // 
            this.countryToolStripTextBox.Name = "countryToolStripTextBox";
            this.countryToolStripTextBox.Size = new System.Drawing.Size(68, 32);
            // 
            // fillBy_CountryToolStripButton
            // 
            this.fillBy_CountryToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy_CountryToolStripButton.Name = "fillBy_CountryToolStripButton";
            this.fillBy_CountryToolStripButton.Size = new System.Drawing.Size(71, 27);
            this.fillBy_CountryToolStripButton.Text = "Search";
            this.fillBy_CountryToolStripButton.Click += new System.EventHandler(this.fillBy_CountryToolStripButton_Click);
            // 
            // site_infoDataGridView
            // 
            this.site_infoDataGridView.AutoGenerateColumns = false;
            this.site_infoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.site_infoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.site_infoDataGridView.DataSource = this.site_infoBindingSource;
            this.site_infoDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.site_infoDataGridView.Location = new System.Drawing.Point(2, 202);
            this.site_infoDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.site_infoDataGridView.Name = "site_infoDataGridView";
            this.site_infoDataGridView.RowHeadersWidth = 62;
            this.site_infoDataGridView.RowTemplate.Height = 31;
            this.site_infoDataGridView.Size = new System.Drawing.Size(1098, 203);
            this.site_infoDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SiteID";
            this.dataGridViewTextBoxColumn1.HeaderText = "SiteID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Site";
            this.dataGridViewTextBoxColumn2.HeaderText = "Site";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn4.HeaderText = "Country";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // site_infoBindingSource
            // 
            this.site_infoBindingSource.DataMember = "Site_info";
            this.site_infoBindingSource.DataSource = this.site_info;
            // 
            // site_info
            // 
            this.site_info.DataSetName = "Site_info";
            this.site_info.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.fillToolStrip);
            this.tabPage2.Controls.Add(this.computer_info1DataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1102, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "(2)SearchComputerNum";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fillToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listToolStripLabel,
            this.listToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(25, 26);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.fillToolStrip.Size = new System.Drawing.Size(203, 32);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // listToolStripLabel
            // 
            this.listToolStripLabel.Name = "listToolStripLabel";
            this.listToolStripLabel.Size = new System.Drawing.Size(43, 27);
            this.listToolStripLabel.Text = "List:";
            // 
            // listToolStripTextBox
            // 
            this.listToolStripTextBox.Name = "listToolStripTextBox";
            this.listToolStripTextBox.Size = new System.Drawing.Size(68, 32);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(71, 27);
            this.fillToolStripButton.Text = "Search";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click_1);
            // 
            // computer_info1DataGridView
            // 
            this.computer_info1DataGridView.AutoGenerateColumns = false;
            this.computer_info1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.computer_info1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.computer_info1DataGridView.DataSource = this.computer_info1BindingSource1;
            this.computer_info1DataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.computer_info1DataGridView.Location = new System.Drawing.Point(2, 160);
            this.computer_info1DataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.computer_info1DataGridView.Name = "computer_info1DataGridView";
            this.computer_info1DataGridView.RowHeadersWidth = 62;
            this.computer_info1DataGridView.RowTemplate.Height = 31;
            this.computer_info1DataGridView.Size = new System.Drawing.Size(1098, 245);
            this.computer_info1DataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ComputerNumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "ComputerNumber";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Segment";
            this.dataGridViewTextBoxColumn5.HeaderText = "Segment";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "List";
            this.dataGridViewTextBoxColumn6.HeaderText = "List";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // computer_info1BindingSource1
            // 
            this.computer_info1BindingSource1.DataMember = "Computer_info1";
            this.computer_info1BindingSource1.DataSource = this.computer_info;
            // 
            // computer_info
            // 
            this.computer_info.DataSetName = "Computer_info";
            this.computer_info.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.fillByToolStrip);
            this.tabPage3.Controls.Add(this.listDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1102, 407);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "(5)SearchWithRank";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // site_infoTableAdapter
            // 
            this.site_infoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Site_infoTableAdapter = this.site_infoTableAdapter;
            this.tableAdapterManager.UpdateOrder = Final0105.Site_infoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // computer_infoBindingSource
            // 
            this.computer_infoBindingSource.DataMember = "Computer_info";
            this.computer_infoBindingSource.DataSource = this.computer_info;
            // 
            // computer_infoTableAdapter
            // 
            this.computer_infoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Computer_infoTableAdapter = this.computer_infoTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Final0105.Computer_infoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // computer_info1BindingSource
            // 
            this.computer_info1BindingSource.DataSource = this.computer_info;
            this.computer_info1BindingSource.Position = 0;
            // 
            // computer_info1TableAdapter
            // 
            this.computer_info1TableAdapter.ClearBeforeFill = true;
            // 
            // listBindingSource
            // 
            this.listBindingSource.DataMember = "List";
            this.listBindingSource.DataSource = this.list;
            // 
            // list
            // 
            this.list.DataSetName = "List";
            this.list.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listTableAdapter
            // 
            this.listTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.ListTableAdapter = this.listTableAdapter;
            this.tableAdapterManager2.UpdateOrder = Final0105.ListTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // list1BindingSource
            // 
            this.list1BindingSource.DataSource = this.list;
            this.list1BindingSource.Position = 0;
            // 
            // list1BindingSource1
            // 
            this.list1BindingSource1.DataSource = this.list;
            this.list1BindingSource1.Position = 0;
            // 
            // list1BindingSource2
            // 
            this.list1BindingSource2.DataSource = this.list;
            this.list1BindingSource2.Position = 0;
            // 
            // listDataGridView
            // 
            this.listDataGridView.AllowUserToAddRows = false;
            this.listDataGridView.AllowUserToDeleteRows = false;
            this.listDataGridView.AutoGenerateColumns = false;
            this.listDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn12});
            this.listDataGridView.DataSource = this.listBindingSource;
            this.listDataGridView.Location = new System.Drawing.Point(19, 140);
            this.listDataGridView.Name = "listDataGridView";
            this.listDataGridView.ReadOnly = true;
            this.listDataGridView.RowHeadersWidth = 62;
            this.listDataGridView.RowTemplate.Height = 24;
            this.listDataGridView.Size = new System.Drawing.Size(1077, 220);
            this.listDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "List";
            this.dataGridViewTextBoxColumn7.HeaderText = "List";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Rank";
            this.dataGridViewTextBoxColumn10.HeaderText = "Rank";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Computer";
            this.dataGridViewTextBoxColumn12.HeaderText = "Computer";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fillByToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listToolStripLabel1,
            this.listToolStripTextBox1,
            this.minRankToolStripLabel,
            this.minRankToolStripTextBox,
            this.maxRankToolStripLabel,
            this.maxRankToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(19, 53);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(614, 32);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // listToolStripLabel1
            // 
            this.listToolStripLabel1.Name = "listToolStripLabel1";
            this.listToolStripLabel1.Size = new System.Drawing.Size(43, 20);
            this.listToolStripLabel1.Text = "List:";
            // 
            // listToolStripTextBox1
            // 
            this.listToolStripTextBox1.Name = "listToolStripTextBox1";
            this.listToolStripTextBox1.Size = new System.Drawing.Size(100, 30);
            // 
            // minRankToolStripLabel
            // 
            this.minRankToolStripLabel.Name = "minRankToolStripLabel";
            this.minRankToolStripLabel.Size = new System.Drawing.Size(90, 23);
            this.minRankToolStripLabel.Text = "minRank:";
            // 
            // minRankToolStripTextBox
            // 
            this.minRankToolStripTextBox.Name = "minRankToolStripTextBox";
            this.minRankToolStripTextBox.Size = new System.Drawing.Size(100, 30);
            // 
            // maxRankToolStripLabel
            // 
            this.maxRankToolStripLabel.Name = "maxRankToolStripLabel";
            this.maxRankToolStripLabel.Size = new System.Drawing.Size(93, 23);
            this.maxRankToolStripLabel.Text = "maxRank:";
            // 
            // maxRankToolStripTextBox
            // 
            this.maxRankToolStripTextBox.Name = "maxRankToolStripTextBox";
            this.maxRankToolStripTextBox.Size = new System.Drawing.Size(100, 30);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(58, 27);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 437);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.fillBy_CountryToolStrip.ResumeLayout(false);
            this.fillBy_CountryToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.site_infoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.site_infoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.site_info)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computer_info1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer_info1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer_info)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computer_infoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer_info1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listDataGridView)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Site_info site_info;
        private System.Windows.Forms.BindingSource site_infoBindingSource;
        private Site_infoTableAdapters.Site_infoTableAdapter site_infoTableAdapter;
        private Site_infoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView site_infoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStrip fillBy_CountryToolStrip;
        private System.Windows.Forms.ToolStripLabel countryToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox countryToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBy_CountryToolStripButton;
        private Computer_info computer_info;
        private System.Windows.Forms.BindingSource computer_infoBindingSource;
        private Computer_infoTableAdapters.Computer_infoTableAdapter computer_infoTableAdapter;
        private Computer_infoTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource computer_info1BindingSource;
        private Computer_infoTableAdapters.Computer_info1TableAdapter computer_info1TableAdapter;
        private System.Windows.Forms.BindingSource computer_info1BindingSource1;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel listToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox listToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView computer_info1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TabPage tabPage3;
        private List list;
        private System.Windows.Forms.BindingSource listBindingSource;
        private ListTableAdapters.ListTableAdapter listTableAdapter;
        private ListTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.BindingSource list1BindingSource;
        private System.Windows.Forms.BindingSource list1BindingSource1;
        private System.Windows.Forms.BindingSource list1BindingSource2;
        private System.Windows.Forms.DataGridView listDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel listToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox listToolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel minRankToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox minRankToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel maxRankToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox maxRankToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}

