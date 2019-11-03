namespace GYM
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rregisteredbtn = new System.Windows.Forms.PictureBox();
            this.dgVAccount = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.gym_Management_SystemDataSet = new GYM.Gym_Management_SystemDataSet();
            this.registrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrationTableAdapter = new GYM.Gym_Management_SystemDataSetTableAdapters.RegistrationTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rregisteredbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVAccount)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gym_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Rregisteredbtn);
            this.panel1.Controls.Add(this.dgVAccount);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 520);
            this.panel1.TabIndex = 0;
            // 
            // Rregisteredbtn
            // 
            this.Rregisteredbtn.Image = ((System.Drawing.Image)(resources.GetObject("Rregisteredbtn.Image")));
            this.Rregisteredbtn.Location = new System.Drawing.Point(928, 236);
            this.Rregisteredbtn.Name = "Rregisteredbtn";
            this.Rregisteredbtn.Size = new System.Drawing.Size(128, 40);
            this.Rregisteredbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Rregisteredbtn.TabIndex = 177;
            this.Rregisteredbtn.TabStop = false;
            this.Rregisteredbtn.Click += new System.EventHandler(this.Rregisteredbtn_Click);
            // 
            // dgVAccount
            // 
            this.dgVAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVAccount.Location = new System.Drawing.Point(3, -3);
            this.dgVAccount.Name = "dgVAccount";
            this.dgVAccount.Size = new System.Drawing.Size(821, 523);
            this.dgVAccount.TabIndex = 176;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.insert);
            this.groupBox2.Controls.Add(this.search);
            this.groupBox2.Controls.Add(this.delete);
            this.groupBox2.Controls.Add(this.update);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox2.Location = new System.Drawing.Point(830, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 227);
            this.groupBox2.TabIndex = 175;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Options";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(50, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 20);
            this.label16.TabIndex = 173;
            this.label16.Text = "Delete";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(50, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 20);
            this.label15.TabIndex = 172;
            this.label15.Text = "update";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(67, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 20);
            this.label13.TabIndex = 171;
            this.label13.Text = "view";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Wide Latin", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(84, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 16);
            this.label14.TabIndex = 170;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(50, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 20);
            this.label12.TabIndex = 168;
            this.label12.Text = "Insert";
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.SteelBlue;
            this.insert.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.insert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.insert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert.Image = ((System.Drawing.Image)(resources.GetObject("insert.Image")));
            this.insert.Location = new System.Drawing.Point(188, 16);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(100, 38);
            this.insert.TabIndex = 164;
            this.insert.UseVisualStyleBackColor = false;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.BlueViolet;
            this.search.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.Location = new System.Drawing.Point(188, 149);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(100, 38);
            this.search.TabIndex = 165;
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.DarkRed;
            this.delete.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Location = new System.Drawing.Point(188, 61);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 38);
            this.delete.TabIndex = 167;
            this.delete.UseVisualStyleBackColor = false;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Image = ((System.Drawing.Image)(resources.GetObject("update.Image")));
            this.update.Location = new System.Drawing.Point(188, 105);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(100, 38);
            this.update.TabIndex = 166;
            this.update.UseVisualStyleBackColor = false;
            // 
            // gym_Management_SystemDataSet
            // 
            this.gym_Management_SystemDataSet.DataSetName = "Gym_Management_SystemDataSet";
            this.gym_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrationBindingSource
            // 
            this.registrationBindingSource.DataMember = "Registration";
            this.registrationBindingSource.DataSource = this.gym_Management_SystemDataSet;
            // 
            // registrationTableAdapter
            // 
            this.registrationTableAdapter.ClearBeforeFill = true;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 535);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Rregisteredbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVAccount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gym_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.PictureBox Rregisteredbtn;
        private System.Windows.Forms.DataGridView dgVAccount;
        private Gym_Management_SystemDataSet gym_Management_SystemDataSet;
        private System.Windows.Forms.BindingSource registrationBindingSource;
        private Gym_Management_SystemDataSetTableAdapters.RegistrationTableAdapter registrationTableAdapter;
    }
}