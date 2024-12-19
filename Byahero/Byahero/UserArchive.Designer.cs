namespace Byahero
{
    partial class UserArchive
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
            this.tbU = new System.Windows.Forms.TextBox();
            this.tbP = new System.Windows.Forms.TextBox();
            this.tbECP = new System.Windows.Forms.TextBox();
            this.tbCP = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.tbLN = new System.Windows.Forms.TextBox();
            this.tbFN = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.dgvUserDatabase = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // tbU
            // 
            this.tbU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbU.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbU.Location = new System.Drawing.Point(12, 389);
            this.tbU.Name = "tbU";
            this.tbU.ReadOnly = true;
            this.tbU.Size = new System.Drawing.Size(214, 26);
            this.tbU.TabIndex = 25;
            this.tbU.Text = "Username";
            this.tbU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbP
            // 
            this.tbP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbP.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbP.Location = new System.Drawing.Point(12, 357);
            this.tbP.Name = "tbP";
            this.tbP.ReadOnly = true;
            this.tbP.Size = new System.Drawing.Size(214, 26);
            this.tbP.TabIndex = 24;
            this.tbP.Text = "Password";
            this.tbP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbECP
            // 
            this.tbECP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbECP.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbECP.Location = new System.Drawing.Point(12, 325);
            this.tbECP.Name = "tbECP";
            this.tbECP.ReadOnly = true;
            this.tbECP.Size = new System.Drawing.Size(214, 26);
            this.tbECP.TabIndex = 23;
            this.tbECP.Text = "Emergency Contact Number";
            this.tbECP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCP
            // 
            this.tbCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCP.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbCP.Location = new System.Drawing.Point(12, 293);
            this.tbCP.Name = "tbCP";
            this.tbCP.ReadOnly = true;
            this.tbCP.Size = new System.Drawing.Size(214, 26);
            this.tbCP.TabIndex = 22;
            this.tbCP.Text = "Contact Person";
            this.tbCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbEmail.Location = new System.Drawing.Point(12, 261);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(214, 26);
            this.tbEmail.TabIndex = 21;
            this.tbEmail.Text = "E-mail Address";
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbContact
            // 
            this.tbContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContact.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbContact.Location = new System.Drawing.Point(12, 229);
            this.tbContact.Name = "tbContact";
            this.tbContact.ReadOnly = true;
            this.tbContact.Size = new System.Drawing.Size(214, 26);
            this.tbContact.TabIndex = 20;
            this.tbContact.Text = "Contact Number";
            this.tbContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLN
            // 
            this.tbLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLN.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbLN.Location = new System.Drawing.Point(12, 197);
            this.tbLN.Name = "tbLN";
            this.tbLN.ReadOnly = true;
            this.tbLN.Size = new System.Drawing.Size(214, 26);
            this.tbLN.TabIndex = 19;
            this.tbLN.Text = "Last Name";
            this.tbLN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbFN
            // 
            this.tbFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFN.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbFN.Location = new System.Drawing.Point(12, 165);
            this.tbFN.Name = "tbFN";
            this.tbFN.ReadOnly = true;
            this.tbFN.Size = new System.Drawing.Size(214, 26);
            this.tbFN.TabIndex = 18;
            this.tbFN.Text = "First Name";
            this.tbFN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(12, 133);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(214, 26);
            this.tbID.TabIndex = 17;
            this.tbID.Text = "USER ID";
            this.tbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvUserDatabase
            // 
            this.dgvUserDatabase.AllowUserToAddRows = false;
            this.dgvUserDatabase.AllowUserToDeleteRows = false;
            this.dgvUserDatabase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserDatabase.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUserDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserDatabase.Location = new System.Drawing.Point(232, 24);
            this.dgvUserDatabase.Name = "dgvUserDatabase";
            this.dgvUserDatabase.ReadOnly = true;
            this.dgvUserDatabase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserDatabase.Size = new System.Drawing.Size(1233, 562);
            this.dgvUserDatabase.TabIndex = 16;
            this.dgvUserDatabase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserDatabase_CellClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(131, 432);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 36);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Back";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.Location = new System.Drawing.Point(12, 432);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(95, 36);
            this.btnRestore.TabIndex = 28;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click_1);
            // 
            // UserArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1477, 659);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbU);
            this.Controls.Add(this.tbP);
            this.Controls.Add(this.tbECP);
            this.Controls.Add(this.tbCP);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.tbLN);
            this.Controls.Add(this.tbFN);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.dgvUserDatabase);
            this.Name = "UserArchive";
            this.Text = "UserArchive";
            this.Load += new System.EventHandler(this.UserArchive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserDatabase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbU;
        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.TextBox tbECP;
        private System.Windows.Forms.TextBox tbCP;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.TextBox tbLN;
        private System.Windows.Forms.TextBox tbFN;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.DataGridView dgvUserDatabase;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRestore;
    }
}