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

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "Select Country , Count(*) as 'counts' from Customers group by country";
                    cmd.Connection = conn;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string s = $"{reader["Country"]} ({reader["counts"]})";
                        this.treeView1.Nodes.Add(s);

                    }
                    //childnode  ※多個結果集
                    this.treeView1.Nodes[0].Nodes.Add("test");

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

        }


    }
}
