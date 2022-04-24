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
    public partial class FrmTreeView : Form
    {
        public FrmTreeView()
        {
            InitializeComponent();
            CustomerNode();
        }

        void CustomerNode()
        {


            try 
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {

                    //    SqlCommand comm = new SqlCommand("select distinct country , city, count(*) as 'counts' from customers group by Country,City order by Country", conn);
                    //    SqlDataReader reader = comm.ExecuteReader();
                    //    string s= $"{reader["country"]}";
                    //    while (reader.Read())
                    //    {

                    //        if (reader.Read() != reader.Read())  
                    //        {
                    //            this.treeView1.Nodes.Add($"{reader["country"]}");
                    //        }
                    //        this.treeView1.Nodes.Add("");
                    //    }


                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "Select Country , Count(*) as 'counts' from Customers group by country";
                    cmd.Connection = conn;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string s = $"{reader["Country"]} ({reader["counts"]})";
                         TreeNode node = this.treeView1.Nodes.Add(s);
                        string country = reader["country"].ToString();

                        using (SqlConnection conn1 = new SqlConnection(Settings.Default.NorthwindConnectionString))
                        {
                            conn1.Open();
                            SqlCommand cmd2 = new SqlCommand($"Select distinct city from customers where country='{country}' ", conn1);
                            SqlDataReader reader1 = cmd2.ExecuteReader();
                            while (reader1.Read())
                            {
                                node.Nodes.Add(reader1["City"].ToString());
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //點集出現資料
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView cityN = sender as TreeView;  //TreeView 代表每個階層式結合TreeNode
                                                                                  // TreeNode 代表節點的TreeView
            this.customersTableAdapter1.FillBycity(this.nwDataSet1.Customers, cityN.SelectedNode.Text);

            if (this.nwDataSet1.Customers.Rows.Count != 0)  //如果沒有找不到資料
            {

                this.dataGridView1.DataSource = this.nwDataSet1.Customers;
                label1.Text = $"共{this.nwDataSet1.Customers.Rows.Count}個顧客";

            }
        }
    }
}
