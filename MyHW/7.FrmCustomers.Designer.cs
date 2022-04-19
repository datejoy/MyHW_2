
namespace MyHW
{
    partial class FrmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomers));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ImageList2 = new System.Windows.Forms.ImageList(this.components);
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.nwDataSet1 = new MyHW.NWDataSet();
            this.customersTableAdapter1 = new MyHW.NWDataSetTableAdapters.CustomersTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.largIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderAscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderByDescToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nwDataSet1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Country:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 54);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 20);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.ImageList2;
            this.listView1.Location = new System.Drawing.Point(38, 119);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(631, 293);
            this.listView1.SmallImageList = this.ImageList1;
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // ImageList2
            // 
            this.ImageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList2.ImageStream")));
            this.ImageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList2.Images.SetKeyName(0, "FLGGERM.ICO");
            this.ImageList2.Images.SetKeyName(1, "CTRCAN.ICO");
            this.ImageList2.Images.SetKeyName(2, "CTRFRAN.ICO");
            this.ImageList2.Images.SetKeyName(3, "CTRGERM.ICO");
            this.ImageList2.Images.SetKeyName(4, "CTRITALY.ICO");
            this.ImageList2.Images.SetKeyName(5, "CTRJAPAN.ICO");
            this.ImageList2.Images.SetKeyName(6, "CTRMEX.ICO");
            this.ImageList2.Images.SetKeyName(7, "CTRSKOR.ICO");
            this.ImageList2.Images.SetKeyName(8, "CTRSPAIN.ICO");
            this.ImageList2.Images.SetKeyName(9, "CTRUK.ICO");
            this.ImageList2.Images.SetKeyName(10, "CTRUSA.ICO");
            this.ImageList2.Images.SetKeyName(11, "FLGASTRL.ICO");
            this.ImageList2.Images.SetKeyName(12, "FLGAUSTA.ICO");
            this.ImageList2.Images.SetKeyName(13, "FLGBELG.ICO");
            this.ImageList2.Images.SetKeyName(14, "FLGBRAZL.ICO");
            this.ImageList2.Images.SetKeyName(15, "FLGCAN.ICO");
            this.ImageList2.Images.SetKeyName(16, "FLGDEN.ICO");
            this.ImageList2.Images.SetKeyName(17, "FLGFIN.ICO");
            this.ImageList2.Images.SetKeyName(18, "FLGFRAN.ICO");
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "FLGGERM.ICO");
            this.ImageList1.Images.SetKeyName(1, "CTRCAN.ICO");
            this.ImageList1.Images.SetKeyName(2, "CTRFRAN.ICO");
            this.ImageList1.Images.SetKeyName(3, "CTRGERM.ICO");
            this.ImageList1.Images.SetKeyName(4, "CTRITALY.ICO");
            this.ImageList1.Images.SetKeyName(5, "CTRJAPAN.ICO");
            this.ImageList1.Images.SetKeyName(6, "CTRMEX.ICO");
            this.ImageList1.Images.SetKeyName(7, "CTRSKOR.ICO");
            this.ImageList1.Images.SetKeyName(8, "CTRSPAIN.ICO");
            this.ImageList1.Images.SetKeyName(9, "CTRUK.ICO");
            this.ImageList1.Images.SetKeyName(10, "CTRUSA.ICO");
            this.ImageList1.Images.SetKeyName(11, "FLGASTRL.ICO");
            this.ImageList1.Images.SetKeyName(12, "FLGAUSTA.ICO");
            this.ImageList1.Images.SetKeyName(13, "FLGBELG.ICO");
            this.ImageList1.Images.SetKeyName(14, "FLGBRAZL.ICO");
            this.ImageList1.Images.SetKeyName(15, "FLGCAN.ICO");
            this.ImageList1.Images.SetKeyName(16, "FLGDEN.ICO");
            this.ImageList1.Images.SetKeyName(17, "FLGFIN.ICO");
            this.ImageList1.Images.SetKeyName(18, "FLGFRAN.ICO");
            // 
            // nwDataSet1
            // 
            this.nwDataSet1.DataSetName = "NWDataSet";
            this.nwDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largIconToolStripMenuItem,
            this.smallIconToolStripMenuItem,
            this.detialsToolStripMenuItem,
            this.orderByToolStripMenuItem,
            this.groupByToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 114);
            // 
            // largIconToolStripMenuItem
            // 
            this.largIconToolStripMenuItem.Name = "largIconToolStripMenuItem";
            this.largIconToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.largIconToolStripMenuItem.Text = "LargIcon";
            this.largIconToolStripMenuItem.Click += new System.EventHandler(this.largIconToolStripMenuItem_Click);
            // 
            // smallIconToolStripMenuItem
            // 
            this.smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem";
            this.smallIconToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.smallIconToolStripMenuItem.Text = "SmallIcon";
            this.smallIconToolStripMenuItem.Click += new System.EventHandler(this.smallIconToolStripMenuItem_Click);
            // 
            // detialsToolStripMenuItem
            // 
            this.detialsToolStripMenuItem.Name = "detialsToolStripMenuItem";
            this.detialsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.detialsToolStripMenuItem.Text = "Detials";
            this.detialsToolStripMenuItem.Click += new System.EventHandler(this.detialsToolStripMenuItem_Click);
            // 
            // orderByToolStripMenuItem
            // 
            this.orderByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderAscToolStripMenuItem,
            this.orderByDescToolStripMenuItem});
            this.orderByToolStripMenuItem.Name = "orderByToolStripMenuItem";
            this.orderByToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.orderByToolStripMenuItem.Text = "Order by";
            // 
            // orderAscToolStripMenuItem
            // 
            this.orderAscToolStripMenuItem.Name = "orderAscToolStripMenuItem";
            this.orderAscToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.orderAscToolStripMenuItem.Text = "Order CustomerID Asc";
            this.orderAscToolStripMenuItem.Click += new System.EventHandler(this.orderAscToolStripMenuItem_Click);
            // 
            // orderByDescToolStripMenuItem
            // 
            this.orderByDescToolStripMenuItem.Name = "orderByDescToolStripMenuItem";
            this.orderByDescToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.orderByDescToolStripMenuItem.Text = "Order By CustomerID Desc";
            this.orderByDescToolStripMenuItem.Click += new System.EventHandler(this.orderByDescToolStripMenuItem_Click);
            // 
            // groupByToolStripMenuItem
            // 
            this.groupByToolStripMenuItem.Name = "groupByToolStripMenuItem";
            this.groupByToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.groupByToolStripMenuItem.Text = "Group by";
            this.groupByToolStripMenuItem.Click += new System.EventHandler(this.groupByToolStripMenuItem_Click);
            // 
            // FrmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 429);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCustomers";
            this.Text = "FrmCustomers";
            ((System.ComponentModel.ISupportInitialize)(this.nwDataSet1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView1;
        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.ImageList ImageList2;
        private NWDataSet nwDataSet1;
        private NWDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem largIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderAscToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderByDescToolStripMenuItem;
    }
}