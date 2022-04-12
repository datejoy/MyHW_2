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
            //string s = comboBox1.Text;
            //SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = Northwind; Integrated Security = True");
            //SqlDataAdapter adapter = new SqlDataAdapter($"select ProductName,UnitPrice from Categories c " +
            //    $"join Products p on c.CategoryID = p.CategoryID where c.CategoryName = '{s}' ", conn);
            //DataSet ds = new DataSet();
            //adapter.Fill(ds);
            //this.dataGridView1.DataSource = ds.Tables[0];
        
        }

        void disconEct()
        {
          ////  this.productsTableAdapter1.MyFillByname(this.nwDataSet1.Products, comboBox2.Text);
          //  this.categoriesTableAdapter1. Fill(this.nwDataSet1.Categories);

          // // this.categoriesTableAdapter1.MYFillBydisn(this.nwDataSet1.Categories, comboBox2.Text);

        }
    }
}
