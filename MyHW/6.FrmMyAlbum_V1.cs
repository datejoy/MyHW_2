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
    public partial class FrmMyAlbum_V1 : Form
    {
        public FrmMyAlbum_V1()
        {
            InitializeComponent();
            BronCity();
        }




        //動態生成 顯示城市linklabel
        void BronCity()
        {
            //離線
            //this.cityTableTableAdapter1.Fill(this.myDataSet11.CityTable);

            //for (int i = 0; i < this.myDataSet11.CityTable.Rows.Count; i++) //城市數
            //{
            //    LinkLabel cityN = new LinkLabel();
            //    cityN.Text = this.myDataSet11.CityTable[i].CityName;
            //    cityN.Left = 5;
            //    cityN.Top = 30 * i;
            //    cityN.Tag = i;

            //    cityN.Click += CityN_Click;
            //    this.splitContainer1.Panel1.Controls.Add(cityN);
            //}

            //連線 失敗
            SqlConnection conn = new SqlConnection(Settings.Default.MyDatabase1ConnectionString);
            conn.Open();
            SqlCommand command = new SqlCommand("select CityName from CityTable",conn);
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                string s = $"{dr["CityName"]}";
                LinkLabel linl = new LinkLabel();
                linl.Text = s;
                linl.Left = 5;
                linl.Top = 30*this.myDataSet11.CityTable.Rows.Count ;
                linl.Click += CityN_Click;
                this.splitContainer1.Panel1.Controls.Add(linl);
            }
            conn.Close();
        }

        private void CityN_Click(object sender, EventArgs e)
        {
            this.cityPicTableTableAdapter1.Fill(this.myDataSet11.CityPicTable);

        }
    }
}
