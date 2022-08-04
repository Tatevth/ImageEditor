
namespace ImageEditor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.height_txt = new System.Windows.Forms.TextBox();
            this.width_txt = new System.Windows.Forms.TextBox();
            this.resizeBtn = new System.Windows.Forms.Button();
            this.effevt3Btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.openimg2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.width2_txt = new System.Windows.Forms.TextBox();
            this.height2_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPath2 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.width3_txt = new System.Windows.Forms.TextBox();
            this.height3_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPath3 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.openimg3 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog3 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox.Location = new System.Drawing.Point(12, 29);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(247, 187);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(264, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Effect 1\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Filt1Btn);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(265, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Effect 2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Filt2Btn);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.resetBtn.Location = new System.Drawing.Point(265, 187);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(137, 29);
            this.resetBtn.TabIndex = 3;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.LightGray;
            this.savebtn.Location = new System.Drawing.Point(603, 160);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(175, 56);
            this.savebtn.TabIndex = 13;
            this.savebtn.Text = "Save Image";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.openBtn.Location = new System.Drawing.Point(265, 29);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(109, 28);
            this.openBtn.TabIndex = 14;
            this.openBtn.Text = "Browse\r\n";
            this.openBtn.UseVisualStyleBackColor = false;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(407, 29);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(249, 27);
            this.txtPath.TabIndex = 15;
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Width";
            // 
            // height_txt
            // 
            this.height_txt.Location = new System.Drawing.Point(531, 73);
            this.height_txt.Name = "height_txt";
            this.height_txt.Size = new System.Drawing.Size(89, 27);
            this.height_txt.TabIndex = 18;
            // 
            // width_txt
            // 
            this.width_txt.Location = new System.Drawing.Point(531, 111);
            this.width_txt.Name = "width_txt";
            this.width_txt.Size = new System.Drawing.Size(89, 27);
            this.width_txt.TabIndex = 19;
            // 
            // resizeBtn
            // 
            this.resizeBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.resizeBtn.Location = new System.Drawing.Point(639, 80);
            this.resizeBtn.Name = "resizeBtn";
            this.resizeBtn.Size = new System.Drawing.Size(107, 49);
            this.resizeBtn.TabIndex = 20;
            this.resizeBtn.Text = "Resize";
            this.resizeBtn.UseVisualStyleBackColor = false;
            this.resizeBtn.Click += new System.EventHandler(this.resizeBtn_Click);
            // 
            // effevt3Btn
            // 
            this.effevt3Btn.BackColor = System.Drawing.Color.Gainsboro;
            this.effevt3Btn.Location = new System.Drawing.Point(265, 149);
            this.effevt3Btn.Name = "effevt3Btn";
            this.effevt3Btn.Size = new System.Drawing.Size(109, 32);
            this.effevt3Btn.TabIndex = 21;
            this.effevt3Btn.Text = "Effect 3";
            this.effevt3Btn.UseVisualStyleBackColor = false;
            this.effevt3Btn.Click += new System.EventHandler(this.filter3Btn);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Location = new System.Drawing.Point(12, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.Location = new System.Drawing.Point(265, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 32);
            this.button3.TabIndex = 27;
            this.button3.Text = "Effect 3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.filter3img2_Click);
            // 
            // openimg2
            // 
            this.openimg2.BackColor = System.Drawing.Color.Gainsboro;
            this.openimg2.Location = new System.Drawing.Point(265, 235);
            this.openimg2.Name = "openimg2";
            this.openimg2.Size = new System.Drawing.Size(109, 28);
            this.openimg2.TabIndex = 26;
            this.openimg2.Text = "Browse\r\n";
            this.openimg2.UseVisualStyleBackColor = false;
            this.openimg2.Click += new System.EventHandler(this.openImg2Btn);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gainsboro;
            this.button5.Location = new System.Drawing.Point(265, 393);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 29);
            this.button5.TabIndex = 25;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.resetimg2_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gainsboro;
            this.button6.Location = new System.Drawing.Point(265, 317);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 32);
            this.button6.TabIndex = 24;
            this.button6.Text = "Effect 2";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.filter2img2Btn);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gainsboro;
            this.button7.Location = new System.Drawing.Point(264, 279);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 32);
            this.button7.TabIndex = 23;
            this.button7.Text = "Effect 1\r\n";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.filter1img2Btn);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Gainsboro;
            this.button8.Location = new System.Drawing.Point(639, 287);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(107, 49);
            this.button8.TabIndex = 34;
            this.button8.Text = "Resize";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.resizeimg2Btn_Click);
            // 
            // width2_txt
            // 
            this.width2_txt.Location = new System.Drawing.Point(531, 318);
            this.width2_txt.Name = "width2_txt";
            this.width2_txt.Size = new System.Drawing.Size(89, 27);
            this.width2_txt.TabIndex = 33;
            // 
            // height2_txt
            // 
            this.height2_txt.Location = new System.Drawing.Point(531, 280);
            this.height2_txt.Name = "height2_txt";
            this.height2_txt.Size = new System.Drawing.Size(89, 27);
            this.height2_txt.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Height";
            // 
            // txtPath2
            // 
            this.txtPath2.Location = new System.Drawing.Point(407, 236);
            this.txtPath2.Name = "txtPath2";
            this.txtPath2.Size = new System.Drawing.Size(249, 27);
            this.txtPath2.TabIndex = 29;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LightGray;
            this.button9.Location = new System.Drawing.Point(603, 367);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(175, 56);
            this.button9.TabIndex = 28;
            this.button9.Text = "Save Image";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.saveimg2Btn);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Gainsboro;
            this.button10.Location = new System.Drawing.Point(639, 496);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(107, 49);
            this.button10.TabIndex = 47;
            this.button10.Text = "Resize";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.resizeimg3Btn_Click);
            // 
            // width3_txt
            // 
            this.width3_txt.Location = new System.Drawing.Point(531, 527);
            this.width3_txt.Name = "width3_txt";
            this.width3_txt.Size = new System.Drawing.Size(89, 27);
            this.width3_txt.TabIndex = 46;
            // 
            // height3_txt
            // 
            this.height3_txt.Location = new System.Drawing.Point(531, 489);
            this.height3_txt.Name = "height3_txt";
            this.height3_txt.Size = new System.Drawing.Size(89, 27);
            this.height3_txt.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 525);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Height";
            // 
            // txtPath3
            // 
            this.txtPath3.Location = new System.Drawing.Point(407, 445);
            this.txtPath3.Name = "txtPath3";
            this.txtPath3.Size = new System.Drawing.Size(249, 27);
            this.txtPath3.TabIndex = 42;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LightGray;
            this.button11.Location = new System.Drawing.Point(603, 576);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(175, 56);
            this.button11.TabIndex = 41;
            this.button11.Text = "Save Image";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.saveimg3Btn);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Gainsboro;
            this.button12.Location = new System.Drawing.Point(265, 564);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(109, 32);
            this.button12.TabIndex = 40;
            this.button12.Text = "Effect 3";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.filter3img3Btn);
            // 
            // openimg3
            // 
            this.openimg3.BackColor = System.Drawing.Color.Gainsboro;
            this.openimg3.Location = new System.Drawing.Point(265, 444);
            this.openimg3.Name = "openimg3";
            this.openimg3.Size = new System.Drawing.Size(109, 28);
            this.openimg3.TabIndex = 39;
            this.openimg3.Text = "Browse\r\n";
            this.openimg3.UseVisualStyleBackColor = false;
            this.openimg3.Click += new System.EventHandler(this.openImg3Btn);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Gainsboro;
            this.button14.Location = new System.Drawing.Point(265, 602);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(137, 29);
            this.button14.TabIndex = 38;
            this.button14.Text = "Reset";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.resetimg3Btn);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Gainsboro;
            this.button15.Location = new System.Drawing.Point(265, 526);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(109, 32);
            this.button15.TabIndex = 37;
            this.button15.Text = "Effect 2";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.filter2img3Btn);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Gainsboro;
            this.button16.Location = new System.Drawing.Point(264, 488);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(110, 32);
            this.button16.TabIndex = 36;
            this.button16.Text = "Effect 1\r\n";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.filter1img3Btn);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox2.Location = new System.Drawing.Point(12, 444);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(247, 187);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 679);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.width3_txt);
            this.Controls.Add(this.height3_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPath3);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.openimg3);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.width2_txt);
            this.Controls.Add(this.height2_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPath2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.openimg2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.effevt3Btn);
            this.Controls.Add(this.resizeBtn);
            this.Controls.Add(this.width_txt);
            this.Controls.Add(this.height_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Image Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox height_txt;
        private System.Windows.Forms.TextBox width_txt;
        private System.Windows.Forms.Button resizeBtn;
        private System.Windows.Forms.Button effevt3Btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button openimg2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox width2_txt;
        private System.Windows.Forms.TextBox height2_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPath2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox width3_txt;
        private System.Windows.Forms.TextBox height3_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPath3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button openimg3;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog3;
    }
}

