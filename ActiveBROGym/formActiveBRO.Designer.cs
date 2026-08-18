namespace ActiveBROGym
{
    partial class formActiveBRO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formActiveBRO));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.textCustID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textCustName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCustPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCustAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textCustPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textCustNote = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonGetAll = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataView, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1150, 530);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataView
            // 
            this.dataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataView.ColumnHeadersHeight = 30;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataView.Location = new System.Drawing.Point(3, 321);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(1144, 206);
            this.dataView.TabIndex = 12;
            this.dataView.SelectionChanged += new System.EventHandler(this.dataView_SelectionChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.textCustID);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.textCustName);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.textCustPhone);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.textCustAddress);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.textCustPrice);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.dateTime);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.textCustNote);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.buttonSave);
            this.flowLayoutPanel1.Controls.Add(this.buttonEdit);
            this.flowLayoutPanel1.Controls.Add(this.buttonDelete);
            this.flowLayoutPanel1.Controls.Add(this.buttonGetAll);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.buttonAbout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1144, 100);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkSalmon;
            this.label7.Location = new System.Drawing.Point(1033, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "رقم المشترك";
            // 
            // textCustID
            // 
            this.textCustID.BackColor = System.Drawing.Color.Tan;
            this.textCustID.Location = new System.Drawing.Point(957, 3);
            this.textCustID.Name = "textCustID";
            this.textCustID.Size = new System.Drawing.Size(70, 27);
            this.textCustID.TabIndex = 1;
            this.textCustID.Text = "تلقائي";
            this.textCustID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textCustID.TextChanged += new System.EventHandler(this.textCustID_TextChanged);
            this.textCustID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textCustID_KeyDown);
            this.textCustID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCustPrice_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSalmon;
            this.label1.Location = new System.Drawing.Point(837, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم المشترك";
            // 
            // textCustName
            // 
            this.textCustName.BackColor = System.Drawing.Color.Tan;
            this.textCustName.Location = new System.Drawing.Point(639, 3);
            this.textCustName.Name = "textCustName";
            this.textCustName.Size = new System.Drawing.Size(192, 27);
            this.textCustName.TabIndex = 2;
            this.textCustName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textCustName.TextChanged += new System.EventHandler(this.textCustName_TextChanged);
            this.textCustName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textCustName_KeyDown);
            this.textCustName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCustName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSalmon;
            this.label2.Location = new System.Drawing.Point(512, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "تلفون المشترك";
            // 
            // textCustPhone
            // 
            this.textCustPhone.BackColor = System.Drawing.Color.Tan;
            this.textCustPhone.Location = new System.Drawing.Point(333, 3);
            this.textCustPhone.Name = "textCustPhone";
            this.textCustPhone.Size = new System.Drawing.Size(173, 27);
            this.textCustPhone.TabIndex = 3;
            this.textCustPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textCustPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCustName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSalmon;
            this.label3.Location = new System.Drawing.Point(205, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "عنوان المشترك";
            // 
            // textCustAddress
            // 
            this.textCustAddress.BackColor = System.Drawing.Color.Tan;
            this.textCustAddress.Location = new System.Drawing.Point(16, 3);
            this.textCustAddress.Multiline = true;
            this.textCustAddress.Name = "textCustAddress";
            this.textCustAddress.Size = new System.Drawing.Size(183, 43);
            this.textCustAddress.TabIndex = 4;
            this.textCustAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textCustAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCustName_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSalmon;
            this.label6.Location = new System.Drawing.Point(1027, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "سعر الاشتراك";
            // 
            // textCustPrice
            // 
            this.textCustPrice.BackColor = System.Drawing.Color.Tan;
            this.textCustPrice.Location = new System.Drawing.Point(943, 52);
            this.textCustPrice.Name = "textCustPrice";
            this.textCustPrice.Size = new System.Drawing.Size(78, 27);
            this.textCustPrice.TabIndex = 5;
            this.textCustPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textCustPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCustPrice_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSalmon;
            this.label4.Location = new System.Drawing.Point(823, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "تاريخ الاشتراك";
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(635, 52);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(182, 27);
            this.dateTime.TabIndex = 6;
            this.dateTime.Value = new System.DateTime(2024, 12, 12, 15, 9, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSalmon;
            this.label5.Location = new System.Drawing.Point(552, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "ملاحظات";
            // 
            // textCustNote
            // 
            this.textCustNote.BackColor = System.Drawing.Color.Tan;
            this.textCustNote.Location = new System.Drawing.Point(363, 52);
            this.textCustNote.Multiline = true;
            this.textCustNote.Name = "textCustNote";
            this.textCustNote.Size = new System.Drawing.Size(183, 43);
            this.textCustNote.TabIndex = 7;
            this.textCustNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textCustNote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCustName_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSalmon;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(343, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = " ";
            // 
            // buttonSave
            // 
            this.buttonSave.AutoSize = true;
            this.buttonSave.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(281, 52);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(56, 31);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "حفظ";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.AutoSize = true;
            this.buttonEdit.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Location = new System.Drawing.Point(213, 52);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(62, 31);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "تعديل";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.AutoSize = true;
            this.buttonDelete.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(149, 52);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(58, 31);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "حذف";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonGetAll
            // 
            this.buttonGetAll.AutoSize = true;
            this.buttonGetAll.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonGetAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetAll.Location = new System.Drawing.Point(75, 52);
            this.buttonGetAll.Name = "buttonGetAll";
            this.buttonGetAll.Size = new System.Drawing.Size(68, 31);
            this.buttonGetAll.TabIndex = 11;
            this.buttonGetAll.Text = "تحديث";
            this.buttonGetAll.UseVisualStyleBackColor = false;
            this.buttonGetAll.Click += new System.EventHandler(this.buttonGetAll_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkSalmon;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(55, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = " ";
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Location = new System.Drawing.Point(15, 52);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(34, 27);
            this.buttonAbout.TabIndex = 20;
            this.buttonAbout.Text = "...";
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel2.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel2.Controls.Add(this.pictureBox3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 109);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1144, 206);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ActiveBROGym.Properties.Resources.interior_equipment_modern_gym_close_up_view_suspension_straps_sport_fitness_health_613910_20264;
            this.pictureBox2.Location = new System.Drawing.Point(770, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(371, 198);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ActiveBROGym.Properties.Resources.view_gym_room_training_sports_23_21516994951;
            this.pictureBox1.Location = new System.Drawing.Point(393, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ActiveBROGym.Properties.Resources.view_gym_room_training_sports_23_2151699495;
            this.pictureBox3.Location = new System.Drawing.Point(16, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(371, 198);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // formActiveBRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 530);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "formActiveBRO";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActiveBRO";
            this.Load += new System.EventHandler(this.formActiveBRO_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCustName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCustPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCustAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCustNote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textCustPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textCustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonGetAll;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Label label9;
    }
}

