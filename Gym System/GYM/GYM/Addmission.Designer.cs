namespace GYM
{
    partial class Addmission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addmission));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.cb_Instructor = new System.Windows.Forms.ComboBox();
            this.Instructor_Label = new System.Windows.Forms.Label();
            this.cb_FeesMode = new System.Windows.Forms.ComboBox();
            this.batch = new System.Windows.Forms.TextBox();
            this.workout = new System.Windows.Forms.TextBox();
            this.listBox8 = new System.Windows.Forms.ListBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.dGv_datashow = new System.Windows.Forms.DataGridView();
            this.addmemberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gym_Management_SystemDataSet = new GYM.Gym_Management_SystemDataSet();
            this.addmemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addmemberTableAdapter = new GYM.Gym_Management_SystemDataSetTableAdapters.addmemberTableAdapter();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGv_datashow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addmemberBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gym_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addmemberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.search);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.insert);
            this.groupBox2.Controls.Add(this.View);
            this.groupBox2.Controls.Add(this.delete);
            this.groupBox2.Controls.Add(this.update);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox2.Location = new System.Drawing.Point(715, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 241);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "SEARCH";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Blue;
            this.search.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.Location = new System.Drawing.Point(189, 194);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(100, 38);
            this.search.TabIndex = 5;
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(50, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 20);
            this.label16.TabIndex = 7;
            this.label16.Text = "Delete";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(50, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "update";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(67, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 20);
            this.label13.TabIndex = 2;
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
            this.label12.TabIndex = 6;
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
            this.insert.TabIndex = 9;
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // View
            // 
            this.View.BackColor = System.Drawing.Color.BlueViolet;
            this.View.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.View.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.View.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View.Image = ((System.Drawing.Image)(resources.GetObject("View.Image")));
            this.View.Location = new System.Drawing.Point(188, 149);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(100, 38);
            this.View.TabIndex = 3;
            this.View.UseVisualStyleBackColor = false;
            this.View.Click += new System.EventHandler(this.View_Click);
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
            this.delete.TabIndex = 10;
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
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
            this.update.TabIndex = 0;
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_gender);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Id);
            this.groupBox1.Controls.Add(this.cb_Instructor);
            this.groupBox1.Controls.Add(this.Instructor_Label);
            this.groupBox1.Controls.Add(this.cb_FeesMode);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.batch);
            this.groupBox1.Controls.Add(this.workout);
            this.groupBox1.Controls.Add(this.listBox8);
            this.groupBox1.Controls.Add(this.contact);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.height);
            this.groupBox1.Controls.Add(this.weight);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1053, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Members";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cb_gender
            // 
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "Male\t",
            "Female"});
            this.cb_gender.Location = new System.Drawing.Point(87, 104);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(202, 21);
            this.cb_gender.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(87, 27);
            this.Id.Multiline = true;
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(202, 20);
            this.Id.TabIndex = 2;
            // 
            // cb_Instructor
            // 
            this.cb_Instructor.FormattingEnabled = true;
            this.cb_Instructor.Items.AddRange(new object[] {
            "Ali\t",
            "Kashan",
            "Ashar",
            "Umair"});
            this.cb_Instructor.Location = new System.Drawing.Point(484, 197);
            this.cb_Instructor.Name = "cb_Instructor";
            this.cb_Instructor.Size = new System.Drawing.Size(202, 21);
            this.cb_Instructor.TabIndex = 20;
            this.cb_Instructor.Visible = false;
            this.cb_Instructor.SelectedIndexChanged += new System.EventHandler(this.cb_Instructor_SelectedIndexChanged);
            // 
            // Instructor_Label
            // 
            this.Instructor_Label.AutoSize = true;
            this.Instructor_Label.Location = new System.Drawing.Point(409, 203);
            this.Instructor_Label.Name = "Instructor_Label";
            this.Instructor_Label.Size = new System.Drawing.Size(59, 13);
            this.Instructor_Label.TabIndex = 19;
            this.Instructor_Label.Text = "Instructor";
            this.Instructor_Label.Visible = false;
            // 
            // cb_FeesMode
            // 
            this.cb_FeesMode.FormattingEnabled = true;
            this.cb_FeesMode.Items.AddRange(new object[] {
            "1000\t",
            "2000"});
            this.cb_FeesMode.Location = new System.Drawing.Point(484, 151);
            this.cb_FeesMode.Name = "cb_FeesMode";
            this.cb_FeesMode.Size = new System.Drawing.Size(202, 21);
            this.cb_FeesMode.TabIndex = 18;
            this.cb_FeesMode.SelectedIndexChanged += new System.EventHandler(this.cb_FeesMode_SelectedIndexChanged);
            // 
            // batch
            // 
            this.batch.Location = new System.Drawing.Point(484, 74);
            this.batch.Name = "batch";
            this.batch.Size = new System.Drawing.Size(202, 20);
            this.batch.TabIndex = 14;
            // 
            // workout
            // 
            this.workout.Location = new System.Drawing.Point(484, 111);
            this.workout.Name = "workout";
            this.workout.Size = new System.Drawing.Size(202, 20);
            this.workout.TabIndex = 16;
            // 
            // listBox8
            // 
            this.listBox8.FormattingEnabled = true;
            this.listBox8.Location = new System.Drawing.Point(113, 276);
            this.listBox8.Name = "listBox8";
            this.listBox8.Size = new System.Drawing.Size(83, 225);
            this.listBox8.TabIndex = 169;
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(484, 29);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(202, 20);
            this.contact.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(422, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Batch";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(409, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Fees Mode";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(420, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "workout";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(87, 63);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(202, 20);
            this.name.TabIndex = 4;
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(87, 147);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(202, 20);
            this.height.TabIndex = 8;
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(87, 194);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(202, 20);
            this.weight.TabIndex = 10;
            // 
            // dGv_datashow
            // 
            this.dGv_datashow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGv_datashow.Location = new System.Drawing.Point(6, 277);
            this.dGv_datashow.Name = "dGv_datashow";
            this.dGv_datashow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGv_datashow.Size = new System.Drawing.Size(1049, 150);
            this.dGv_datashow.TabIndex = 197;
            this.dGv_datashow.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dGv_datashow_MouseDoubleClick);
            // 
            // addmemberBindingSource1
            // 
            this.addmemberBindingSource1.DataMember = "addmember";
            this.addmemberBindingSource1.DataSource = this.gym_Management_SystemDataSet;
            // 
            // gym_Management_SystemDataSet
            // 
            this.gym_Management_SystemDataSet.DataSetName = "Gym_Management_SystemDataSet";
            this.gym_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addmemberBindingSource
            // 
            this.addmemberBindingSource.DataMember = "addmember";
            this.addmemberBindingSource.DataSource = this.gym_Management_SystemDataSet;
            // 
            // addmemberTableAdapter
            // 
            this.addmemberTableAdapter.ClearBeforeFill = true;
            // 
            // Addmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 568);
            this.Controls.Add(this.dGv_datashow);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Addmission";
            this.Text = "Addmission";
            this.Load += new System.EventHandler(this.Addmission_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGv_datashow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addmemberBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gym_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addmemberBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox batch;
        private System.Windows.Forms.TextBox workout;
        private System.Windows.Forms.ListBox listBox8;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.DataGridView dGv_datashow;
        private System.Windows.Forms.ComboBox cb_FeesMode;
        private System.Windows.Forms.ComboBox cb_Instructor;
        private System.Windows.Forms.Label Instructor_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Id;
        private Gym_Management_SystemDataSet gym_Management_SystemDataSet;
        private System.Windows.Forms.BindingSource addmemberBindingSource;
        private Gym_Management_SystemDataSetTableAdapters.addmemberTableAdapter addmemberTableAdapter;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.BindingSource addmemberBindingSource1;
    }
}