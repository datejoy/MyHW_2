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
    public partial class FrmPic : Form
    {

        public FrmPic()
        {
            InitializeComponent();
        }
        internal int layoutIndex;
        FrmMyAlbum2 frma2;

        private void FrmPic_Load(object sender, EventArgs e)
        {
            this.frma2 = (FrmMyAlbum2)Application.OpenForms["FrmMyAlbum2"]; //取得控制項Gets a collection of open forms owned by the application.
            this.pictureBox1.Image = ((PictureBox)frma2.flowLayoutPanel1.Controls[layoutIndex]).Image;
           //'FrmMyAlbum2.flowLayoutPanel1' 由於其保護層級之故，所以無法存取 

        }


        private void tsbtnPre_Click(object sender, EventArgs e)
        {
            if(layoutIndex>0)
            {
                layoutIndex = layoutIndex - 1;
                this.pictureBox1.Image = (frma2.flowLayoutPanel1.Controls[layoutIndex] as PictureBox).Image;
            }
        }

        private void tsbtnNext_Click(object sender, EventArgs e)
        {
            if (layoutIndex<frma2.flowLayoutPanel1.Controls.Count-1)
            {
                layoutIndex++;
                this.pictureBox1.Image = ((PictureBox)frma2.flowLayoutPanel1.Controls[layoutIndex]).Image;
            }
        }

        //自動播放
        bool isclick = true;
        private void tsbtnAuto_Click(object sender, EventArgs e)
        {

            if(isclick)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }
            isclick = !isclick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            if(layoutIndex==frma2.flowLayoutPanel1.Controls.Count-1)
            {
                layoutIndex=0;
                this.pictureBox1.Image = ((PictureBox)frma2.flowLayoutPanel1.Controls[layoutIndex]).Image;
            }
            else
            {
                layoutIndex++;
                this.pictureBox1.Image = ((PictureBox)frma2.flowLayoutPanel1.Controls[layoutIndex]).Image;
            }


        }
    }
}
