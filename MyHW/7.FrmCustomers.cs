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
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
            LoadCountry();
            PutColumnName();
        }


        //↓combox裡加入國家 北風DB
        void LoadCountry()
        {
            comboBox1.Text = "請選擇國家";


            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand();
                    command.CommandText = "Select distinct Country from Customers";
                    command.Connection = conn;
                    SqlDataReader reader = command.ExecuteReader();

                    this.comboBox1.Items.Clear();
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader[0]);  //reader["Country"]也可
                    }
                    this.comboBox1.Items.Add("All Countries");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        //↓將欄位名colum加入listview裡
        void PutColumnName()
        {
            // ↓非常重要非常重要非常重要
            this.listView1.View = View.Details;
            //↑非常重要忘了改就看不到
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("Select*From Customers", conn);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dtable = reader.GetSchemaTable();

                    this.listView1.Items.Clear();

                    for (int i = 0; i < dtable.Rows.Count; i++)
                    {
                        this.listView1.Columns.Add(dtable.Rows[i]["ColumnName"].ToString());
                    }
                    this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        //↓選取國家找資料
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //選擇all以外的
            if (comboBox1.SelectedItem.ToString() != "All Countries")
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand();
                        command.CommandText = $"Select * from Customers where Country = '{comboBox1.SelectedItem}'";
                        command.Connection = conn;
                        SqlDataReader dr = command.ExecuteReader();

                        this.listView1.Items.Clear();

                        while (dr.Read())
                        {

                            //主item
                            ListViewItem lvi = this.listView1.Items.Add(dr[0].ToString());


                            //子item
                            for (int i = 1; i < dr.FieldCount; i++)
                            {
                                if (dr.IsDBNull(i) == false)
                                {
                                    lvi.SubItems.Add(dr[i].ToString());
                                }
                                else
                                {
                                    lvi.SubItems.Add("空值");
                                }
                            }

                            //變色
                            if (lvi.Index % 2 == 0)
                            {
                                lvi.BackColor = Color.DarkCyan;
                            }
                            else
                            {
                                lvi.BackColor = Color.Transparent;
                            }

                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            //選all countries
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand();
                        command.CommandText = $"Select * from Customers";
                        command.Connection = conn;
                        SqlDataReader dr = command.ExecuteReader();

                        this.listView1.Items.Clear();

                        while (dr.Read())
                        {

                            //主item
                            ListViewItem lvi = this.listView1.Items.Add(dr[0].ToString());


                            //子item
                            for (int i = 1; i < dr.FieldCount; i++)
                            {
                                if (dr.IsDBNull(i) == false)
                                {
                                    lvi.SubItems.Add(dr[i].ToString());
                                }
                                else
                                {
                                    lvi.SubItems.Add("空值");
                                }
                            }

                            //變色
                            if (lvi.Index % 2 == 0)
                            {
                                lvi.BackColor = Color.DarkCyan;
                            }
                            else
                            {
                                lvi.BackColor = Color.Transparent;
                            }

                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }



        }
    }

}
