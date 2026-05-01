namespace Student_Registration_Managment
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crossingvehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromcity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tocity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Traveldate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tolltax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passenger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(16, 128);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 85);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Registration_Managment.Properties.Resources.user_profile_icon;
            this.pictureBox1.Location = new System.Drawing.Point(7, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Register New Driver";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Driver Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(705, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toll Plaza Vehicle TAX";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(503, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Manage  driver information and toll records efficiently";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AID,
            this.DriverName,
            this.DriverNIC,
            this.Crossingvehicle,
            this.fromcity,
            this.Tocity,
            this.Traveldate,
            this.Tolltax,
            this.passenger});
            this.dataGridView1.Location = new System.Drawing.Point(16, 305);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(969, 293);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // AID
            // 
            this.AID.DataPropertyName = "AID";
            this.AID.HeaderText = "AID";
            this.AID.Name = "AID";
            this.AID.ReadOnly = true;
            // 
            // DriverName
            // 
            this.DriverName.DataPropertyName = "DriverName";
            this.DriverName.HeaderText = "Driver Name";
            this.DriverName.MinimumWidth = 6;
            this.DriverName.Name = "DriverName";
            this.DriverName.ReadOnly = true;
            this.DriverName.Width = 230;
            // 
            // DriverNIC
            // 
            this.DriverNIC.DataPropertyName = "DriverNIC";
            this.DriverNIC.HeaderText = "Driver NIC";
            this.DriverNIC.MinimumWidth = 6;
            this.DriverNIC.Name = "DriverNIC";
            this.DriverNIC.ReadOnly = true;
            this.DriverNIC.Width = 200;
            // 
            // Crossingvehicle
            // 
            this.Crossingvehicle.DataPropertyName = "CrossingVehicle";
            this.Crossingvehicle.HeaderText = "Crossingvehicle";
            this.Crossingvehicle.MinimumWidth = 6;
            this.Crossingvehicle.Name = "Crossingvehicle";
            this.Crossingvehicle.ReadOnly = true;
            this.Crossingvehicle.Width = 150;
            // 
            // fromcity
            // 
            this.fromcity.DataPropertyName = "FromCity";
            this.fromcity.HeaderText = "fromcity";
            this.fromcity.MinimumWidth = 6;
            this.fromcity.Name = "fromcity";
            this.fromcity.ReadOnly = true;
            this.fromcity.Width = 150;
            // 
            // Tocity
            // 
            this.Tocity.DataPropertyName = "ToCity";
            this.Tocity.HeaderText = "To city";
            this.Tocity.MinimumWidth = 6;
            this.Tocity.Name = "Tocity";
            this.Tocity.ReadOnly = true;
            this.Tocity.Width = 130;
            // 
            // Traveldate
            // 
            this.Traveldate.DataPropertyName = "TravelDate";
            this.Traveldate.HeaderText = "Travel date";
            this.Traveldate.MinimumWidth = 6;
            this.Traveldate.Name = "Traveldate";
            this.Traveldate.ReadOnly = true;
            this.Traveldate.Width = 150;
            // 
            // Tolltax
            // 
            this.Tolltax.DataPropertyName = "TollTAX";
            this.Tolltax.HeaderText = "Toll tex";
            this.Tolltax.MinimumWidth = 6;
            this.Tolltax.Name = "Tolltax";
            this.Tolltax.ReadOnly = true;
            this.Tolltax.Width = 130;
            // 
            // passenger
            // 
            this.passenger.DataPropertyName = "Passengers";
            this.passenger.HeaderText = "passenger";
            this.passenger.MinimumWidth = 6;
            this.passenger.Name = "passenger";
            this.passenger.ReadOnly = true;
            this.passenger.Width = 130;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(18, 252);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(629, 32);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "search";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(181)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(681, 245);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add vehicle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 609);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverNIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Crossingvehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromcity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tocity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Traveldate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tolltax;
        private System.Windows.Forms.DataGridViewTextBoxColumn passenger;
    }
}

