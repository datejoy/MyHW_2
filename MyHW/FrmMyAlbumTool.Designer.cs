
namespace MyHW
{
    partial class FrmMyAlbumTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMyAlbumTool));
            this.myDataSet1 = new MyHW.MyDataSet1();
            this.cityTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityTableTableAdapter = new MyHW.MyDataSet1TableAdapters.CityTableTableAdapter();
            this.tableAdapterManager = new MyHW.MyDataSet1TableAdapters.TableAdapterManager();
            this.cityTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cityTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cityPicTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityPicTableTableAdapter = new MyHW.MyDataSet1TableAdapters.CityPicTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityTableBindingNavigator)).BeginInit();
            this.cityTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityPicTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // myDataSet1
            // 
            this.myDataSet1.DataSetName = "MyDataSet1";
            this.myDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cityTableBindingSource
            // 
            this.cityTableBindingSource.DataMember = "CityTable";
            this.cityTableBindingSource.DataSource = this.myDataSet1;
            // 
            // cityTableTableAdapter
            // 
            this.cityTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CityPicTableTableAdapter = this.cityPicTableTableAdapter;
            this.tableAdapterManager.CityTableTableAdapter = this.cityTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = MyHW.MyDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cityTableBindingNavigator
            // 
            this.cityTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cityTableBindingNavigator.BindingSource = this.cityTableBindingSource;
            this.cityTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cityTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cityTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cityTableBindingNavigatorSaveItem});
            this.cityTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cityTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cityTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cityTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cityTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cityTableBindingNavigator.Name = "cityTableBindingNavigator";
            this.cityTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cityTableBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.cityTableBindingNavigator.TabIndex = 0;
            this.cityTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(27, 15);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // cityTableBindingNavigatorSaveItem
            // 
            this.cityTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cityTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cityTableBindingNavigatorSaveItem.Image")));
            this.cityTableBindingNavigatorSaveItem.Name = "cityTableBindingNavigatorSaveItem";
            this.cityTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.cityTableBindingNavigatorSaveItem.Text = "儲存資料";
            this.cityTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.cityTableBindingNavigatorSaveItem_Click_1);
            // 
            // cityPicTableBindingSource
            // 
            this.cityPicTableBindingSource.DataMember = "CityPicTable";
            this.cityPicTableBindingSource.DataSource = this.myDataSet1;
            // 
            // cityPicTableTableAdapter
            // 
            this.cityPicTableTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMyAlbumTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cityTableBindingNavigator);
            this.Name = "FrmMyAlbumTool";
            this.Text = "FrmMyAlbumTool";
            this.Load += new System.EventHandler(this.FrmMyAlbumTool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityTableBindingNavigator)).EndInit();
            this.cityTableBindingNavigator.ResumeLayout(false);
            this.cityTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityPicTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyDataSet1 myDataSet1;
        private System.Windows.Forms.BindingSource cityTableBindingSource;
        private MyDataSet1TableAdapters.CityTableTableAdapter cityTableTableAdapter;
        private MyDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cityTableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cityTableBindingNavigatorSaveItem;
        private MyDataSet1TableAdapters.CityPicTableTableAdapter cityPicTableTableAdapter;
        private System.Windows.Forms.BindingSource cityPicTableBindingSource;
    }
}