using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmMyAlbumTool : Form
    {
        public FrmMyAlbumTool()
        {
            InitializeComponent();
        }

        private void cityTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.cityTableBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.myDataSet1);

        }

        private void cityPicTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.cityPicTableBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.myDataSet1);

        }

        private void cityPicTableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            //this.cityPicTableBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.myDataSet1);

        }

        private void cityPicTableBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.cityPicTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDataSet1);

        }

        private void cityTableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cityTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDataSet1);

        }

        private void FrmMyAlbumTool_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'myDataSet1.CityPicTable' 資料表。您可以視需要進行移動或移除。
            this.cityPicTableTableAdapter.Fill(this.myDataSet1.CityPicTable);
            // TODO: 這行程式碼會將資料載入 'aDDataSet1.ProductPhoto' 資料表。您可以視需要進行移動或移除。
            this.productPhotoTableAdapter.Fill(this.aDDataSet1.ProductPhoto);
            // TODO: 這行程式碼會將資料載入 'aDDataSet1.ProductPhoto' 資料表。您可以視需要進行移動或移除。
            this.productPhotoTableAdapter.Fill(this.aDDataSet1.ProductPhoto);
            // TODO: 這行程式碼會將資料載入 'myDataSet1.CityPicTable' 資料表。您可以視需要進行移動或移除。
            this.cityPicTableTableAdapter.Fill(this.myDataSet1.CityPicTable);
            // TODO: 這行程式碼會將資料載入 'myDataSet1.CityTable' 資料表。您可以視需要進行移動或移除。
            this.cityTableTableAdapter.Fill(this.myDataSet1.CityTable);

        }
    }
}
