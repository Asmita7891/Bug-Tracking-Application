namespace WindowsFormsApp1
{
    partial class Bug
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
            this.label_header = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_bugid = new System.Windows.Forms.TextBox();
            this.comboBox_project = new System.Windows.Forms.ComboBox();
            this.textBox_bugtitle = new System.Windows.Forms.TextBox();
            this.textBox_bugissue = new System.Windows.Forms.TextBox();
            this.btn_import = new System.Windows.Forms.Button();
            this.pictureBox_bugimg = new System.Windows.Forms.PictureBox();
            this.reportDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.combo_bugStatus = new System.Windows.Forms.ComboBox();
            this.lbl_img_path = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bugimg)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label_header.Location = new System.Drawing.Point(285, 8);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(245, 31);
            this.label_header.TabIndex = 0;
            this.label_header.Text = "Enter a Bug Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(28, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bug ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(432, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(28, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bug Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(28, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bug Issue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(432, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Image";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label_header);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 47);
            this.panel1.TabIndex = 6;
            // 
            // textBox_bugid
            // 
            this.textBox_bugid.Location = new System.Drawing.Point(117, 62);
            this.textBox_bugid.Name = "textBox_bugid";
            this.textBox_bugid.ReadOnly = true;
            this.textBox_bugid.Size = new System.Drawing.Size(260, 20);
            this.textBox_bugid.TabIndex = 7;
            // 
            // comboBox_project
            // 
            this.comboBox_project.FormattingEnabled = true;
            this.comboBox_project.Location = new System.Drawing.Point(523, 65);
            this.comboBox_project.Name = "comboBox_project";
            this.comboBox_project.Size = new System.Drawing.Size(243, 21);
            this.comboBox_project.TabIndex = 8;
            // 
            // textBox_bugtitle
            // 
            this.textBox_bugtitle.Location = new System.Drawing.Point(117, 107);
            this.textBox_bugtitle.Name = "textBox_bugtitle";
            this.textBox_bugtitle.Size = new System.Drawing.Size(260, 20);
            this.textBox_bugtitle.TabIndex = 7;
            // 
            // textBox_bugissue
            // 
            this.textBox_bugissue.Location = new System.Drawing.Point(117, 151);
            this.textBox_bugissue.Multiline = true;
            this.textBox_bugissue.Name = "textBox_bugissue";
            this.textBox_bugissue.Size = new System.Drawing.Size(260, 103);
            this.textBox_bugissue.TabIndex = 7;
            // 
            // btn_import
            // 
            this.btn_import.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_import.Location = new System.Drawing.Point(523, 149);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(75, 23);
            this.btn_import.TabIndex = 9;
            this.btn_import.Text = "import";
            this.btn_import.UseVisualStyleBackColor = false;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // pictureBox_bugimg
            // 
            this.pictureBox_bugimg.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_bugimg.Location = new System.Drawing.Point(604, 151);
            this.pictureBox_bugimg.Name = "pictureBox_bugimg";
            this.pictureBox_bugimg.Size = new System.Drawing.Size(162, 74);
            this.pictureBox_bugimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_bugimg.TabIndex = 10;
            this.pictureBox_bugimg.TabStop = false;
            // 
            // reportDate
            // 
            this.reportDate.CustomFormat = "yyyy-MM-dd";
            this.reportDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reportDate.Location = new System.Drawing.Point(523, 107);
            this.reportDate.Name = "reportDate";
            this.reportDate.Size = new System.Drawing.Size(243, 20);
            this.reportDate.TabIndex = 11;
            this.reportDate.Value = new System.DateTime(2018, 11, 14, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(432, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Report Date";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Green;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.Location = new System.Drawing.Point(116, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(93, 40);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.Green;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_update.Location = new System.Drawing.Point(283, 3);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(93, 40);
            this.button_update.TabIndex = 13;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Green;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_delete.Location = new System.Drawing.Point(434, 4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(93, 40);
            this.button_delete.TabIndex = 13;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.Green;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_cancel.Location = new System.Drawing.Point(586, 4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(93, 40);
            this.button_cancel.TabIndex = 13;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.button_cancel);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.button_delete);
            this.panel2.Controls.Add(this.button_update);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(1, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 47);
            this.panel2.TabIndex = 14;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(1, 398);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(838, 229);
            this.dataGridView.TabIndex = 15;
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_RowHeaderMouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(127, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Search";
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_search.Location = new System.Drawing.Point(193, 354);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(450, 23);
            this.textBox_search.TabIndex = 17;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(435, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Status";
            // 
            // combo_bugStatus
            // 
            this.combo_bugStatus.FormattingEnabled = true;
            this.combo_bugStatus.Items.AddRange(new object[] {
            "active",
            "solved"});
            this.combo_bugStatus.Location = new System.Drawing.Point(523, 239);
            this.combo_bugStatus.Name = "combo_bugStatus";
            this.combo_bugStatus.Size = new System.Drawing.Size(243, 21);
            this.combo_bugStatus.TabIndex = 8;
            this.combo_bugStatus.SelectedIndexChanged += new System.EventHandler(this.combo_bugStatus_SelectedIndexChanged);
            // 
            // lbl_img_path
            // 
            this.lbl_img_path.AutoSize = true;
            this.lbl_img_path.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_img_path.Location = new System.Drawing.Point(534, 204);
            this.lbl_img_path.Name = "lbl_img_path";
            this.lbl_img_path.Size = new System.Drawing.Size(49, 21);
            this.lbl_img_path.TabIndex = 19;
            this.lbl_img_path.Text = "path";
            // 
            // Bug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 639);
            this.Controls.Add(this.lbl_img_path);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reportDate);
            this.Controls.Add(this.pictureBox_bugimg);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.combo_bugStatus);
            this.Controls.Add(this.comboBox_project);
            this.Controls.Add(this.textBox_bugissue);
            this.Controls.Add(this.textBox_bugtitle);
            this.Controls.Add(this.textBox_bugid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Bug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug";
            this.Load += new System.EventHandler(this.Bug_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bugimg)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_bugid;
        private System.Windows.Forms.ComboBox comboBox_project;
        private System.Windows.Forms.TextBox textBox_bugtitle;
        private System.Windows.Forms.TextBox textBox_bugissue;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.PictureBox pictureBox_bugimg;
        private System.Windows.Forms.DateTimePicker reportDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combo_bugStatus;
        private System.Windows.Forms.Label lbl_img_path;
    }
}