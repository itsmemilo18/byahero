namespace Byahero
{
    partial class JeepArchive
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
            this.dgvJeep = new System.Windows.Forms.DataGridView();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.tbRoute = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbPlate = new System.Windows.Forms.TextBox();
            this.tbDriver = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJeep)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJeep
            // 
            this.dgvJeep.AllowUserToAddRows = false;
            this.dgvJeep.AllowUserToDeleteRows = false;
            this.dgvJeep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJeep.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvJeep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJeep.Location = new System.Drawing.Point(281, 23);
            this.dgvJeep.Name = "dgvJeep";
            this.dgvJeep.ReadOnly = true;
            this.dgvJeep.Size = new System.Drawing.Size(925, 562);
            this.dgvJeep.TabIndex = 1;
            this.dgvJeep.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJeep_CellClick);
            // 
            // tbDestination
            // 
            this.tbDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDestination.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbDestination.Location = new System.Drawing.Point(141, 369);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(112, 24);
            this.tbDestination.TabIndex = 25;
            this.tbDestination.Text = "To";
            this.tbDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbRoute
            // 
            this.tbRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRoute.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbRoute.Location = new System.Drawing.Point(22, 369);
            this.tbRoute.Name = "tbRoute";
            this.tbRoute.Size = new System.Drawing.Size(113, 24);
            this.tbRoute.TabIndex = 24;
            this.tbRoute.Text = "From";
            this.tbRoute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbID.Location = new System.Drawing.Point(22, 219);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(231, 24);
            this.tbID.TabIndex = 23;
            this.tbID.Text = "USER ID";
            this.tbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbContact
            // 
            this.tbContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContact.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbContact.Location = new System.Drawing.Point(22, 339);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(231, 24);
            this.tbContact.TabIndex = 22;
            this.tbContact.Text = "Contact Number";
            this.tbContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPass
            // 
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbPass.Location = new System.Drawing.Point(22, 309);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(231, 24);
            this.tbPass.TabIndex = 21;
            this.tbPass.Text = "Passenger Count";
            this.tbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPlate
            // 
            this.tbPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbPlate.Location = new System.Drawing.Point(22, 279);
            this.tbPlate.Name = "tbPlate";
            this.tbPlate.Size = new System.Drawing.Size(231, 24);
            this.tbPlate.TabIndex = 20;
            this.tbPlate.Text = "Plate Number";
            this.tbPlate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDriver
            // 
            this.tbDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDriver.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbDriver.Location = new System.Drawing.Point(22, 249);
            this.tbDriver.Name = "tbDriver";
            this.tbDriver.Size = new System.Drawing.Size(231, 24);
            this.tbDriver.TabIndex = 19;
            this.tbDriver.Text = "Driver Name";
            this.tbDriver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(158, 416);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 37);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Back";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(22, 416);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 37);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Restore";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // JeepArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1218, 658);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbDestination);
            this.Controls.Add(this.tbRoute);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbPlate);
            this.Controls.Add(this.tbDriver);
            this.Controls.Add(this.dgvJeep);
            this.Name = "JeepArchive";
            this.Text = "JeepArchive";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJeep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJeep;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.TextBox tbRoute;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbPlate;
        private System.Windows.Forms.TextBox tbDriver;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
    }
}