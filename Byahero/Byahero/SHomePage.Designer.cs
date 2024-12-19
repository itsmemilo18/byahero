namespace Byahero
{
    partial class SHomePage
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
            this.Username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.pbBooking = new System.Windows.Forms.PictureBox();
            this.pbFare = new System.Windows.Forms.PictureBox();
            this.pbTrips = new System.Windows.Forms.PictureBox();
            this.pbTime = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cubao Free ", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "BYAHERO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(187, 92);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(0, 42);
            this.Username.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 33);
            this.label2.TabIndex = 20;
            this.label2.Text = "Trips";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 33);
            this.label3.TabIndex = 21;
            this.label3.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 33);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fare";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(345, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 33);
            this.label5.TabIndex = 23;
            this.label5.Text = "Booking";
            // 
            // pbProfile
            // 
            this.pbProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProfile.Image = global::Byahero.Properties.Resources.user;
            this.pbProfile.Location = new System.Drawing.Point(497, -1);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(54, 53);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfile.TabIndex = 19;
            this.pbProfile.TabStop = false;
            this.pbProfile.Click += new System.EventHandler(this.pbProfile_Click);
            // 
            // pbBooking
            // 
            this.pbBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBooking.Image = global::Byahero.Properties.Resources._Original_size__Application_removebg_preview;
            this.pbBooking.Location = new System.Drawing.Point(335, 405);
            this.pbBooking.Name = "pbBooking";
            this.pbBooking.Size = new System.Drawing.Size(136, 128);
            this.pbBooking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBooking.TabIndex = 3;
            this.pbBooking.TabStop = false;
            this.pbBooking.Click += new System.EventHandler(this.pbBooking_Click);
            // 
            // pbFare
            // 
            this.pbFare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFare.Image = global::Byahero.Properties.Resources.images_removebg_preview;
            this.pbFare.Location = new System.Drawing.Point(90, 405);
            this.pbFare.Name = "pbFare";
            this.pbFare.Size = new System.Drawing.Size(136, 128);
            this.pbFare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFare.TabIndex = 2;
            this.pbFare.TabStop = false;
            this.pbFare.Click += new System.EventHandler(this.pbFare_Click);
            // 
            // pbTrips
            // 
            this.pbTrips.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTrips.Image = global::Byahero.Properties.Resources.Jeeps;
            this.pbTrips.Location = new System.Drawing.Point(90, 196);
            this.pbTrips.Name = "pbTrips";
            this.pbTrips.Size = new System.Drawing.Size(136, 128);
            this.pbTrips.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTrips.TabIndex = 1;
            this.pbTrips.TabStop = false;
            this.pbTrips.Click += new System.EventHandler(this.pbTrips_Click);
            // 
            // pbTime
            // 
            this.pbTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTime.Image = global::Byahero.Properties.Resources.departures_removebg_preview;
            this.pbTime.Location = new System.Drawing.Point(335, 196);
            this.pbTime.Name = "pbTime";
            this.pbTime.Size = new System.Drawing.Size(136, 128);
            this.pbTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTime.TabIndex = 24;
            this.pbTime.TabStop = false;
            this.pbTime.Click += new System.EventHandler(this.pbTime_Click);
            // 
            // SHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(551, 626);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbProfile);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbBooking);
            this.Controls.Add(this.pbFare);
            this.Controls.Add(this.pbTrips);
            this.Controls.Add(this.pbTime);
            this.Name = "SHomePage";
            this.Text = "SHomePage";
            this.Load += new System.EventHandler(this.SHomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTime;
        private System.Windows.Forms.PictureBox pbTrips;
        private System.Windows.Forms.PictureBox pbFare;
        private System.Windows.Forms.PictureBox pbBooking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}