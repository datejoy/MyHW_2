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
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
            disConnect();
        }

        void disConnect()
        {
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            this.bindingSource1.DataSource = this.nwDataSet1.Products;
            this.dataGridView1.DataSource = this.bindingSource1;
            labRes.Text = $"結果 {this.bindingSource1.Count} 筆";
            this.bindingNavigator1.BindingSource = this.bindingSource1;
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            //找價錢區間
            decimal txtf, txtt;
            bool txtfrom = decimal.TryParse(textBox1.Text, out txtf);
            bool txtto = decimal.TryParse(textBox2.Text, out txtt);
            if( txtfrom == false || txtto == false )
            {
                MessageBox.Show("請輸入正確數字格式");
            }
            else 
            {
              this.productsTableAdapter1.MyFillBy(this.nwDataSet1.Products,txtf,txtt);
                this.bindingSource1.DataSource = this.nwDataSet1.Products;
                this.dataGridView1.DataSource = this.bindingSource1;
           //     labRes.Text = $"結果 {this.bindingSource1.Count} 筆";
                this.bindingNavigator1.BindingSource = this.bindingSource1;
            }

        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            //用名字找商品 tips:萬用字元關鍵字搜尋 like '%~~~~%'
            string s = textBox3.Text;                                                                                   //      ↓要的是這個參數
            this.productsTableAdapter1.MyFillByname(this.nwDataSet1.Products, '%'+s+'%');
            this.bindingSource1.DataSource = this.nwDataSet1.Products;
            this.dataGridView1.DataSource = this.bindingSource1;
         //   labRes.Text = $"結果 {this.bindingSource1.Count} 筆";

            this.bindingNavigator1.BindingSource = this.bindingSource1;
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveFirst();
        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position += 1;
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveNext();
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position = this.bindingSource1.Count - 1;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            labRes.Text = $"結果 {this.bindingSource1.Count} 筆";
            label2.Text = $"{this.bindingSource1.Position + 1} / {this.bindingSource1.Count}";
        }
    }
}
