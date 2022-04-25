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
            DroptoPicAndFlo2();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myAlbumDataSet1);

        }

        private void FrmMyAlbum2_Load(object sender, EventArgs e)
        {
            this.photoTableAdapter.Fill(this.myAlbumDataSet1.Photo);
            this.cityTableAdapter.Fill(this.myAlbumDataSet1.City);
        }

        //load linklabel combobox
        void BornCity()
        {
            this.cityTableAdapter.Fill(this.myAlbumDataSet1.City);
            for (int i = 0; i < this.myAlbumDataSet1.City.Rows.Count; i++)
            {
                //離線
                LinkLabel cityN = new LinkLabel();
                //[i] : city的第i個row
                cityN.Text = this.myAlbumDataSet1.City[i].CityName;
                cityN.Left = 40;
                cityN.Top = 40 * i;
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

        //點link出現圖片
        private void CityN_Click(object sender, EventArgs e)
        {
            LinkLabel link = sender as LinkLabel;
            this.flowLayoutPanel1.Controls.Clear();
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyalbumDatabaseConnection))
                {
                    SqlCommand comm = new SqlCommand($"Select * from Photo where CityName='{link.Text}'", conn);
                    conn.Open();
                    SqlDataReader reader = comm.ExecuteReader();

                    if (reader.HasRows)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

            FrmPic f = new FrmPic();
            //f.layoutIndex = this.flowLayoutPanel1.Controls.GetChildIndex(pic);
            f.layoutIndex = flowLayoutPanel1.Controls.IndexOf(pic);
            this.photoTableAdapter.FillByPID(this.myAlbumDataSet1.Photo, (int)pic.Tag);
            if (this.myAlbumDataSet1.Photo.Rows.Count != 0)
            {
                f.Text = this.myAlbumDataSet1.Photo[0]["Description"].ToString();
            }
            f.ShowDialog();  //為了避免一直點圖片一直出現新視窗
        }

        //拖放
        void DroptoPicAndFlo2()
        {
            this.cityPhotoPictureBox.AllowDrop = true;
            this.cityPhotoPictureBox.DragEnter += CityPhotoPictureBox_DragEnter;
            this.cityPhotoPictureBox.DragDrop += CityPhotoPictureBox_DragDrop;

            this.flowLayoutPanel2.AllowDrop = true;
            this.flowLayoutPanel2.DragEnter += FlowLayoutPanel2_DragEnter;
            this.flowLayoutPanel2.DragDrop += FlowLayoutPanel2_DragDrop;
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

        private void FlowLayoutPanel2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void FlowLayoutPanel2_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            for (int i = 0; i < files.Length; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Image = Image.FromFile(files[i]);
                picBoxProperty(pic);
                Image image = Image.FromFile(files[i]);

                this.flowLayoutPanel2.Controls.Add(pic);
                SaveNewPic(image);
            }
        }

        private void SaveNewPic(Image image)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyalbumDatabaseConnection))
                {
                    SqlCommand comm = new SqlCommand();
                    comm.CommandText = "Insert into Photo(CityName, CityPhoto) values (@CityName, @CityPhoto) ";
                    comm.Connection = conn;

                    byte[] bytes;
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();

                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "(*.JPG) | *.JPG | (*.PNG) | *.PNG | All files (*.*)|*.*";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.cityPhotoPictureBox.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.photoTableAdapter.Update(this.myAlbumDataSet1);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.photoTableAdapter.Fill(this.myAlbumDataSet1.Photo);
        }
    }
}
