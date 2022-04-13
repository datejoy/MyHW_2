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
    public partial class FrmCategoryProducts : Form
    {
        public FrmCategoryProducts()
        {
            InitializeComponent();
            ConnEction();
            disconEct();
        }

        void ConnEction()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source =.; Initial Catalog = Northwind; Integrated Security = True");
                conn.Open();
                SqlCommand command = new SqlCommand("select CategoryName from Categories ",conn);
                SqlDataReader datareader = command.ExecuteReader();

                while(datareader.Read())
                {
                    string s = datareader["CategoryName"].ToString();
                    comboBox1.Items.Add(s);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if( conn != null )
                {
                    conn.Close();
                }
            }

         }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Cname = comboBox1.Text;
            // string a = comboBox.SelectItem.ToString();
            //int a = comboBox1.SelectedIndex;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source =.; Initial Catalog = Northwind; Integrated Security = True");
                conn.Open();

                SqlCommand command = new SqlCommand($"select ProductName,UnitPrice  from Categories c " +
                    $"join Products p on p.CategoryID = c.CategoryID where c.CategoryName = '{Cname}'", conn);

                SqlDataReader datareader = command.ExecuteReader();
                listBox1.Items.Clear();
                while (datareader.Read())
                {
                    string s = $"{datareader["ProductName"],-40}：{datareader["UnitPrice"]:c2}";
                    listBox1.Items.Add(s);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //以CategoryName為條件搜尋
            this.productsTableAdapter1.FillBydis(this.nwDataSet1.Products, comboBox2.Text);  
            //把PK拿掉且select所有欄位→建了PK & 選擇所有欄位 才成功
            
            DataTable dt = this.nwDataSet1.Tables["Products"];
            //算每個row(橫)的
            listBox2.Items.Clear();
            for ( int i=0 ; i<dt.Rows.Count ; i ++ )
            {
                string s = $" { this.nwDataSet1.Products.Rows[i]["ProductName"],-40}：{this.nwDataSet1.Products.Rows[i]["UnitPrice"]:c2}";
                listBox2.Items.Add(s);
            }
            
           
        }

        void disconEct()
        {
            //一開始將資料倒入視窗
            this.categoriesTableAdapter1. Fill(this.nwDataSet1.Categories);

            //將CategoryName連至comboBox
            for (int i = 0; i < nwDataSet1.Tables["Categories"].Rows.Count; i++)
            {
                //↓Categories裡的每個row(橫的)
                string s = this.nwDataSet1.Categories[i].CategoryName;
                //↑每個row的種類名(資料行內容)
                comboBox2.Items.Add(s);
            }

        }
    }
}
