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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {   //奇偶數
            string showr="";
            int num1;
            bool a = int.TryParse(txtBox1.Text,out num1 );
            if( a )
            {
                if ( num1%2==0 )
                {
                    showr = "偶數";
                }
                else
                {
                    showr = "奇數";
                }
            }
            else
            {
                MessageBox.Show("請輸入正確數字格式");
            }
            labSho.Text = "結果：\n"+showr;
        }

        int[] scores = { 2, 3, 46, 33, 22, 100, 150, 33, 55 };

        private void btn2_Click(object sender, EventArgs e)
        {   //陣列Max/Min
            int i;
            string sarr="";
            for ( i = 0 ; i<scores.Length ; i++ )
            {
                sarr += scores[i]+" ";
            }
            labSho.Text = "結果：\n陣列{" +
                sarr + "} 最大值為：" + scores.Max() + "，最小值為：" + scores.Min();
        }

        private void btn3_Click(object sender, EventArgs e)
        {//陣列機偶數
            int i;
            string sarr="";
            int count1 =0;
            int count2 = 0;
            for ( i = 0; i< scores.Length; i++ )
            {
                sarr += scores[i]+" " ;
                if( scores[i]%2==0 )
                {
                    count2++;
                }
                else
                {
                    count1++;
                }
            }
            labSho.Text = "結果：\n陣列{" +
               sarr + "} 奇數有：" + count1 + "個，偶數有：" + count2 + "個";

        }
        
        string[] kr = { "John Wick", "基努李維", "Jonny Silverhand", "Neo", "2077", "jail", "Lucifer" };
        private void btn4_Click(object sender, EventArgs e)
        {//陣列最常名字
            string i = kr[0];
            string sarr = "";
            // string longest = "";
            foreach ( string item in kr )
            {
                sarr += item + " , ";
                i = i.Length > item.Length ? i : item;
            }
            labSho.Text = "結果；\n陣列{"+sarr+"} 中，最長名字為："+ i ;
        }

        private void btn5_Click_1(object sender, EventArgs e)
        {//包含某字
            string sarr = "";
            int count = 0;
            foreach (string item in kr)
            {
                sarr += item + " , ";
                if (item.Contains('J') || item.Contains('j'))
                {
                    count++;
                }
            }
            labSho.Text = "結果；\n陣列{" + sarr + "} 中，包含J或j的有" + count + "個";
        }

        private void btn6_Click(object sender, EventArgs e)
        {//1包圍0
            int[,] zerone = new int[10,10];
            int ro ;
            int cl ;
            labSho.Text = "結果：\n";                                          //每次按的時候不重疊
            for (  ro = 0; ro<zerone.GetLength(0); ro++ )    //第一維度
            {
                for ( cl=0; cl< zerone.GetLength(1); cl++ )   //第二維度
                {
                    if( ro==0 || cl==0 )
                    {
                        zerone[ro, cl] = 1;
                    }
                    else if ( ro==9 || cl ==9 )
                    {
                        zerone[ro, cl] = 1;
                    }
                    else
                    {
                        zerone[ro, cl] = 0;
                    }
                    labSho.Text += zerone[ro, cl] + " ";
                }
                labSho.Text += "\n";
            }

        }

        private void btn7_Click(object sender, EventArgs e)
        {//0包圍1
            int[,] zerone = new int[10, 10];
            int ro;
            int cl;
            labSho.Text = "結果：\n";                                         
            for (ro = 0; ro < zerone.GetLength(0); ro++)    //第一維度
            {
                for (cl = 0; cl < zerone.GetLength(1); cl++)   //第二維度
                {
                    if (ro == 0 || cl == 0)
                    {
                        zerone[ro, cl] = 0;
                    }
                    else if (ro == 9 || cl == 9)
                    {
                        zerone[ro, cl] = 0;
                    }
                    else
                    {
                        zerone[ro, cl] = 1;
                    }
                    labSho.Text += zerone[ro, cl] + " ";
                }
                labSho.Text += "\n";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            int[,] zerone = new int[10, 10];
             int ro;
             int cl;
            bool change = true;
            labSho.Text = "結果：\n";
            for ( ro = 0; ro<zerone.GetLength(0); ro ++ )
            {
                for ( cl = 0; cl<zerone.GetLength(1); cl++ )
                {
                    labSho.Text += change ? 1 : 0;
                    change = !change;
                }
                labSho.Text += "\n";
                change = !change;
            }


        }

        private void btn9_Click(object sender, EventArgs e)
        {//換位
            int swaP1 = 100;
            int swaP2 = 200;
            labSho.Text = "換位前swaP1=" + swaP1 + "   swaP2=" + swaP2;
            SWAP(ref swaP1, ref swaP2);
            labSho.Text += "\n換位後swaP1=" + swaP1 + "   sw2aP=" + swaP2;
        }

        void SWAP( ref int swaPa , ref int swaPb )
        {
            int C = swaPa;
            swaPa = swaPb;
            swaPb = C;
        }

        private void btn10_Click(object sender, EventArgs e)
        {//加總
           // int i;
            int total = 0;
            string sarr = "";
            foreach ( int item in scores )
            {
                sarr += item + "  ";
                total += item;
            }
            labSho.Text = "結果：\n陣列{" +
                sarr + "} 總和為："+total ;
        }

       // int[] scores = { 2, 3, 46, 33, 22, 100, 150, 33, 55 };
        private void btn11_Click(object sender, EventArgs e)
        {//params 最大
            string sarr2="";
            int arrscore = aParams(ref sarr2 ,2, 3, 46, 33, 22, 100, 150, 33, 55);
            labSho.Text = "陣列{"+sarr2+"}中，最大值為："+ arrscore;
        }

        int aParams ( ref string sarr , params int[] score1 )
        {
            int maxitem = score1[0];
            foreach ( int item in score1 )
            {
                 sarr += item + "  ";
                maxitem = maxitem < item ? item : maxitem;
            }
            return maxitem ;
        }

        private void btn12_Click(object sender, EventArgs e)
        {//樂透不重複
            Random r = new Random();
            int[] lottery = new int[6];              
            string arr = "";

            for (int i = 0; i < lottery.Length; i++)
            {
                lottery[i] = r.Next(1, 50);

                for ( int j = 0; j< i ;j++ )
                {
                    while ( lottery[i]==lottery[j] )
                    {
                        lottery[i] = r.Next(1, 50);
                        j = 0;
                    }
                }
                arr += lottery[i] + "  ";
            }
            labSho.Text = "結果：\n" + arr;


        }

        private void btn13_Click(object sender, EventArgs e)
        {//最大值
            int a = 100;
            int b = 66;
            int c = 77;
            Maxfor3(ref a,ref b,ref c); 
        }

        string Maxfor3( ref int a1, ref int b1, ref int c1 )
        {
            int max = 0;
            if ( a1 > b1 && a1>c1 )
            {
                max = a1;
            }
            else if ( b1>a1 && b1>c1 )
            {
                max = b1;
            }
            else if (c1>a1 && c1>b1 )
            {
                max = c1;
            }
            return labSho.Text= "結果：\n"+ max ; 
        }

        private void btn15_Click(object sender, EventArgs e)
        {//2進位100
            int hund = 100;
            string chan = Convert.ToString(hund, 2);
            labSho.Text = "結果：\n" + chan;

        }

        private void btn14_Click(object sender, EventArgs e)
        {//99
            int z = 0;
            //string w = "";
            //string v = "";
            labSho.Text = "結果：\n";
            for( int x =1 ; x<10 ; x++)  //後面
            {
                for( int y =2; y<10 ; y++  )   //前面
                {
                  //  w = Convert.ToString(x*y);
                    z = x*y;
                   
                    labSho.Text += y + " x " + x + "=" + z.ToString("00") + "  |  ";
                }
                labSho.Text += "\n";
            }
           // labSho.Text ="結果：\n"+ v;
        }

        private void btncCear_Click(object sender, EventArgs e)
        {
            labSho.Text = "結果：";
        }

        private void btnfor_Click(object sender, EventArgs e)
        {//for
            int fRom ;
            int tO ;
            int sTep ;
            int total=0;
            bool txtF = int.TryParse(txtBox2.Text, out fRom);
            bool txtT = int.TryParse(txtBox3.Text, out tO);
            bool txtS = int.TryParse(txtBox4.Text, out sTep);
            if ( txtF==false || txtT==false || txtS==false )
            {
                MessageBox.Show("請輸入正確數字格式");
            }
            else
            {
                fRom = int.Parse(txtBox2.Text);
                tO = int.Parse(txtBox3.Text);
                sTep = int.Parse(txtBox4.Text);
                for ( int i= fRom ; i<=tO; i+=sTep )
                {
                    total += i;
                }
                
            }
            labSho.Text = "結果：\n" + fRom + "到" + tO + "相隔" + (sTep - 1) + "\n加總為：" + total;
        }

        private void btnwhi_Click(object sender, EventArgs e)
        {//while
            int fRom;
            int tO;
            int sTep;
            int total = 0;

            bool txtF = int.TryParse(txtBox2.Text, out fRom);
            bool txtT = int.TryParse(txtBox3.Text, out tO);
            bool txtS = int.TryParse(txtBox4.Text, out sTep);
            if( !txtF || !txtT || !txtS )
            {
                MessageBox.Show("請輸入正確數字格式");
            }
            else
            {
                //fRom = int.Parse(txtBox2.Text);
                //tO = int.Parse(txtBox3.Text);
                //sTep = int.Parse(txtBox4.Text);
                while ( fRom <= tO)
                {
                    total += fRom ;
                    fRom += sTep;
                }
               
            }
            labSho.Text = "結果：\n" + txtBox2.Text + "到" + tO + "相隔" + (sTep - 1) + "\n加總為：" + total;
        }

        private void btndo_Click(object sender, EventArgs e)
        {
            int fRom;
            int tO;
            int sTep;
            int total = 0;
            bool txtF = int.TryParse(txtBox2.Text, out fRom);
            bool txtT = int.TryParse(txtBox3.Text, out tO);
            bool txtS = int.TryParse(txtBox4.Text, out sTep);
            if (txtF == false || txtT == false || txtS == false)
            {
                MessageBox.Show("請輸入正確數字格式");
            }
            else
            {
                fRom = int.Parse(txtBox2.Text);
                tO = int.Parse(txtBox3.Text);
                sTep = int.Parse(txtBox4.Text);
                do
                {
                    total += fRom;
                    fRom += sTep;
                } 
                while (fRom <= tO);

            }
            labSho.Text = "結果：\n" + txtBox2.Text + "到" + tO + "相隔" + (sTep - 1) + "\n加總為：" + total;
        }
    }
}
