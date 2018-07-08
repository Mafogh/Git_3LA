namespace SE_3LA_Proj
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btncustomerdisplay = new System.Windows.Forms.Button();
            this.btnroomdisplay = new System.Windows.Forms.Button();
            this.btnroomreserve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtroomnum = new System.Windows.Forms.TextBox();
            this.txtreserveid = new System.Windows.Forms.TextBox();
            this.mtxtreserveto = new System.Windows.Forms.MaskedTextBox();
            this.txtcustomerid = new System.Windows.Forms.TextBox();
            this.mtxtreservedate = new System.Windows.Forms.MaskedTextBox();
            this.mtxtreservefrom = new System.Windows.Forms.MaskedTextBox();
            this.btnreservedisplay = new System.Windows.Forms.Button();
            this.btndeleteall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(657, 437);
            this.dataGridView1.TabIndex = 0;
            // 
            // btncustomerdisplay
            // 
            this.btncustomerdisplay.Location = new System.Drawing.Point(675, 410);
            this.btncustomerdisplay.Name = "btncustomerdisplay";
            this.btncustomerdisplay.Size = new System.Drawing.Size(197, 39);
            this.btncustomerdisplay.TabIndex = 1;
            this.btncustomerdisplay.Text = "نمایش مشتری ها";
            this.btncustomerdisplay.UseVisualStyleBackColor = true;
            this.btncustomerdisplay.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnroomdisplay
            // 
            this.btnroomdisplay.Location = new System.Drawing.Point(675, 365);
            this.btnroomdisplay.Name = "btnroomdisplay";
            this.btnroomdisplay.Size = new System.Drawing.Size(197, 39);
            this.btnroomdisplay.TabIndex = 2;
            this.btnroomdisplay.Text = "نمایش اتاق ها";
            this.btnroomdisplay.UseVisualStyleBackColor = true;
            this.btnroomdisplay.Click += new System.EventHandler(this.btnroomdisplay_Click);
            // 
            // btnroomreserve
            // 
            this.btnroomreserve.Location = new System.Drawing.Point(675, 230);
            this.btnroomreserve.Name = "btnroomreserve";
            this.btnroomreserve.Size = new System.Drawing.Size(197, 39);
            this.btnroomreserve.TabIndex = 3;
            this.btnroomreserve.Text = "رزرو اتاق";
            this.btnroomreserve.UseVisualStyleBackColor = true;
            this.btnroomreserve.Click += new System.EventHandler(this.btnroomreserve_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(781, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "شناسه رزرواسیون";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(798, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "شناسه مشتری";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(816, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "تاریخ رزرو";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(829, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "از تاریخ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(814, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "شماره اتاق";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(829, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "تا تاریخ";
            // 
            // txtroomnum
            // 
            this.txtroomnum.Location = new System.Drawing.Point(675, 174);
            this.txtroomnum.Name = "txtroomnum";
            this.txtroomnum.Size = new System.Drawing.Size(100, 20);
            this.txtroomnum.TabIndex = 12;
            // 
            // txtreserveid
            // 
            this.txtreserveid.Location = new System.Drawing.Point(675, 12);
            this.txtreserveid.Name = "txtreserveid";
            this.txtreserveid.Size = new System.Drawing.Size(100, 20);
            this.txtreserveid.TabIndex = 13;
            // 
            // mtxtreserveto
            // 
            this.mtxtreserveto.Location = new System.Drawing.Point(675, 141);
            this.mtxtreserveto.Mask = "00/00/0000";
            this.mtxtreserveto.Name = "mtxtreserveto";
            this.mtxtreserveto.Size = new System.Drawing.Size(100, 20);
            this.mtxtreserveto.TabIndex = 14;
            this.mtxtreserveto.ValidatingType = typeof(System.DateTime);
            // 
            // txtcustomerid
            // 
            this.txtcustomerid.Location = new System.Drawing.Point(675, 45);
            this.txtcustomerid.Name = "txtcustomerid";
            this.txtcustomerid.Size = new System.Drawing.Size(100, 20);
            this.txtcustomerid.TabIndex = 16;
            // 
            // mtxtreservedate
            // 
            this.mtxtreservedate.Location = new System.Drawing.Point(675, 77);
            this.mtxtreservedate.Mask = "00/00/0000";
            this.mtxtreservedate.Name = "mtxtreservedate";
            this.mtxtreservedate.Size = new System.Drawing.Size(100, 20);
            this.mtxtreservedate.TabIndex = 17;
            this.mtxtreservedate.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtreservefrom
            // 
            this.mtxtreservefrom.Location = new System.Drawing.Point(675, 109);
            this.mtxtreservefrom.Mask = "00/00/0000";
            this.mtxtreservefrom.Name = "mtxtreservefrom";
            this.mtxtreservefrom.Size = new System.Drawing.Size(100, 20);
            this.mtxtreservefrom.TabIndex = 18;
            this.mtxtreservefrom.ValidatingType = typeof(System.DateTime);
            // 
            // btnreservedisplay
            // 
            this.btnreservedisplay.Location = new System.Drawing.Point(675, 275);
            this.btnreservedisplay.Name = "btnreservedisplay";
            this.btnreservedisplay.Size = new System.Drawing.Size(197, 39);
            this.btnreservedisplay.TabIndex = 19;
            this.btnreservedisplay.Text = "نمایش رزرو ها";
            this.btnreservedisplay.UseVisualStyleBackColor = true;
            this.btnreservedisplay.Click += new System.EventHandler(this.btnreservedisplay_Click);
            // 
            // btndeleteall
            // 
            this.btndeleteall.Location = new System.Drawing.Point(675, 320);
            this.btndeleteall.Name = "btndeleteall";
            this.btndeleteall.Size = new System.Drawing.Size(197, 39);
            this.btndeleteall.TabIndex = 20;
            this.btndeleteall.Text = "حذف همه رزرو ها";
            this.btndeleteall.UseVisualStyleBackColor = true;
            this.btndeleteall.Click += new System.EventHandler(this.btndeleteall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btndeleteall);
            this.Controls.Add(this.btnreservedisplay);
            this.Controls.Add(this.mtxtreservefrom);
            this.Controls.Add(this.mtxtreservedate);
            this.Controls.Add(this.txtcustomerid);
            this.Controls.Add(this.mtxtreserveto);
            this.Controls.Add(this.txtreserveid);
            this.Controls.Add(this.txtroomnum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnroomreserve);
            this.Controls.Add(this.btnroomdisplay);
            this.Controls.Add(this.btncustomerdisplay);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "رزرواسیون اتاق";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btncustomerdisplay;
        private System.Windows.Forms.Button btnroomdisplay;
        private System.Windows.Forms.Button btnroomreserve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtroomnum;
        private System.Windows.Forms.TextBox txtreserveid;
        private System.Windows.Forms.MaskedTextBox mtxtreserveto;
        private System.Windows.Forms.TextBox txtcustomerid;
        private System.Windows.Forms.MaskedTextBox mtxtreservedate;
        private System.Windows.Forms.MaskedTextBox mtxtreservefrom;
        private System.Windows.Forms.Button btnreservedisplay;
        private System.Windows.Forms.Button btndeleteall;
    }
}

