using MyHW.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmAdventureWorks : Form
    {
        public FrmAdventureWorks()
        {
            InitializeComponent();
            //一開始倒好資料、與控制項綁定
            Putdata();
            BikeYear();
        }

        void Putdata()
        {
            this.productPhotoTableAdapter1.Fill(this.adDataSet11.ProductPhoto);
            this.bindingSource1.DataSource = this.adDataSet11.ProductPhoto;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.pictureBox1.DataBindings.Add( "Image", this.bindingSource1, "LargePhoto",true);
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            //倒Year的資料 要另外建方法果沒見則會顯示所有資料日期

        }

        void BikeYear()
        {
            //2.0新方法
            //錯誤'無法啟用條件約束。一或多個資料列的值違反非 Null、唯一或外部索引鍵條件約束。'
            //錯誤後解除PK→允許null→都無法→select後加了distinct→解除PK選擇所有欄位，還是失敗
            //this.productPhotoTableAdapter1.FillByYear(this.adDataSet11.ProductPhoto);
            //for (int i = 0; i < this.adDataSet11.ProductPhoto.Rows.Count; i++)
            //{
            //    string s = $"{this.adDataSet11.ProductPhoto[i].ModifiedDate}";
            //    comboBox1.Items.Add(s);
            //}

            //=====================================================================
            //1.0方法
            SqlConnection conn = new SqlConnection(Settings.Default.AdventureWorks2019ConnectionString);
            SqlDataAdapter ad = new SqlDataAdapter("select distinct convert(char(4), ModifiedDate, 102) as 'Year' from[Production].[ProductPhoto] group by ModifiedDate",conn);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            string r = "";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                    r = $"{ds.Tables[0].Rows[i]["Year"]}";
                comboBox1.Items.Add(r);
            }
            

        }



        private void button13_Click(object sender, EventArgs e)
        {//最前
            this.bindingSource1.Position = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {//前一個
            this.bindingSource1.MovePrevious();
        }

        private void button15_Click(object sender, EventArgs e)
        {//下一個
            this.bindingSource1.Position += 1;
        }

        private void button16_Click(object sender, EventArgs e)
        {//最後
            this.bindingSource1.MoveLast();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            label4.Text = $"{this.bindingSource1.Position+1} / {this.bindingSource1.Count}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //日期區間
            DateTime d1 = dateTimePicker1.Value;
            DateTime d2 = dateTimePicker2.Value;
            this.productPhotoTableAdapter1.FillByModifiedDate(this.adDataSet11.ProductPhoto, d1, d2);
            this.bindingSource1.DataSource = this.adDataSet11.ProductPhoto;
            this.dataGridView1.DataSource = this.bindingSource1;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //選年分找商品
            this.productPhotoTableAdapter1.selectYearFill(this.adDataSet11.ProductPhoto,comboBox1.Text);
            this.bindingSource1.DataSource = this.adDataSet11.ProductPhoto;
            this.dataGridView1.DataSource = this.bindingSource1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //排序???排序datagridView

            //this.productPhotoTableAdapter1.FillByorderby(this.adDataSet11.ProductPhoto);
            dataGridView1.Sort(dataGridView1.Columns["ModifiedDate"], ListSortDirection.Ascending);//會全部一起排好

        }
    }
}
