﻿namespace FuckJW2005
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.capcha = new System.Windows.Forms.TextBox();
            this.captchaImg = new System.Windows.Forms.PictureBox();
            this.refreshCaptcha = new System.Windows.Forms.LinkLabel();
            this.login = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.listOutput = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.courseName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.courseTime = new System.Windows.Forms.ComboBox();
            this.goFuck = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.teacher = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AtkThdCount = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.attackJW = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.captchaImg)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AtkThdCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "说明：本软件仅供内部测试使用\r\n验证码识别免谈- -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "学号";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(57, 47);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(126, 21);
            this.username.TabIndex = 1;
            this.username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "密码";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(57, 79);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(126, 21);
            this.password.TabIndex = 2;
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "验证码";
            // 
            // capcha
            // 
            this.capcha.Location = new System.Drawing.Point(79, 111);
            this.capcha.Name = "capcha";
            this.capcha.Size = new System.Drawing.Size(104, 21);
            this.capcha.TabIndex = 3;
            this.capcha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.capcha_KeyPress);
            // 
            // captchaImg
            // 
            this.captchaImg.Location = new System.Drawing.Point(189, 50);
            this.captchaImg.Name = "captchaImg";
            this.captchaImg.Size = new System.Drawing.Size(116, 53);
            this.captchaImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.captchaImg.TabIndex = 3;
            this.captchaImg.TabStop = false;
            // 
            // refreshCaptcha
            // 
            this.refreshCaptcha.AutoSize = true;
            this.refreshCaptcha.Location = new System.Drawing.Point(189, 114);
            this.refreshCaptcha.Name = "refreshCaptcha";
            this.refreshCaptcha.Size = new System.Drawing.Size(65, 12);
            this.refreshCaptcha.TabIndex = 4;
            this.refreshCaptcha.TabStop = true;
            this.refreshCaptcha.Text = "刷新验证码";
            this.refreshCaptcha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.refreshCaptcha_LinkClicked);
            // 
            // login
            // 
            this.login.Enabled = false;
            this.login.Location = new System.Drawing.Point(348, 55);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(117, 67);
            this.login.TabIndex = 5;
            this.login.Text = "登陆";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 463);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(281, 12);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Github: https://github.com/qhgz2013/FuckJw2005";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "输出:";
            // 
            // listOutput
            // 
            this.listOutput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listOutput.FullRowSelect = true;
            this.listOutput.Location = new System.Drawing.Point(12, 303);
            this.listOutput.Name = "listOutput";
            this.listOutput.Size = new System.Drawing.Size(588, 146);
            this.listOutput.TabIndex = 10;
            this.listOutput.UseCompatibleStateImageBehavior = false;
            this.listOutput.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "时间";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "内容";
            this.columnHeader2.Width = 300;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "课程名称/代号 *";
            // 
            // courseName
            // 
            this.courseName.FormattingEnabled = true;
            this.courseName.Location = new System.Drawing.Point(111, 157);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(154, 20);
            this.courseName.TabIndex = 6;
            this.courseName.SelectedIndexChanged += new System.EventHandler(this.courseName_SelectedIndexChanged);
            this.courseName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.courseName_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(10, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "上课时间";
            // 
            // courseTime
            // 
            this.courseTime.Enabled = false;
            this.courseTime.FormattingEnabled = true;
            this.courseTime.Location = new System.Drawing.Point(111, 217);
            this.courseTime.Name = "courseTime";
            this.courseTime.Size = new System.Drawing.Size(214, 20);
            this.courseTime.TabIndex = 8;
            // 
            // goFuck
            // 
            this.goFuck.Location = new System.Drawing.Point(348, 157);
            this.goFuck.Name = "goFuck";
            this.goFuck.Size = new System.Drawing.Size(117, 63);
            this.goFuck.TabIndex = 9;
            this.goFuck.Text = "开干";
            this.goFuck.UseVisualStyleBackColor = true;
            this.goFuck.Click += new System.EventHandler(this.goFuck_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "教师姓名 *";
            // 
            // teacher
            // 
            this.teacher.Location = new System.Drawing.Point(111, 188);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(154, 21);
            this.teacher.TabIndex = 7;
            this.teacher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.teacher_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(389, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "* 为必要项，其余为可选项，注意每个内容都要与教务系统的名称相对应";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AtkThdCount);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.attackJW);
            this.groupBox1.Location = new System.Drawing.Point(482, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 114);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "危险区域";
            // 
            // AtkThdCount
            // 
            this.AtkThdCount.Location = new System.Drawing.Point(15, 87);
            this.AtkThdCount.Name = "AtkThdCount";
            this.AtkThdCount.Size = new System.Drawing.Size(78, 21);
            this.AtkThdCount.TabIndex = 2;
            this.AtkThdCount.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "线程数";
            // 
            // attackJW
            // 
            this.attackJW.Location = new System.Drawing.Point(10, 21);
            this.attackJW.Name = "attackJW";
            this.attackJW.Size = new System.Drawing.Size(96, 43);
            this.attackJW.TabIndex = 0;
            this.attackJW.Text = "攻击教务系统\r\n(后果自负)";
            this.attackJW.UseVisualStyleBackColor = true;
            this.attackJW.Click += new System.EventHandler(this.attackJW_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 478);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.goFuck);
            this.Controls.Add(this.courseTime);
            this.Controls.Add(this.courseName);
            this.Controls.Add(this.listOutput);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.refreshCaptcha);
            this.Controls.Add(this.captchaImg);
            this.Controls.Add(this.capcha);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Fuck SCUT Jw2005";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.captchaImg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AtkThdCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox capcha;
        private System.Windows.Forms.PictureBox captchaImg;
        private System.Windows.Forms.LinkLabel refreshCaptcha;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listOutput;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox courseName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox courseTime;
        private System.Windows.Forms.Button goFuck;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox teacher;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button attackJW;
        private System.Windows.Forms.NumericUpDown AtkThdCount;
        private System.Windows.Forms.Label label10;
    }
}

