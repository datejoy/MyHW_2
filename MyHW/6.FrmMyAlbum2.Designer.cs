
namespace MyHW
{
    partial class FrmMyAlbum2
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
            System.Windows.Forms.Label photoIDLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label cityPhotoLabel;
            System.Windows.Forms.Label cityIDLabel;
            System.Windows.Forms.Label cityNameLabel1;
            System.Windows.Forms.Label cityNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMyAlbum2));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.cityIDTextBox = new System.Windows.Forms.TextBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myAlbumDataSet11 = new MyHW.MyAlbumDataSet1();
            this.cityNameTextBox = new System.Windows.Forms.TextBox();
            this.cityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cityBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cityDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityNameTextBox1 = new System.Windows.Forms.TextBox();
            this.photoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBrowse = new System.Windows.Forms.Button();
            this.photobindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.photoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.photoIDTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.cityPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cityTableAdapter1 = new MyHW.MyAlbumDataSet1TableAdapters.CityTableAdapter();
            this.photoTableAdapter1 = new MyHW.MyAlbumDataSet1TableAdapters.PhotoTableAdapter();
            this.tableAdapterManager = new MyHW.MyAlbumDataSet1TableAdapters.TableAdapterManager();
            photoIDLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            cityPhotoLabel = new System.Windows.Forms.Label();
            cityIDLabel = new System.Windows.Forms.Label();
            cityNameLabel1 = new System.Windows.Forms.Label();
            cityNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAlbumDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingNavigator)).BeginInit();
            this.cityBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photobindingNavigator1)).BeginInit();
            this.photobindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityPhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // photoIDLabel
            // 
            photoIDLabel.AutoSize = true;
            photoIDLabel.Location = new System.Drawing.Point(706, 67);
            photoIDLabel.Name = "photoIDLabel";
            photoIDLabel.Size = new System.Drawing.Size(92, 24);
            photoIDLabel.TabIndex = 1;
            photoIDLabel.Text = "Photo ID:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(706, 138);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(117, 24);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Description:";
            // 
            // cityPhotoLabel
            // 
            cityPhotoLabel.AutoSize = true;
            cityPhotoLabel.Location = new System.Drawing.Point(706, 172);
            cityPhotoLabel.Name = "cityPhotoLabel";
            cityPhotoLabel.Size = new System.Drawing.Size(108, 24);
            cityPhotoLabel.TabIndex = 7;
            cityPhotoLabel.Text = "City Photo:";
            // 
            // cityIDLabel
            // 
            cityIDLabel.AutoSize = true;
            cityIDLabel.Location = new System.Drawing.Point(80, 82);
            cityIDLabel.Name = "cityIDLabel";
            cityIDLabel.Size = new System.Drawing.Size(73, 24);
            cityIDLabel.TabIndex = 2;
            cityIDLabel.Text = "City ID:";
            // 
            // cityNameLabel1
            // 
            cityNameLabel1.AutoSize = true;
            cityNameLabel1.Location = new System.Drawing.Point(45, 125);
            cityNameLabel1.Name = "cityNameLabel1";
            cityNameLabel1.Size = new System.Drawing.Size(108, 24);
            cityNameLabel1.TabIndex = 4;
            cityNameLabel1.Text = "City Name:";
            // 
            // cityNameLabel
            // 
            cityNameLabel.AutoSize = true;
            cityNameLabel.Location = new System.Drawing.Point(706, 107);
            cityNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cityNameLabel.Name = "cityNameLabel";
            cityNameLabel.Size = new System.Drawing.Size(108, 24);
            cityNameLabel.TabIndex = 10;
            cityNameLabel.Text = "City Name:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1639, 813);
            this.splitContainer1.SplitterDistance = 152;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(645, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 105);
            this.label2.TabIndex = 0;
            this.label2.Text = "𝔐𝔶𝔄𝔩𝔟𝔲𝔪";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1639, 656);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(1631, 627);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "瀏覽相片";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(4, 3);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer2.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel1.BackgroundImage")));
            this.splitContainer2.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(1623, 621);
            this.splitContainer2.SplitterDistance = 283;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1335, 621);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer4);
            this.tabPage2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(1631, 627);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "新增相片管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(4, 3);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer4.Panel1.BackgroundImage")));
            this.splitContainer4.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer4.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer4.Panel2.BackgroundImage")));
            this.splitContainer4.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer4.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer4.Size = new System.Drawing.Size(1623, 621);
            this.splitContainer4.SplitterDistance = 86;
            this.splitContainer4.SplitterWidth = 5;
            this.splitContainer4.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 28);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 32);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "選分類";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1623, 530);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer3);
            this.tabPage3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Size = new System.Drawing.Size(1631, 627);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tool";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(4, 3);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.AutoScroll = true;
            this.splitContainer3.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer3.Panel1.BackgroundImage")));
            this.splitContainer3.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer3.Panel1.Controls.Add(cityIDLabel);
            this.splitContainer3.Panel1.Controls.Add(this.cityIDTextBox);
            this.splitContainer3.Panel1.Controls.Add(cityNameLabel1);
            this.splitContainer3.Panel1.Controls.Add(this.cityNameTextBox);
            this.splitContainer3.Panel1.Controls.Add(this.cityBindingNavigator);
            this.splitContainer3.Panel1.Controls.Add(this.cityDataGridView);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.AutoScroll = true;
            this.splitContainer3.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer3.Panel2.BackgroundImage")));
            this.splitContainer3.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer3.Panel2.Controls.Add(cityNameLabel);
            this.splitContainer3.Panel2.Controls.Add(this.cityNameTextBox1);
            this.splitContainer3.Panel2.Controls.Add(this.btnBrowse);
            this.splitContainer3.Panel2.Controls.Add(this.photobindingNavigator1);
            this.splitContainer3.Panel2.Controls.Add(this.photoDataGridView);
            this.splitContainer3.Panel2.Controls.Add(photoIDLabel);
            this.splitContainer3.Panel2.Controls.Add(this.photoIDTextBox);
            this.splitContainer3.Panel2.Controls.Add(descriptionLabel);
            this.splitContainer3.Panel2.Controls.Add(this.descriptionTextBox);
            this.splitContainer3.Panel2.Controls.Add(cityPhotoLabel);
            this.splitContainer3.Panel2.Controls.Add(this.cityPhotoPictureBox);
            this.splitContainer3.Size = new System.Drawing.Size(1623, 621);
            this.splitContainer3.SplitterDistance = 401;
            this.splitContainer3.TabIndex = 0;
            // 
            // cityIDTextBox
            // 
            this.cityIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "CityID", true));
            this.cityIDTextBox.Location = new System.Drawing.Point(174, 77);
            this.cityIDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cityIDTextBox.Name = "cityIDTextBox";
            this.cityIDTextBox.Size = new System.Drawing.Size(147, 32);
            this.cityIDTextBox.TabIndex = 3;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.myAlbumDataSet11;
            // 
            // myAlbumDataSet11
            // 
            this.myAlbumDataSet11.DataSetName = "MyAlbumDataSet1";
            this.myAlbumDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cityNameTextBox
            // 
            this.cityNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "CityName", true));
            this.cityNameTextBox.Location = new System.Drawing.Point(174, 122);
            this.cityNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cityNameTextBox.Name = "cityNameTextBox";
            this.cityNameTextBox.Size = new System.Drawing.Size(147, 32);
            this.cityNameTextBox.TabIndex = 5;
            // 
            // cityBindingNavigator
            // 
            this.cityBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cityBindingNavigator.BindingSource = this.cityBindingSource;
            this.cityBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cityBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cityBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cityBindingNavigatorSaveItem});
            this.cityBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cityBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cityBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cityBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cityBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cityBindingNavigator.Name = "cityBindingNavigator";
            this.cityBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.cityBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cityBindingNavigator.Size = new System.Drawing.Size(420, 31);
            this.cityBindingNavigator.TabIndex = 1;
            this.cityBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(45, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // cityBindingNavigatorSaveItem
            // 
            this.cityBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cityBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cityBindingNavigatorSaveItem.Image")));
            this.cityBindingNavigatorSaveItem.Name = "cityBindingNavigatorSaveItem";
            this.cityBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.cityBindingNavigatorSaveItem.Text = "儲存資料";
            this.cityBindingNavigatorSaveItem.Click += new System.EventHandler(this.cityBindingNavigatorSaveItem_Click);
            // 
            // cityDataGridView
            // 
            this.cityDataGridView.AutoGenerateColumns = false;
            this.cityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.cityDataGridView.DataSource = this.cityBindingSource;
            this.cityDataGridView.Location = new System.Drawing.Point(35, 274);
            this.cityDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cityDataGridView.Name = "cityDataGridView";
            this.cityDataGridView.RowHeadersWidth = 62;
            this.cityDataGridView.RowTemplate.Height = 31;
            this.cityDataGridView.Size = new System.Drawing.Size(385, 144);
            this.cityDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CityID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CityID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CityName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CityName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // cityNameTextBox1
            // 
            this.cityNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photoBindingSource, "CityName", true));
            this.cityNameTextBox1.Location = new System.Drawing.Point(837, 98);
            this.cityNameTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cityNameTextBox1.Name = "cityNameTextBox1";
            this.cityNameTextBox1.Size = new System.Drawing.Size(205, 32);
            this.cityNameTextBox1.TabIndex = 11;
            // 
            // photoBindingSource
            // 
            this.photoBindingSource.DataMember = "Photo";
            this.photoBindingSource.DataSource = this.myAlbumDataSet11;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(862, 482);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(160, 48);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // photobindingNavigator1
            // 
            this.photobindingNavigator1.AddNewItem = this.toolStripButton1;
            this.photobindingNavigator1.BindingSource = this.photoBindingSource;
            this.photobindingNavigator1.CountItem = this.toolStripLabel1;
            this.photobindingNavigator1.DeleteItem = this.toolStripButton2;
            this.photobindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.photobindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton7});
            this.photobindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.photobindingNavigator1.MoveFirstItem = this.toolStripButton3;
            this.photobindingNavigator1.MoveLastItem = this.toolStripButton6;
            this.photobindingNavigator1.MoveNextItem = this.toolStripButton5;
            this.photobindingNavigator1.MovePreviousItem = this.toolStripButton4;
            this.photobindingNavigator1.Name = "photobindingNavigator1";
            this.photobindingNavigator1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.photobindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.photobindingNavigator1.Size = new System.Drawing.Size(1218, 31);
            this.photobindingNavigator1.TabIndex = 9;
            this.photobindingNavigator1.Text = "photobindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "加入新的";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(34, 28);
            this.toolStripLabel1.Text = "/{0}";
            this.toolStripLabel1.ToolTipText = "項目總數";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton2.Text = "刪除";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton3.Text = "移到最前面";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton4.Text = "移到上一個";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "位置";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(45, 27);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "目前的位置";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton5.Text = "移到下一個";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton6.Text = "移到最後面";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton7.Text = "儲存資料";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // photoDataGridView
            // 
            this.photoDataGridView.AutoGenerateColumns = false;
            this.photoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.photoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewImageColumn1});
            this.photoDataGridView.DataSource = this.photoBindingSource;
            this.photoDataGridView.Location = new System.Drawing.Point(28, 159);
            this.photoDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.photoDataGridView.Name = "photoDataGridView";
            this.photoDataGridView.RowHeadersWidth = 62;
            this.photoDataGridView.RowTemplate.Height = 31;
            this.photoDataGridView.Size = new System.Drawing.Size(644, 358);
            this.photoDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PhotoID";
            this.dataGridViewTextBoxColumn3.HeaderText = "PhotoID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CityName";
            this.dataGridViewTextBoxColumn4.HeaderText = "CityName";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn5.HeaderText = "Description";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "CityPhoto";
            this.dataGridViewImageColumn1.HeaderText = "CityPhoto";
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 150;
            // 
            // photoIDTextBox
            // 
            this.photoIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photoBindingSource, "PhotoID", true));
            this.photoIDTextBox.Location = new System.Drawing.Point(837, 63);
            this.photoIDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.photoIDTextBox.Name = "photoIDTextBox";
            this.photoIDTextBox.Size = new System.Drawing.Size(205, 32);
            this.photoIDTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photoBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(837, 137);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(205, 32);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // cityPhotoPictureBox
            // 
            this.cityPhotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cityPhotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cityPhotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.photoBindingSource, "CityPhoto", true));
            this.cityPhotoPictureBox.Location = new System.Drawing.Point(839, 175);
            this.cityPhotoPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cityPhotoPictureBox.Name = "cityPhotoPictureBox";
            this.cityPhotoPictureBox.Size = new System.Drawing.Size(265, 286);
            this.cityPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cityPhotoPictureBox.TabIndex = 8;
            this.cityPhotoPictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cityTableAdapter1
            // 
            this.cityTableAdapter1.ClearBeforeFill = true;
            // 
            // photoTableAdapter1
            // 
            this.photoTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CityTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.PhotoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MyHW.MyAlbumDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmMyAlbum2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1639, 813);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmMyAlbum2";
            this.Text = "FrmMyAlbum2";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAlbumDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingNavigator)).EndInit();
            this.cityBindingNavigator.ResumeLayout(false);
            this.cityBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photobindingNavigator1)).EndInit();
            this.photobindingNavigator1.ResumeLayout(false);
            this.photobindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityPhotoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MyAlbumDataSet1 myAlbumDataSet11;
        private MyAlbumDataSet1TableAdapters.CityTableAdapter cityTableAdapter1;
        private MyAlbumDataSet1TableAdapters.PhotoTableAdapter photoTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private MyAlbumDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cityBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cityBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cityDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox photoIDTextBox;
        private System.Windows.Forms.BindingSource photoBindingSource;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox cityPhotoPictureBox;
        private System.Windows.Forms.TextBox cityIDTextBox;
        private System.Windows.Forms.TextBox cityNameTextBox;
        private System.Windows.Forms.DataGridView photoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.BindingNavigator photobindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox cityNameTextBox1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}