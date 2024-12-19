namespace Byahero
{
    partial class HomePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.pbUsers = new System.Windows.Forms.PictureBox();
            this.pbFare = new System.Windows.Forms.PictureBox();
            this.pbJeeps = new System.Windows.Forms.PictureBox();
            this.pbTrips = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJeeps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrips)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cubao Free ", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "BYAHERO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trips";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Jeeps";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fare";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 15;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(188, 127);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(123, 42);
            this.Username.TabIndex = 12;
            this.Username.Text = "Admin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(306, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 37);
            this.label6.TabIndex = 17;
            this.label6.Text = "Users";
            // 
            // pbProfile
            // 
            this.pbProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProfile.Image = global::Byahero.Properties.Resources.user;
            this.pbProfile.Location = new System.Drawing.Point(432, 0);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(54, 53);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfile.TabIndex = 18;
            this.pbProfile.TabStop = false;
            this.pbProfile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbProfile_MouseClick);
            // 
            // pbUsers
            // 
            this.pbUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUsers.Image = global::Byahero.Properties.Resources.Commuters;
            this.pbUsers.Location = new System.Drawing.Point(289, 442);
            this.pbUsers.Name = "pbUsers";
            this.pbUsers.Size = new System.Drawing.Size(136, 141);
            this.pbUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsers.TabIndex = 14;
            this.pbUsers.TabStop = false;
            this.pbUsers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbUsers_MouseClick);
            // 
            // pbFare
            // 
            this.pbFare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFare.Image = global::Byahero.Properties.Resources.images_removebg_preview;
            this.pbFare.Location = new System.Drawing.Point(59, 442);
            this.pbFare.Name = "pbFare";
            this.pbFare.Size = new System.Drawing.Size(136, 141);
            this.pbFare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFare.TabIndex = 16;
            this.pbFare.TabStop = false;
            this.pbFare.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbFare_MouseClick);
            // 
            // pbJeeps
            // 
            this.pbJeeps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbJeeps.Image = global::Byahero.Properties.Resources.Jeeps;
            this.pbJeeps.Location = new System.Drawing.Point(289, 225);
            this.pbJeeps.Name = "pbJeeps";
            this.pbJeeps.Size = new System.Drawing.Size(136, 141);
            this.pbJeeps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbJeeps.TabIndex = 7;
            this.pbJeeps.TabStop = false;
            this.pbJeeps.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbJeeps_MouseClick);
            // 
            // pbTrips
            // 
            this.pbTrips.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTrips.Image = global::Byahero.Properties.Resources.jipynitw_removebg_preview;
            this.pbTrips.Location = new System.Drawing.Point(59, 225);
            this.pbTrips.Name = "pbTrips";
            this.pbTrips.Size = new System.Drawing.Size(136, 141);
            this.pbTrips.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTrips.TabIndex = 16;
            this.pbTrips.TabStop = false;
            this.pbTrips.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbTrips_MouseClick);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(484, 701);
            this.Controls.Add(this.pbProfile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.pbUsers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbFare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbJeeps);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbTrips);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJeeps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrips)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbTrips;
        private System.Windows.Forms.PictureBox pbJeeps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbFare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbUsers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbProfile;
    }
}