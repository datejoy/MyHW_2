
namespace MyHW
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn10 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btncCear = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.labSho = new System.Windows.Forms.Label();
            this.labRes = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.labnum = new System.Windows.Forms.Label();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btndo = new System.Windows.Forms.Button();
            this.btnwhi = new System.Windows.Forms.Button();
            this.btnfor = new System.Windows.Forms.Button();
            this.labSte = new System.Windows.Forms.Label();
            this.labTo = new System.Windows.Forms.Label();
            this.labFrom = new System.Windows.Forms.Label();
            this.txtBox4 = new System.Windows.Forms.TextBox();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn14 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn10
            // 
            this.btn10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn10.Location = new System.Drawing.Point(793, 68);
            this.btn10.Margin = new System.Windows.Forms.Padding(4);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(289, 55);
            this.btn10.TabIndex = 34;
            this.btn10.Text = "SUM";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn9.Location = new System.Drawing.Point(526, 199);
            this.btn9.Margin = new System.Windows.Forms.Padding(4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(259, 55);
            this.btn9.TabIndex = 33;
            this.btn9.Text = "SWAP換位";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn8.Location = new System.Drawing.Point(526, 136);
            this.btn8.Margin = new System.Windows.Forms.Padding(4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(259, 55);
            this.btn8.TabIndex = 32;
            this.btn8.Text = "二維陣列01交替";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn7.Location = new System.Drawing.Point(526, 68);
            this.btn7.Margin = new System.Windows.Forms.Padding(4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(259, 55);
            this.btn7.TabIndex = 31;
            this.btn7.Text = "二維陣列0包圍1";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn6.Location = new System.Drawing.Point(259, 199);
            this.btn6.Margin = new System.Windows.Forms.Padding(4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(259, 55);
            this.btn6.TabIndex = 30;
            this.btn6.Text = "二維陣列1包圍0";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btncCear
            // 
            this.btncCear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btncCear.Location = new System.Drawing.Point(40, 342);
            this.btncCear.Margin = new System.Windows.Forms.Padding(4);
            this.btncCear.Name = "btncCear";
            this.btncCear.Size = new System.Drawing.Size(123, 46);
            this.btncCear.TabIndex = 29;
            this.btncCear.Text = "清空結果";
            this.btncCear.UseVisualStyleBackColor = true;
            this.btncCear.Click += new System.EventHandler(this.btncCear_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn5.Location = new System.Drawing.Point(259, 136);
            this.btn5.Margin = new System.Windows.Forms.Padding(4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(259, 55);
            this.btn5.TabIndex = 28;
            this.btn5.Text = "陣列中包含J或j有幾個";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click_1);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn4.Location = new System.Drawing.Point(259, 68);
            this.btn4.Margin = new System.Windows.Forms.Padding(4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(259, 55);
            this.btn4.TabIndex = 27;
            this.btn4.Text = "陣列最長名字";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn3.Location = new System.Drawing.Point(13, 199);
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(238, 55);
            this.btn3.TabIndex = 26;
            this.btn3.Text = "陣列統計奇數偶數";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn2.Location = new System.Drawing.Point(13, 136);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(238, 55);
            this.btn2.TabIndex = 25;
            this.btn2.Text = "陣列最大/最小值";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // labSho
            // 
            this.labSho.AutoEllipsis = true;
            this.labSho.AutoSize = true;
            this.labSho.BackColor = System.Drawing.Color.MediumAquamarine;
            this.labSho.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSho.ForeColor = System.Drawing.Color.Navy;
            this.labSho.Location = new System.Drawing.Point(49, 468);
            this.labSho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSho.Name = "labSho";
            this.labSho.Size = new System.Drawing.Size(85, 30);
            this.labSho.TabIndex = 24;
            this.labSho.Text = "結果：";
            // 
            // labRes
            // 
            this.labRes.AutoSize = true;
            this.labRes.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRes.Location = new System.Drawing.Point(32, 404);
            this.labRes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labRes.Name = "labRes";
            this.labRes.Size = new System.Drawing.Size(159, 45);
            this.labRes.TabIndex = 23;
            this.labRes.Text = "Result：";
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn1.Location = new System.Drawing.Point(13, 68);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(238, 55);
            this.btn1.TabIndex = 22;
            this.btn1.Text = "判斷奇數偶數";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox1.Location = new System.Drawing.Point(142, 13);
            this.txtBox1.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(136, 39);
            this.txtBox1.TabIndex = 21;
            // 
            // labnum
            // 
            this.labnum.AutoSize = true;
            this.labnum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labnum.Location = new System.Drawing.Point(3, 13);
            this.labnum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labnum.Name = "labnum";
            this.labnum.Size = new System.Drawing.Size(131, 30);
            this.labnum.TabIndex = 20;
            this.labnum.Text = "Number：";
            // 
            // btn12
            // 
            this.btn12.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn12.Location = new System.Drawing.Point(792, 199);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(290, 55);
            this.btn12.TabIndex = 106;
            this.btn12.Text = "int[] 樂透 6個號碼不重複";
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.btn12_Click);
            // 
            // btn11
            // 
            this.btn11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn11.Location = new System.Drawing.Point(793, 136);
            this.btn11.Margin = new System.Windows.Forms.Padding(4);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(289, 55);
            this.btn11.TabIndex = 105;
            this.btn11.Text = "Max (params int[] )";
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.btn11_Click);
            // 
            // btndo
            // 
            this.btndo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btndo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btndo.Location = new System.Drawing.Point(411, 387);
            this.btndo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndo.Name = "btndo";
            this.btndo.Size = new System.Drawing.Size(58, 44);
            this.btndo.TabIndex = 115;
            this.btndo.Text = "do";
            this.btndo.UseVisualStyleBackColor = false;
            this.btndo.Click += new System.EventHandler(this.btndo_Click);
            // 
            // btnwhi
            // 
            this.btnwhi.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnwhi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnwhi.Location = new System.Drawing.Point(411, 334);
            this.btnwhi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnwhi.Name = "btnwhi";
            this.btnwhi.Size = new System.Drawing.Size(84, 40);
            this.btnwhi.TabIndex = 114;
            this.btnwhi.Text = "while";
            this.btnwhi.UseVisualStyleBackColor = false;
            this.btnwhi.Click += new System.EventHandler(this.btnwhi_Click);
            // 
            // btnfor
            // 
            this.btnfor.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnfor.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnfor.Location = new System.Drawing.Point(411, 282);
            this.btnfor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(58, 44);
            this.btnfor.TabIndex = 113;
            this.btnfor.Text = "for";
            this.btnfor.UseVisualStyleBackColor = false;
            this.btnfor.Click += new System.EventHandler(this.btnfor_Click);
            // 
            // labSte
            // 
            this.labSte.AutoSize = true;
            this.labSte.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labSte.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSte.Location = new System.Drawing.Point(266, 393);
            this.labSte.Name = "labSte";
            this.labSte.Size = new System.Drawing.Size(71, 30);
            this.labSte.TabIndex = 112;
            this.labSte.Text = "Step:";
            // 
            // labTo
            // 
            this.labTo.AutoSize = true;
            this.labTo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labTo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTo.Location = new System.Drawing.Point(294, 338);
            this.labTo.Name = "labTo";
            this.labTo.Size = new System.Drawing.Size(43, 30);
            this.labTo.TabIndex = 111;
            this.labTo.Text = "to:";
            // 
            // labFrom
            // 
            this.labFrom.AutoSize = true;
            this.labFrom.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labFrom.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labFrom.Location = new System.Drawing.Point(264, 289);
            this.labFrom.Name = "labFrom";
            this.labFrom.Size = new System.Drawing.Size(73, 30);
            this.labFrom.TabIndex = 110;
            this.labFrom.Text = "from:";
            // 
            // txtBox4
            // 
            this.txtBox4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtBox4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox4.Location = new System.Drawing.Point(343, 387);
            this.txtBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox4.Name = "txtBox4";
            this.txtBox4.Size = new System.Drawing.Size(62, 39);
            this.txtBox4.TabIndex = 109;
            // 
            // txtBox3
            // 
            this.txtBox3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtBox3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox3.Location = new System.Drawing.Point(343, 334);
            this.txtBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.Size = new System.Drawing.Size(62, 39);
            this.txtBox3.TabIndex = 108;
            // 
            // txtBox2
            // 
            this.txtBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox2.Location = new System.Drawing.Point(343, 282);
            this.txtBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(62, 39);
            this.txtBox2.TabIndex = 107;
            // 
            // btn13
            // 
            this.btn13.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn13.Location = new System.Drawing.Point(526, 272);
            this.btn13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(259, 54);
            this.btn13.TabIndex = 116;
            this.btn13.Text = "3 個數的最大值";
            this.btn13.UseVisualStyleBackColor = true;
            this.btn13.Click += new System.EventHandler(this.btn13_Click);
            // 
            // btn15
            // 
            this.btn15.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn15.Location = new System.Drawing.Point(803, 272);
            this.btn15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(279, 54);
            this.btn15.TabIndex = 118;
            this.btn15.Text = "100 的 二進位是多少 ?";
            this.btn15.UseVisualStyleBackColor = true;
            this.btn15.Click += new System.EventHandler(this.btn15_Click);
            // 
            // btn14
            // 
            this.btn14.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn14.Location = new System.Drawing.Point(526, 348);
            this.btn14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(259, 54);
            this.btn14.TabIndex = 117;
            this.btn14.Text = "九九乘法表";
            this.btn14.UseVisualStyleBackColor = true;
            this.btn14.Click += new System.EventHandler(this.btn14_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1173, 1009);
            this.Controls.Add(this.btn15);
            this.Controls.Add(this.btn14);
            this.Controls.Add(this.btn13);
            this.Controls.Add(this.btndo);
            this.Controls.Add(this.btnwhi);
            this.Controls.Add(this.btnfor);
            this.Controls.Add(this.labSte);
            this.Controls.Add(this.labTo);
            this.Controls.Add(this.labFrom);
            this.Controls.Add(this.txtBox4);
            this.Controls.Add(this.txtBox3);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btncCear);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.labSho);
            this.Controls.Add(this.labRes);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.labnum);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btncCear;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label labSho;
        private System.Windows.Forms.Label labRes;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Label labnum;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btndo;
        private System.Windows.Forms.Button btnwhi;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Label labSte;
        private System.Windows.Forms.Label labTo;
        private System.Windows.Forms.Label labFrom;
        private System.Windows.Forms.TextBox txtBox4;
        private System.Windows.Forms.TextBox txtBox3;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn14;
    }
}

