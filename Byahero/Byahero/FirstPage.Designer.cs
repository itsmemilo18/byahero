namespace Byahero
{
    partial class FirstPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbU = new System.Windows.Forms.TextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkSignUp = new System.Windows.Forms.LinkLabel();
            this.linkFP = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cubao Free ", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "BYAHERO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbU
            // 
            this.tbU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbU.Location = new System.Drawing.Point(140, 385);
            this.tbU.Name = "tbU";
            this.tbU.Size = new System.Drawing.Size(220, 26);
            this.tbU.TabIndex = 10;
            this.tbU.Text = "Username";
            this.tbU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbU.Click += new System.EventHandler(this.tbU_Click);
            this.tbU.TextChanged += new System.EventHandler(this.tbU_TextChanged);
            this.tbU.Leave += new System.EventHandler(this.tbU_Leave_1);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(175, 460);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 30);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 543);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "New Here?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkSignUp
            // 
            this.linkSignUp.ActiveLinkColor = System.Drawing.Color.MidnightBlue;
            this.linkSignUp.AutoSize = true;
            this.linkSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSignUp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(88)))));
            this.linkSignUp.Location = new System.Drawing.Point(197, 567);
            this.linkSignUp.Name = "linkSignUp";
            this.linkSignUp.Size = new System.Drawing.Size(105, 20);
            this.linkSignUp.TabIndex = 7;
            this.linkSignUp.TabStop = true;
            this.linkSignUp.Text = "Sign up now!";
            this.linkSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignUp_LinkClicked);
            // 
            // linkFP
            // 
            this.linkFP.AutoSize = true;
            this.linkFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkFP.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(88)))));
            this.linkFP.Location = new System.Drawing.Point(169, 493);
            this.linkFP.Name = "linkFP";
            this.linkFP.Size = new System.Drawing.Size(162, 24);
            this.linkFP.TabIndex = 8;
            this.linkFP.TabStop = true;
            this.linkFP.Text = "Forgot Password?";
            this.linkFP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkFP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFP_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Byahero.Properties.Resources.MovingLogo;
            this.pictureBox1.Location = new System.Drawing.Point(140, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbP
            // 
            this.tbP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbP.Location = new System.Drawing.Point(140, 417);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(220, 26);
            this.tbP.TabIndex = 11;
            this.tbP.Text = "Password";
            this.tbP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbP.Click += new System.EventHandler(this.tbP_Click);
            this.tbP.Leave += new System.EventHandler(this.tbP_Leave_1);
            // 
            // FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(484, 701);
            this.Controls.Add(this.tbP);
            this.Controls.Add(this.linkFP);
            this.Controls.Add(this.linkSignUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FirstPage";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbU;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkSignUp;
        private System.Windows.Forms.LinkLabel linkFP;
        private System.Windows.Forms.TextBox tbP;
    }
}

