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
    public partial class FrmDataSet結構 : Form
    {
        public FrmDataSet結構()
        {
            InitializeComponent();
            loadgriView();
        }

        void loadgriView()
        {
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            this.categoriesTableAdapter1.Fill(this.nwDataSet1.Categories);
            this.customersTableAdapter1.Fill(this.nwDataSet1.Customers);
            this.dataGridView1.DataSource = this.nwDataSet1.Products;
            this.dataGridView2.DataSource = this.nwDataSet1.Categories;
            this.dataGridView3.DataSource = this.nwDataSet1.Customers;
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for ( int i = 0; i<this.nwDataSet1.Tables.Count; i++ )
            {
                //第一層 資料表名稱
                listBox1.Items.Add(nwDataSet1.Tables[i].TableName);
               
                DataTable tb = this.nwDataSet1.Tables[i];
                //第二層 資料行名稱
                string s = "";
                for ( int column =0; column<tb.Columns.Count; column++  )
                {
                    s += $"{tb.Columns[column].ColumnName,-40}";
                }
                listBox1.Items.Add(s);
                
                //第三層 顯示每個row
                for ( int row=0 ; row<tb.Rows.Count ; row++ )
                {
                    string r = "";
                    //第四層 每個row裡面的每個column
                    for ( int col =0 ; col<tb.Columns.Count ; col++ )
                    {
                       r += $"{tb.Rows[row][col],-40}";
                    }
                    listBox1.Items.Add(r);
                }


                listBox1.Items.Add("=============================================================================================================================================================================");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //收合
            this.splitContainer2.Panel1Collapsed = !this.splitContainer2.Panel1Collapsed;
        }
    }
}
