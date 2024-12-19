namespace Byahero
{
    partial class JeepDatabase
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
            this.dgvJeep = new System.Windows.Forms.DataGridView();
            this.useraccDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.useraccDataSet = new Byahero.useraccDataSet();
            this.tbDriver = new System.Windows.Forms.TextBox();
            this.tbPlate = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbS = new System.Windows.Forms.TextBox();
            this.tbRoute = new System.Windows.Forms.TextBox();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.btnArchive = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJeep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useraccDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useraccDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJeep
            // 
            this.dgvJeep.AllowUserToAddRows = false;
            this.dgvJeep.AllowUserToDeleteRows = false;
            this.dgvJeep.AutoGenerateColumns = false;
            this.dgvJeep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJeep.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvJeep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJeep.DataSource = this.useraccDataSetBindingSource;
            this.dgvJeep.Location = new System.Drawing.Point(281, 22);
            this.dgvJeep.Name = "dgvJeep";
            this.dgvJeep.ReadOnly = true;
            this.dgvJeep.Size = new System.Drawing.Size(925, 562);
            this.dgvJeep.TabIndex = 0;
            this.dgvJeep.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJeep_CellClick);
            this.dgvJeep.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJeep_CellContentClick);
            this.dgvJeep.Click += new System.EventHandler(this.dgvJeep_Click);
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
            // tbDriver
            // 
            this.tbDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDriver.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbDriver.Location = new System.Drawing.Point(27, 294);
            this.tbDriver.Name = "tbDriver";
            this.tbDriver.Size = new System.Drawing.Size(231, 24);
            this.tbDriver.TabIndex = 1;
            this.tbDriver.Text = "Driver Name";
            this.tbDriver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDriver.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.tbDriver.Leave += new System.EventHandler(this.tbDriver_Leave);
            // 
            // tbPlate
            // 
            this.tbPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbPlate.Location = new System.Drawing.Point(27, 324);
            this.tbPlate.Name = "tbPlate";
            this.tbPlate.Size = new System.Drawing.Size(231, 24);
            this.tbPlate.TabIndex = 2;
            this.tbPlate.Text = "Plate Number";
            this.tbPlate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPlate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbPlate_MouseClick);
            this.tbPlate.Leave += new System.EventHandler(this.tbPlate_Leave);
            // 
            // tbPass
            // 
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbPass.Location = new System.Drawing.Point(27, 354);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(231, 24);
            this.tbPass.TabIndex = 3;
            this.tbPass.Text = "Passenger Count";
            this.tbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbPass_MouseClick);
            this.tbPass.Leave += new System.EventHandler(this.tbPass_Leave);
            // 
            // tbContact
            // 
            this.tbContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContact.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbContact.Location = new System.Drawing.Point(27, 384);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(231, 24);
            this.tbContact.TabIndex = 4;
            this.tbContact.Text = "Contact Number";
            this.tbContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbContact.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbContact_MouseClick);
            this.tbContact.Leave += new System.EventHandler(this.tbContact_Leave);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(93, 573);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 37);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(27, 512);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 37);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(163, 512);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 37);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(163, 457);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 37);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(27, 457);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 37);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(27, 31);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(231, 182);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 12;
            this.pbImage.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(93, 219);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(95, 36);
            this.btnUpload.TabIndex = 13;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbID.Location = new System.Drawing.Point(27, 264);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(231, 24);
            this.tbID.TabIndex = 14;
            this.tbID.Text = "USER ID";
            this.tbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 593);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Search: ";
            // 
            // tbS
            // 
            this.tbS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbS.Location = new System.Drawing.Point(340, 590);
            this.tbS.Name = "tbS";
            this.tbS.Size = new System.Drawing.Size(195, 26);
            this.tbS.TabIndex = 16;
            this.tbS.TextChanged += new System.EventHandler(this.tbS_TextChanged);
            // 
            // tbRoute
            // 
            this.tbRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRoute.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbRoute.Location = new System.Drawing.Point(27, 414);
            this.tbRoute.Name = "tbRoute";
            this.tbRoute.Size = new System.Drawing.Size(113, 24);
            this.tbRoute.TabIndex = 17;
            this.tbRoute.Text = "From";
            this.tbRoute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRoute.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbRoute_MouseClick);
            this.tbRoute.Leave += new System.EventHandler(this.tbRoute_Leave);
            // 
            // tbDestination
            // 
            this.tbDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDestination.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbDestination.Location = new System.Drawing.Point(146, 414);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(112, 24);
            this.tbDestination.TabIndex = 18;
            this.tbDestination.Text = "To";
            this.tbDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDestination.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbDestination_MouseClick_1);
            this.tbDestination.Leave += new System.EventHandler(this.tbDestination_Leave_1);
            // 
            // btnArchive
            // 
            this.btnArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchive.Location = new System.Drawing.Point(1111, 590);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(95, 37);
            this.btnArchive.TabIndex = 19;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // JeepDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1218, 658);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.tbDestination);
            this.Controls.Add(this.tbRoute);
            this.Controls.Add(this.tbS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbPlate);
            this.Controls.Add(this.tbDriver);
            this.Controls.Add(this.dgvJeep);
            this.Name = "JeepDatabase";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJeep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useraccDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useraccDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJeep;
        private System.Windows.Forms.BindingSource useraccDataSetBindingSource;
        private useraccDataSet useraccDataSet;
        private System.Windows.Forms.TextBox tbDriver;
        private System.Windows.Forms.TextBox tbPlate;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbS;
        private System.Windows.Forms.TextBox tbRoute;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.Button btnArchive;
    }
}