namespace WaterBill_ASM2
{
    partial class ManageBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBill));
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.txtNameOfCustomer = new System.Windows.Forms.TextBox();
            this.txtWaterMeterLastMonth = new System.Windows.Forms.TextBox();
            this.txtWaterMeterThisMonth = new System.Windows.Forms.TextBox();
            this.txtNumberOfCustomer = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportInvoice = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTypeOfCustomer = new System.Windows.Forms.Label();
            this.lbNumberOfCustomer = new System.Windows.Forms.Label();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAsc = new System.Windows.Forms.Button();
            this.btnDesc = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbBoxTypeOfCustomer = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByName.Location = new System.Drawing.Point(591, 40);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(253, 27);
            this.txtSearchByName.TabIndex = 0;
            this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByName_TextChanged);
            // 
            // txtNameOfCustomer
            // 
            this.txtNameOfCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameOfCustomer.Location = new System.Drawing.Point(12, 162);
            this.txtNameOfCustomer.Name = "txtNameOfCustomer";
            this.txtNameOfCustomer.Size = new System.Drawing.Size(209, 26);
            this.txtNameOfCustomer.TabIndex = 1;
            // 
            // txtWaterMeterLastMonth
            // 
            this.txtWaterMeterLastMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWaterMeterLastMonth.Location = new System.Drawing.Point(12, 231);
            this.txtWaterMeterLastMonth.Name = "txtWaterMeterLastMonth";
            this.txtWaterMeterLastMonth.Size = new System.Drawing.Size(209, 26);
            this.txtWaterMeterLastMonth.TabIndex = 2;
            // 
            // txtWaterMeterThisMonth
            // 
            this.txtWaterMeterThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWaterMeterThisMonth.Location = new System.Drawing.Point(12, 295);
            this.txtWaterMeterThisMonth.Name = "txtWaterMeterThisMonth";
            this.txtWaterMeterThisMonth.Size = new System.Drawing.Size(209, 26);
            this.txtWaterMeterThisMonth.TabIndex = 3;
            // 
            // txtNumberOfCustomer
            // 
            this.txtNumberOfCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfCustomer.Location = new System.Drawing.Point(13, 429);
            this.txtNumberOfCustomer.Name = "txtNumberOfCustomer";
            this.txtNumberOfCustomer.Size = new System.Drawing.Size(209, 26);
            this.txtNumberOfCustomer.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search by name of customer :";
            // 
            // btnExportInvoice
            // 
            this.btnExportInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExportInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportInvoice.Location = new System.Drawing.Point(12, 490);
            this.btnExportInvoice.Name = "btnExportInvoice";
            this.btnExportInvoice.Size = new System.Drawing.Size(210, 30);
            this.btnExportInvoice.TabIndex = 8;
            this.btnExportInvoice.Text = "Export Invoice";
            this.btnExportInvoice.UseVisualStyleBackColor = false;
            this.btnExportInvoice.Click += new System.EventHandler(this.btnExportInvoice_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Red;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(11, 535);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(210, 30);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name of customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Water Meter Last Month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Water Meter This Month";
            // 
            // lbTypeOfCustomer
            // 
            this.lbTypeOfCustomer.AutoSize = true;
            this.lbTypeOfCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeOfCustomer.Location = new System.Drawing.Point(12, 338);
            this.lbTypeOfCustomer.Name = "lbTypeOfCustomer";
            this.lbTypeOfCustomer.Size = new System.Drawing.Size(131, 20);
            this.lbTypeOfCustomer.TabIndex = 13;
            this.lbTypeOfCustomer.Text = "Type of customer";
            // 
            // lbNumberOfCustomer
            // 
            this.lbNumberOfCustomer.AutoSize = true;
            this.lbNumberOfCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberOfCustomer.Location = new System.Drawing.Point(12, 406);
            this.lbNumberOfCustomer.Name = "lbNumberOfCustomer";
            this.lbNumberOfCustomer.Size = new System.Drawing.Size(135, 20);
            this.lbNumberOfCustomer.TabIndex = 14;
            this.lbNumberOfCustomer.Text = "Number of people";
            // 
            // dgvBill
            // 
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(273, 101);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.Size = new System.Drawing.Size(645, 363);
            this.dgvBill.TabIndex = 15;
            this.dgvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(312, 490);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 30);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(445, 490);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAsc
            // 
            this.btnAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsc.Location = new System.Drawing.Point(574, 490);
            this.btnAsc.Name = "btnAsc";
            this.btnAsc.Size = new System.Drawing.Size(90, 30);
            this.btnAsc.TabIndex = 18;
            this.btnAsc.Text = "ASC";
            this.btnAsc.UseVisualStyleBackColor = true;
            this.btnAsc.Click += new System.EventHandler(this.btnAsc_Click);
            // 
            // btnDesc
            // 
            this.btnDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesc.Location = new System.Drawing.Point(696, 490);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(90, 30);
            this.btnDesc.TabIndex = 19;
            this.btnDesc.Text = "DESC";
            this.btnDesc.UseVisualStyleBackColor = true;
            this.btnDesc.Click += new System.EventHandler(this.btnDesc_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(818, 490);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbBoxTypeOfCustomer
            // 
            this.cbBoxTypeOfCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxTypeOfCustomer.FormattingEnabled = true;
            this.cbBoxTypeOfCustomer.Items.AddRange(new object[] {
            "Household",
            "Personal"});
            this.cbBoxTypeOfCustomer.Location = new System.Drawing.Point(12, 361);
            this.cbBoxTypeOfCustomer.Name = "cbBoxTypeOfCustomer";
            this.cbBoxTypeOfCustomer.Size = new System.Drawing.Size(210, 28);
            this.cbBoxTypeOfCustomer.TabIndex = 21;
            this.cbBoxTypeOfCustomer.SelectedIndexChanged += new System.EventHandler(this.cbBoxTypeOfCustomer_SelectedIndexChanged);
            // 
            // ManageBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 586);
            this.Controls.Add(this.cbBoxTypeOfCustomer);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDesc);
            this.Controls.Add(this.btnAsc);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.lbNumberOfCustomer);
            this.Controls.Add(this.lbTypeOfCustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExportInvoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNumberOfCustomer);
            this.Controls.Add(this.txtWaterMeterThisMonth);
            this.Controls.Add(this.txtWaterMeterLastMonth);
            this.Controls.Add(this.txtNameOfCustomer);
            this.Controls.Add(this.txtSearchByName);
            this.Name = "ManageBill";
            this.Text = "ManageBill";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.TextBox txtNameOfCustomer;
        private System.Windows.Forms.TextBox txtWaterMeterLastMonth;
        private System.Windows.Forms.TextBox txtWaterMeterThisMonth;
        private System.Windows.Forms.TextBox txtNumberOfCustomer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportInvoice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTypeOfCustomer;
        private System.Windows.Forms.Label lbNumberOfCustomer;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAsc;
        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cbBoxTypeOfCustomer;
    }
}

