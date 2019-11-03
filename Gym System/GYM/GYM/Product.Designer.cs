namespace GYM
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.qunatity = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.fees = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Product = new System.Windows.Forms.DataGridView();
            this.Product_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1017, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 196;
            this.pictureBox1.TabStop = false;
            // 
            // qunatity
            // 
            this.qunatity.Location = new System.Drawing.Point(218, 173);
            this.qunatity.Name = "qunatity";
            this.qunatity.Size = new System.Drawing.Size(202, 20);
            this.qunatity.TabIndex = 171;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(218, 105);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(202, 20);
            this.name.TabIndex = 4;
            // 
            // fees
            // 
            this.fees.Location = new System.Drawing.Point(218, 142);
            this.fees.Name = "fees";
            this.fees.Size = new System.Drawing.Size(202, 20);
            this.fees.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.qunatity);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.fees);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1017, 358);
            this.groupBox1.TabIndex = 195;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.search);
            this.groupBox3.Controls.Add(this.update);
            this.groupBox3.Controls.Add(this.insert);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox3.Location = new System.Drawing.Point(65, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 149);
            this.groupBox3.TabIndex = 199;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Options";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(138, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 20);
            this.label15.TabIndex = 172;
            this.label15.Text = "update";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 171;
            this.label4.Text = "view";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 168;
            this.label5.Text = "Insert";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.search.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.Location = new System.Drawing.Point(237, 68);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(104, 50);
            this.search.TabIndex = 183;
            this.search.UseVisualStyleBackColor = false;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Image = ((System.Drawing.Image)(resources.GetObject("update.Image")));
            this.update.Location = new System.Drawing.Point(126, 68);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(104, 50);
            this.update.TabIndex = 184;
            this.update.UseVisualStyleBackColor = false;
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.PaleTurquoise;
            this.insert.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.insert.FlatAppearance.BorderSize = 0;
            this.insert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.insert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert.Image = ((System.Drawing.Image)(resources.GetObject("insert.Image")));
            this.insert.Location = new System.Drawing.Point(16, 68);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(104, 50);
            this.insert.TabIndex = 182;
            this.insert.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(107, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 198;
            this.label8.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 192;
            this.label2.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 191;
            this.label1.Text = "Amount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(94, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 190;
            this.label11.Text = "Product ID";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(47, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 189;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Product);
            this.groupBox2.Location = new System.Drawing.Point(532, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 283);
            this.groupBox2.TabIndex = 185;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(218, 69);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(202, 20);
            this.id.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Goudy Stout", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(217, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(619, 28);
            this.label3.TabIndex = 197;
            this.label3.Text = "Gym Products management";
            // 
            // dgv_Product
            // 
            this.dgv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_ID,
            this.Product_Name,
            this.Amount,
            this.Quantity});
            this.dgv_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Product.Location = new System.Drawing.Point(3, 16);
            this.dgv_Product.Name = "dgv_Product";
            this.dgv_Product.Size = new System.Drawing.Size(457, 264);
            this.dgv_Product.TabIndex = 0;
            // 
            // Product_ID
            // 
            this.Product_ID.HeaderText = "Product_ID";
            this.Product_ID.Name = "Product_ID";
            this.Product_ID.ReadOnly = true;
            // 
            // Product_Name
            // 
            this.Product_Name.HeaderText = "Product_Name";
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            this.Product_Name.Width = 120;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 455);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product";
            this.Text = "Prodducts";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox qunatity;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox fees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}