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
        }

        void ConnEction()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source =.; Initial Catalog = Northwind; Integrated Security = True");
                conn.Open();
                SqlCommand command = new SqlCommand("select CategoryName  ",conn);
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

              //  MessageBox.Show("success");

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
            string Cname = comboBox1.Text;
            // string a = comboBox.SelectItem.ToString();

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

                //  MessageBox.Show("success");

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



    }
}
