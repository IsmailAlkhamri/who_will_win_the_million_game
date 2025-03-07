namespace HowWinWithMillionApp
{
    partial class CallFriend
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallFriend));
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.confirmBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ans = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Calllabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::HowWinWithMillionApp.Properties.Resources.ب;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(68, 45);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(230, 131);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 1;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Animated = true;
            this.confirmBtn.BackColor = System.Drawing.Color.Transparent;
            this.confirmBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirmBtn.BorderColor = System.Drawing.Color.White;
            this.confirmBtn.BorderThickness = 2;
            this.confirmBtn.CheckedState.Parent = this.confirmBtn;
            this.confirmBtn.CustomBorderColor = System.Drawing.Color.White;
            this.confirmBtn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("confirmBtn.CustomImages.Image")));
            this.confirmBtn.CustomImages.Parent = this.confirmBtn;
            this.confirmBtn.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.confirmBtn.Font = new System.Drawing.Font("Dubai", 14F, System.Drawing.FontStyle.Bold);
            this.confirmBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.confirmBtn.HoverState.BorderColor = System.Drawing.Color.White;
            this.confirmBtn.HoverState.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.confirmBtn.HoverState.Parent = this.confirmBtn;
            this.confirmBtn.ImageSize = new System.Drawing.Size(10, 10);
            this.confirmBtn.Location = new System.Drawing.Point(43, 192);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.PressedColor = System.Drawing.Color.Gold;
            this.confirmBtn.ShadowDecoration.BorderRadius = 1;
            this.confirmBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.confirmBtn.ShadowDecoration.Parent = this.confirmBtn;
            this.confirmBtn.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2);
            this.confirmBtn.Size = new System.Drawing.Size(168, 44);
            this.confirmBtn.TabIndex = 3;
            this.confirmBtn.Text = "إغلاق";
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.confirmBtn);
            this.panel1.Controls.Add(this.Ans);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(59, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 247);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // Ans
            // 
            this.Ans.BackColor = System.Drawing.Color.Transparent;
            this.Ans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ans.Font = new System.Drawing.Font("Dubai", 20F, System.Drawing.FontStyle.Bold);
            this.Ans.ForeColor = System.Drawing.Color.Yellow;
            this.Ans.Location = new System.Drawing.Point(92, 96);
            this.Ans.Name = "Ans";
            this.Ans.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Ans.Size = new System.Drawing.Size(73, 47);
            this.Ans.TabIndex = 5;
            this.Ans.Text = "( أ )";
            this.Ans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Monotype Koufi", 20F);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(206, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "الإجابة الصحيحة هي :";
            // 
            // Calllabel
            // 
            this.Calllabel.AutoSize = true;
            this.Calllabel.BackColor = System.Drawing.Color.Transparent;
            this.Calllabel.Font = new System.Drawing.Font("Dubai", 20F, System.Drawing.FontStyle.Bold);
            this.Calllabel.ForeColor = System.Drawing.Color.White;
            this.Calllabel.Location = new System.Drawing.Point(56, 343);
            this.Calllabel.Name = "Calllabel";
            this.Calllabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Calllabel.Size = new System.Drawing.Size(241, 45);
            this.Calllabel.TabIndex = 6;
            this.Calllabel.Text = "جار الإتصال بصديق ...";
            this.Calllabel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 16F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(275, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "-";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 10F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(306, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "[]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(333, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(-31, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(397, 30);
            this.label5.TabIndex = 13;
            // 
            // CallFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HowWinWithMillionApp.Properties.Resources.المليون_خلفيه;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(366, 459);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Calllabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CallFriend";
            this.Opacity = 0.99D;
            this.Text = "CallFriend";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CallFriend_FormClosing);
            this.Load += new System.EventHandler(this.CallFriend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2CircleButton confirmBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Ans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Calllabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}