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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnNW_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            FrmCategoryProducts cp = new FrmCategoryProducts();
            cp.MdiParent = this;
            cp.Parent = this.splitContainer2.Panel2;
            cp.Show();
        }

        private void btnAD2019_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            FrmAdventureWorks aw = new FrmAdventureWorks();
            aw.MdiParent = this;
            aw.Parent = this.splitContainer2.Panel2;
            aw.Show();
        }

        private void btnDSet_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            FrmDataSet結構 ds = new FrmDataSet結構();
            ds.MdiParent = this;
            ds.Parent = this.splitContainer2.Panel2;
            ds.Show();
        }

        private void btnLV_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            FrmCustomers cus = new FrmCustomers();
            cus.MdiParent = this;
            cus.Parent = this.splitContainer2.Panel2;
            cus.Show();
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            FrmMyAlbum2 album2 = new FrmMyAlbum2();
            album2.MdiParent = this;
            album2.Parent = this.splitContainer2.Panel2;
            album2.Show();
        }

        private void btnPractice_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            Form1 f1 = new Form1();
            f1.MdiParent = this;
            f1.Parent = this.splitContainer2.Panel2;
            f1.Show();
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            FrmTreeView tv = new FrmTreeView();
            tv.MdiParent = this;
            tv.Parent = this.splitContainer2.Panel2;
            tv.Show();
        }
    }
}
