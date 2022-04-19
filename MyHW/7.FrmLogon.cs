using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MyHW.Properties;

namespace MyHW
{
    public partial class FrmLogon : Form
    {
        public FrmLogon()
        {
            InitializeComponent();
        }


        //登入 proc
        private void OK_Click(object sender, EventArgs e)
        {

            string userName = UsernameTextBox.Text;
            string passWord = PasswordTextBox.Text;
            try
            {
                
                if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(passWord) )
                {
                    MessageBox.Show("請輸入UserName或密碼");
                }
                else
                {
                    using(SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                    {
                        conn.Open();

                        SqlCommand command = new SqlCommand();
                        command.CommandText = "selectPROC";
                        command.Connection = conn;
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@UserName", SqlDbType.NVarChar, 16).Value = userName;
                        command.Parameters.Add("@Password", SqlDbType.NVarChar, 40).Value = passWord;

                        //傳回值
                        SqlParameter p1 = new SqlParameter();
                        p1.ParameterName = "@Return_Value";
                        p1.Direction = ParameterDirection.ReturnValue;
                        command.Parameters.Add(p1);

                        SqlDataReader reader = command.ExecuteReader();

                        if(reader.HasRows)
                        {
                            MessageBox.Show("登入成功，您的會員ID為：" + p1.Value);
                            FrmMain fm = new FrmMain();
                            //登入視窗藏起
                            this.Hide();
                            //強制回應main 如不強制回應主視窗會跑下一行直接關閉
                            fm.ShowDialog();
                            //結束執行續
                            Application.ExitThread();
                        }
                        else
                        {
                            MessageBox.Show("登入失敗");
                        }


                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //建帳號Params
        private void button1_Click(object sender, EventArgs e)
        {

            //insert
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    string userName = UsernameTextBox.Text;
                    string passWord = PasswordTextBox.Text;

                    if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(passWord))
                    {
                        MessageBox.Show("請輸入UserName或密碼");
                    }
                    else
                    {
                        SqlCommand command = new SqlCommand();
                        command.CommandText = $"Insert into MyMember(UserName, Password) values (@UserName, @Password)";
                        command.Connection = conn;

                        //                                               ↓參數要記得加@ 
                        command.Parameters.Add("@UserName", SqlDbType.NVarChar, 16).Value = userName;
                        command.Parameters.Add("@Password", SqlDbType.NVarChar, 40).Value = passWord;

                        conn.Open();//執行前再OPEN
                        command.ExecuteNonQuery();

                        MessageBox.Show("加入會員成功");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
