namespace Byahero
{
    partial class UserFare
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
            this.dgvFare = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFare
            // 
            this.dgvFare.AllowUserToAddRows = false;
            this.dgvFare.AllowUserToDeleteRows = false;
            this.dgvFare.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFare.Location = new System.Drawing.Point(12, 126);
            this.dgvFare.Name = "dgvFare";
            this.dgvFare.ReadOnly = true;
            this.dgvFare.Size = new System.Drawing.Size(425, 463);
            this.dgvFare.TabIndex = 2;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(163, 81);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(95, 42);
            this.Username.TabIndex = 15;
            this.Username.Text = "Fare";
            // 
            // pbBack
            // 
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBack.Image = global::Byahero.Properties.Resources.arrowleft;
            this.pbBack.Location = new System.Drawing.Point(12, 12);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(50, 50);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 16;
            this.pbBack.TabStop = false;
            this.pbBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbBack_MouseClick);
            // 
            // UserFare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(448, 601);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.dgvFare);
            this.Name = "UserFare";
            this.Text = "UserFare";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFare;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.PictureBox pbBack;
    }
}