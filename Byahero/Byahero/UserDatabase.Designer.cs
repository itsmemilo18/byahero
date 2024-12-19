namespace Byahero
{
    partial class UserDatabase
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
            this.dgvUserDatabase = new System.Windows.Forms.DataGridView();
            this.useraccDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.useraccDataSet = new Byahero.useraccDataSet();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbFN = new System.Windows.Forms.TextBox();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.tbLN = new System.Windows.Forms.TextBox();
            this.tbP = new System.Windows.Forms.TextBox();
            this.tbECP = new System.Windows.Forms.TextBox();
            this.tbCP = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbU = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useraccDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useraccDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserDatabase
            // 
            this.dgvUserDatabase.AllowUserToAddRows = false;
            this.dgvUserDatabase.AllowUserToDeleteRows = false;
            this.dgvUserDatabase.AutoGenerateColumns = false;
            this.dgvUserDatabase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserDatabase.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUserDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserDatabase.DataSource = this.useraccDataSetBindingSource;
            this.dgvUserDatabase.Location = new System.Drawing.Point(232, 22);
            this.dgvUserDatabase.Name = "dgvUserDatabase";
            this.dgvUserDatabase.ReadOnly = true;
            this.dgvUserDatabase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserDatabase.Size = new System.Drawing.Size(1233, 562);
            this.dgvUserDatabase.TabIndex = 0;
            this.dgvUserDatabase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserDatabase_CellClick);
            this.dgvUserDatabase.Click += new System.EventHandler(this.dgvUserDatabase_Click);
            // 
            // useraccDataSetBindingSource
            // 
            this.useraccDataSetBindingSource.DataSource = this.useraccDataSet;
            this.useraccDataSetBindingSource.Position = 0;
            // 
            // useraccDataSet
            // 
            this.useraccDataSet.DataSetName = "useraccDataSet";
            this.useraccDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(302, 595);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(218, 26);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 598);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1144, 590);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(211, 37);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1361, 590);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 37);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(12, 214);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(214, 26);
            this.tbID.TabIndex = 7;
            this.tbID.Text = "USER ID";
            this.tbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbFN
            // 
            this.tbFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFN.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbFN.Location = new System.Drawing.Point(12, 246);
            this.tbFN.Name = "tbFN";
            this.tbFN.ReadOnly = true;
            this.tbFN.Size = new System.Drawing.Size(214, 26);
            this.tbFN.TabIndex = 8;
            this.tbFN.Text = "First Name";
            this.tbFN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbContact
            // 
            this.tbContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContact.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbContact.Location = new System.Drawing.Point(12, 310);
            this.tbContact.Name = "tbContact";
            this.tbContact.ReadOnly = true;
            this.tbContact.Size = new System.Drawing.Size(214, 26);
            this.tbContact.TabIndex = 10;
            this.tbContact.Text = "Contact Number";
            this.tbContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLN
            // 
            this.tbLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLN.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbLN.Location = new System.Drawing.Point(12, 278);
            this.tbLN.Name = "tbLN";
            this.tbLN.ReadOnly = true;
            this.tbLN.Size = new System.Drawing.Size(214, 26);
            this.tbLN.TabIndex = 9;
            this.tbLN.Text = "Last Name";
            this.tbLN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbP
            // 
            this.tbP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbP.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbP.Location = new System.Drawing.Point(12, 438);
            this.tbP.Name = "tbP";
            this.tbP.ReadOnly = true;
            this.tbP.Size = new System.Drawing.Size(214, 26);
            this.tbP.TabIndex = 14;
            this.tbP.Text = "Password";
            this.tbP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbECP
            // 
            this.tbECP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbECP.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbECP.Location = new System.Drawing.Point(12, 406);
            this.tbECP.Name = "tbECP";
            this.tbECP.ReadOnly = true;
            this.tbECP.Size = new System.Drawing.Size(214, 26);
            this.tbECP.TabIndex = 13;
            this.tbECP.Text = "Emergency Contact Number";
            this.tbECP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCP
            // 
            this.tbCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCP.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbCP.Location = new System.Drawing.Point(12, 374);
            this.tbCP.Name = "tbCP";
            this.tbCP.ReadOnly = true;
            this.tbCP.Size = new System.Drawing.Size(214, 26);
            this.tbCP.TabIndex = 12;
            this.tbCP.Text = "Contact Person";
            this.tbCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbEmail.Location = new System.Drawing.Point(12, 342);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(214, 26);
            this.tbEmail.TabIndex = 11;
            this.tbEmail.Text = "E-mail Address";
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbU
            // 
            this.tbU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbU.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbU.Location = new System.Drawing.Point(12, 470);
            this.tbU.Name = "tbU";
            this.tbU.ReadOnly = true;
            this.tbU.Size = new System.Drawing.Size(214, 26);
            this.tbU.TabIndex = 15;
            this.tbU.Text = "Username";
            this.tbU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(927, 590);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(211, 37);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnArchive
            // 
            this.btnArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchive.Location = new System.Drawing.Point(817, 590);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(104, 37);
            this.btnArchive.TabIndex = 18;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(630, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 37);
            this.button1.TabIndex = 19;
            this.button1.Text = "Transaction History";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(12, 22);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(214, 186);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 16;
            this.pbImage.TabStop = false;
            // 
            // UserDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1477, 659);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.tbU);
            this.Controls.Add(this.tbP);
            this.Controls.Add(this.tbECP);
            this.Controls.Add(this.tbCP);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.tbLN);
            this.Controls.Add(this.tbFN);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgvUserDatabase);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "UserDatabase";
            this.Text = "UserDatabase";
            this.Load += new System.EventHandler(this.UserDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useraccDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useraccDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserDatabase;
        private System.Windows.Forms.BindingSource useraccDataSetBindingSource;
        private useraccDataSet useraccDataSet;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbFN;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.TextBox tbLN;
        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.TextBox tbECP;
        private System.Windows.Forms.TextBox tbCP;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbU;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Button button1;
    }
}