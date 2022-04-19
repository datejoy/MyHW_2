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
            EnterDrouptoPicAndFlo();
            loadcombox();
        }

        //picbox,flowlayoutpanel拖放
        void EnterDrouptoPicAndFlo()
        {
            //picbox
            this.pictureBox1.AllowDrop = true;
            this.pictureBox1.DragEnter += PictureBox1_DragEnter;
            this.pictureBox1.DragDrop += PictureBox1_DragDrop;
            //layoutpanel
            this.flowLayoutPanel2.AllowDrop = true;
            this.flowLayoutPanel2.DragEnter += FlowLayoutPanel2_DragEnter;
            this.flowLayoutPanel2.DragDrop += FlowLayoutPanel2_DragDrop;
        }

        //combobox地區
        void loadcombox()
        {
          
            try
            { 
               
                using (SqlConnection conn = new SqlConnection(Settings.Default.forHomeWorkConnectionString))
                {
                    conn.Open();
                 
                    SqlCommand command = new SqlCommand("select CityName from CityTable ", conn);

                    SqlDataReader dataReader = command.ExecuteReader();

                    comboBox1.Items.Clear();
                    while (dataReader.Read())
                    {
                        comboBox1.Items.Add(dataReader["CityName"]);

                    }
                }        //Auto conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //todo
        private void FlowLayoutPanel2_DragDrop(object sender, DragEventArgs e)
        {
            //拖圖到flow放掉
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            for(int i=0; i<files.Length;i++)
            {
                PictureBox picb = new PictureBox(); //動態生成pictureBox
                picb.Image = Image.FromFile(files[i]);
                picb.SizeMode = PictureBoxSizeMode.Zoom;
                picb.Width = 150;
                picb.Height = 150;

                this.flowLayoutPanel2.Controls.Add(picb);
                picb.Click += Picb_Click;

                //然後儲存  todo...
                //try
                //{
                //    using (SqlConnection conn = new SqlConnection(Settings.Default.forHomeWorkConnectionString))
                //    {
                //        SqlCommand command = new SqlCommand();
                //        command.CommandText = $"Insert into CityPic(CityName, CityPhoto) values (@CityName@citypho) ";
                //        command.Connection = conn;

                //        byte[] bytes;

                //        //將圖片轉為二進位
                //        System.IO.MemoryStream ms = new System.IO.MemoryStream();

                //        bytes = ms.GetBuffer();

                //        command.Parameters.Add("@CityName", SqlDbType.NVarChar).Value = comboBox1.Text;
                //        command.Parameters.Add("@citypho", SqlDbType.Image).Value = bytes;
                        


                //        conn.Open();
                //        command.ExecuteNonQuery();

                //        MessageBox.Show("加入圖片成功");

                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }

        }

        private void Picb_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.BackgroundImage = ((PictureBox)sender).Image;
            f.BackgroundImageLayout = ImageLayout.Zoom;
            f.Show();
        }

        private void FlowLayoutPanel2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void PictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            this.pictureBox1.Image = Image.FromFile(files[0]);
        }

        private void PictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }



        //動態生成 顯示城市linklabel
        void BronCity()
        {
            //離線
            this.cityTableTableAdapter1.Fill(this.myHWDataSet11.CityTable);

            for (int i = 0; i < this.myHWDataSet11.CityTable.Rows.Count; i++) //城市數
            {
                LinkLabel cityN = new LinkLabel();
                cityN.Text = this.myHWDataSet11.CityTable[i].CityName;
                cityN.Left = 20;
                cityN.Top = 30 * i;
                cityN.Tag = i;

                cityN.Click += CityN_Click;
                this.splitContainer1.Panel1.Controls.Add(cityN);
            }

            //////連線 
            //try
            //{
            //    using (SqlConnection conn = new SqlConnection(Settings.Default.MyDatabase1ConnectionString))
            //    {
            //        conn.Open();
            //        SqlCommand command = new SqlCommand("select CityName from CityTable", conn);
            //        SqlDataReader dr = command.ExecuteReader();


            //        int j = 0;  //
            //        while (dr.Read())
            //        {
            //            string s = $"{dr["CityName"]}";
            //            LinkLabel linl = new LinkLabel();
            //            linl.Text = s;
            //            linl.Left = 5;
            //            linl.Top = 30 + 30 * j;             //30 * this.myDataSet11.CityTable.Rows.Count;←此數為固定，故會重疊
            //            linl.Click += CityN_Click;
            //            linl.Tag = j;
            //            this.splitContainer1.Panel1.Controls.Add(linl);
            //            j++;
            //        }
            //    }
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }

        //linklabel Click  點擊城市出現Pic
        private void CityN_Click(object sender, EventArgs e)
        {
            LinkLabel link = sender as LinkLabel;
            try
            {

                using(SqlConnection conn = new SqlConnection(Settings.Default.forHomeWorkConnectionString))
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand();
                    comm.CommandText = "";
                    comm.Connection = conn;

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //TOOL
        private void cityTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myHWDataSet11);

        }

        //Browse...
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "(*.jpg) | *.jpg | (*.bmp) | *.bmp | All files (*.*)|*.*";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
        }

        //Save
        private void button2_Click_1(object sender, EventArgs e)
        {
            //try
            //{
            //    using (SqlConnection conn = new SqlConnection(Settings.Default.forHomeWorkConnectionString))
            //    {
            //        SqlCommand command = new SqlCommand();
            //        command.CommandText = "Insert into CityPic(CityPhoto) values (@citypho) ";
            //        command.Connection = conn;

            //        byte[] bytes;

            //        //將圖片轉為二進位
            //        System.IO.MemoryStream ms = new System.IO.MemoryStream();

            //        bytes = ms.GetBuffer();

            //        command.Parameters.Add("@citypho", SqlDbType.Image).Value = bytes;



            //        conn.Open();
            //        command.ExecuteNonQuery();

            //        MessageBox.Show("加入圖片成功");

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
