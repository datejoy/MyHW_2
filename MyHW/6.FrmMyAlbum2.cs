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
    public partial class FrmMyAlbum2 : Form
    {
        public FrmMyAlbum2()
        {
            InitializeComponent();
            BornCity();
            phobindNavi();
            DroptoPicAndFlo2();
        }


        //load linklabel combobox
        void BornCity()
        {
            this.cityTableAdapter1.Fill(this.myAlbumDataSet11.City);
            for(int i=0; i<this.myAlbumDataSet11.City.Rows.Count; i++)
            {
                //離線
                LinkLabel cityN = new LinkLabel();
                                                                                //[i] : city的第i個row
                cityN.Text = this.myAlbumDataSet11.City[i].CityName;
                cityN.Left = 25;
                cityN.Top = 30*i;
                //cityN.Font.Size = 12pt;唯獨不可設定直
                cityN.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                this.splitContainer2.Panel1.Controls.Add(cityN);
                comboBox1.Items.Add(cityN.Text);
                cityN.Click += CityN_Click;
            }

            #region 連線
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
            #endregion 連線
        }

        void DroptoPicAndFlo2()
        {
            this.cityPhotoPictureBox.AllowDrop = true;
            this.cityPhotoPictureBox.DragEnter += CityPhotoPictureBox_DragEnter;
            this.cityPhotoPictureBox.DragDrop += CityPhotoPictureBox_DragDrop;

            this.flowLayoutPanel2.AllowDrop = true;
            this.flowLayoutPanel2.DragEnter += FlowLayoutPanel2_DragEnter;
            this.flowLayoutPanel2.DragDrop += FlowLayoutPanel2_DragDrop;
        }

        private void FlowLayoutPanel2_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            for(int i=0;i<files.Length;i++)
            {
                PictureBox pic = new PictureBox();
                pic.Image = Image.FromFile(files[i]);
                picBoxProperty(pic);
                Image image = Image.FromFile(files[i]);

                this.flowLayoutPanel2.Controls.Add(pic);
                SaveNewPic();
            }
        }


        void SaveNewPic()
        {

            try
            {
                using(SqlConnection conn = new SqlConnection(Settings.Default.MyDatabase1ConnectionString))
                {
                    SqlCommand comm = new SqlCommand();
                    comm.CommandText = "Insert into Photo(CityName, CityPhoto) values (@CityName, @CityPhoto) ";
                    comm.Connection = conn;

                    byte[] bytes;
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                 //   image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    bytes = ms.GetBuffer();

                    comm.Parameters.Add("@CityName", SqlDbType.NVarChar).Value = comboBox1.Text;
                    comm.Parameters.Add("@CityPhoto", SqlDbType.Image).Value = bytes;

                    conn.Open();
                    comm.ExecuteNonQuery();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void FlowLayoutPanel2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void CityPhotoPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            this.cityPhotoPictureBox.Image = Image.FromFile(files[0]);
        }

        private void CityPhotoPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }



        //點集link出現圖片
        private void CityN_Click(object sender, EventArgs e)
        {
            LinkLabel link = sender as LinkLabel;
            this.flowLayoutPanel1.Controls.Clear();
            try
            {
                using(SqlConnection conn = new SqlConnection(Settings.Default.MyDatabase1ConnectionString))
                {
                    SqlCommand comm = new SqlCommand($"Select * from Photo where CityName='{link.Text}'", conn);
                    conn.Open();
                    SqlDataReader reader = comm.ExecuteReader();
                    
                    if(reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            PictureBox pic = new PictureBox();

                            picBoxProperty(pic);
                            pic.Tag = reader["PhotoID"];

                            //二進位轉Image
                            byte[] bytes = (byte[])reader["CityPhoto"];
                            System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                            pic.Image = Image.FromStream(ms);
                            this.flowLayoutPanel1.Controls.Add(pic);

                            pic.Click += Pic_Click;


                        }
                    }
                    else
                    {
                        MessageBox.Show("沒有照片");
                    }
                   

                }
            }
         catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Pic_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Transparent;
        }

        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.DeepSkyBlue;
        }

        //點圖片新增form
        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            Form f = new Form();
            f.BackgroundImage = (sender as PictureBox).Image;
            f.BackgroundImageLayout = ImageLayout.Zoom;
            
            Label descrip = new Label();
            descrip.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
            descrip.ForeColor = Color.Black;
            descrip.Dock = DockStyle.Bottom;

            try
            {
                using(SqlConnection conn = new SqlConnection(Settings.Default.MyDatabase1ConnectionString))
                {
                    SqlCommand comm = new SqlCommand($"select Description from Photo where PhotoID={pic.Tag}", conn);
                    conn.Open();
                    SqlDataReader reader = comm.ExecuteReader();
                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            //在form新增描述
                            descrip.Text = reader["Description"].ToString();
                            f.Text = descrip.Text;
                        }
                    }
                    
                    f.Controls.Add(descrip);
                    f.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myAlbumDataSet11);

        }

        //ToolofNaviBind
        void phobindNavi()
        {
            this.cityPhotoPictureBox.AllowDrop = true;
            this.photoTableAdapter1.Fill(this.myAlbumDataSet11.Photo);
            this.photoBindingSource.DataSource = this.myAlbumDataSet11.Photo;
            this.photobindingNavigator1.BindingSource = this.photoBindingSource;
            this.photoDataGridView.DataSource = this.photoBindingSource;
           
        }

        //Browse選相片 TabpageTool
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "(*.JPG) | *.JPG | (*.PNG) | *.PNG | All files (*.*)|*.*";
            if(this.openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                this.cityPhotoPictureBox.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
        }


        //phoNavisave
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.photoTableAdapter1.Update(this.myAlbumDataSet11);
        }

        void picBoxProperty(PictureBox picture)
        {
            picture.Height = 200;
            picture.Width = 200;
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.BorderStyle = BorderStyle.FixedSingle;
            picture.MouseMove += Pic_MouseMove;
            picture.MouseLeave += Pic_MouseLeave;
        }

        //相片管理選地點出現現有相片
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.flowLayoutPanel2.Controls.Clear();
            try
            {
                using(SqlConnection conn = new SqlConnection(Settings.Default.MyDatabase1ConnectionString))
                {
                    SqlCommand comm = new SqlCommand($"select CityPhoto from Photo where CityName = '{comboBox1.Text}'", conn);
                    conn.Open();
                    SqlDataReader reader = comm.ExecuteReader();
                    if(reader.HasRows)
                    {
                        
                        while(reader.Read())
                        {
                            PictureBox pb = new PictureBox();
                            picBoxProperty(pb);


                            byte[] bytes = (byte[])reader["CityPhoto"];
                            System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                            pb.Image = Image.FromStream(ms);
                            this.flowLayoutPanel2.Controls.Add(pb);
                        }
                    }

                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }


    #region 失敗卡住
    ///* System.ComponentModel.*/
    //ComponentResourceManager resources = new /*System.ComponentModel.*/ComponentResourceManager(typeof(FrmMyAlbum2));
    //void toolstripSetting(ToolStrip ts)
    //{
    //    // ts.Visible = true;
    //    ts.Dock = DockStyle.Bottom;
    //    ToolStripButton stripbtn1 = new ToolStripButton();
    //    stripbtn1.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
    //    stripbtn1.Text = "上一張";
    //    stripbtn1.Image = ((/*System.Drawing.*/Image)(resources.GetObject("stripbtn1.Image")));
    //    stripbtn1.Visible = true;
    //    ts.Items.Add(stripbtn1);
    //    stripbtn1.Click += Stripbtn1_Click;

    //    ToolStripButton stripbtn2 = new ToolStripButton();
    //    stripbtn2.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
    //    stripbtn2.Text = "下一張";
    //    stripbtn2.Image = ((/*System.Drawing.*/Image)(resources.GetObject("stripbtn2.Image")));
    //    stripbtn2.Visible = true;
    //    ts.Items.Add(stripbtn2);
    //    stripbtn2.Click += Stripbtn2_Click;


    //}

    ////下一張
    //private void Stripbtn2_Click(object sender, EventArgs e)
    //{

    //}


    ////上一張
    //private void Stripbtn1_Click(object sender, EventArgs e)
    //{

    //}
    #endregion 失敗卡住
}

