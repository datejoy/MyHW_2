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
            this.cityTableTableAdapter1.Fill(this.myDataSet11.CityTable);

            for (int i = 0; i < this.myDataSet11.CityTable.Rows.Count; i++) //城市數
            {
                LinkLabel cityN = new LinkLabel();
                cityN.Text = this.myDataSet11.CityTable[i].CityName;
                cityN.Left = 5;
                cityN.Top = 30 * i;
                cityN.Tag = i;

                cityN.Click += CityN_Click;
                this.splitContainer1.Panel1.Controls.Add(cityN);
            }
        }

        private void CityN_Click(object sender, EventArgs e)
        {
            this.cityPicTableTableAdapter1.Fill(this.myDataSet11.CityPicTable);

        }
    }
}
