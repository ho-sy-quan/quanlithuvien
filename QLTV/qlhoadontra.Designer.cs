namespace QLTV
{
    partial class qlhoadontra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(qlhoadontra));
            this.data_hdtra = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ngaytra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hdtra = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_them = new System.Windows.Forms.ToolStripLabel();
            this.btn_sua = new System.Windows.Forms.ToolStripLabel();
            this.btn_xoa = new System.Windows.Forms.ToolStripLabel();
            this.btn_lm = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_idhdthue = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_hdtra)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_hdtra
            // 
            this.data_hdtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_hdtra.Location = new System.Drawing.Point(24, 238);
            this.data_hdtra.Name = "data_hdtra";
            this.data_hdtra.RowHeadersWidth = 51;
            this.data_hdtra.RowTemplate.Height = 24;
            this.data_hdtra.Size = new System.Drawing.Size(773, 213);
            this.data_hdtra.TabIndex = 73;
            this.data_hdtra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_hdtra_CellClick);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(422, 200);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(373, 24);
            this.txt_search.TabIndex = 75;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 81;
            this.label9.Text = "ID Hóa Đơn Thuê";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 82;
            this.label5.Text = "Ngày Trả";
            // 
            // txt_ngaytra
            // 
            this.txt_ngaytra.Location = new System.Drawing.Point(184, 135);
            this.txt_ngaytra.Name = "txt_ngaytra";
            this.txt_ngaytra.Size = new System.Drawing.Size(188, 22);
            this.txt_ngaytra.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 78;
            this.label4.Text = "ID Hóa Đơn Trả";
            // 
            // txt_hdtra
            // 
            this.txt_hdtra.Location = new System.Drawing.Point(184, 97);
            this.txt_hdtra.Name = "txt_hdtra";
            this.txt_hdtra.Size = new System.Drawing.Size(188, 22);
            this.txt_hdtra.TabIndex = 77;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_them,
            this.btn_sua,
            this.btn_xoa,
            this.btn_lm,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 76;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_them
            // 
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(66, 22);
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(54, 22);
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(55, 22);
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_lm
            // 
            this.btn_lm.Image = ((System.Drawing.Image)(resources.GetObject("btn_lm.Image")));
            this.btn_lm.Name = "btn_lm";
            this.btn_lm.Size = new System.Drawing.Size(87, 22);
            this.btn_lm.Text = "Làm Mới";
            this.btn_lm.Click += new System.EventHandler(this.btn_lm_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(71, 22);
            this.toolStripLabel1.Text = "Trở Về";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 67);
            this.label3.TabIndex = 72;
            this.label3.Text = "   ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 71;
            this.label1.Text = "Quản Lí Hóa Đơn Trả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(369, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 25);
            this.label7.TabIndex = 74;
            this.label7.Text = "       ";
            // 
            // txt_idhdthue
            // 
            this.txt_idhdthue.FormattingEnabled = true;
            this.txt_idhdthue.Location = new System.Drawing.Point(184, 186);
            this.txt_idhdthue.Name = "txt_idhdthue";
            this.txt_idhdthue.Size = new System.Drawing.Size(121, 24);
            this.txt_idhdthue.TabIndex = 83;
            // 
            // qlhoadontra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_idhdthue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.data_hdtra);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ngaytra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_hdtra);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "qlhoadontra";
            this.Text = "qlhoadontra";
            this.Load += new System.EventHandler(this.qlhoadontra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_hdtra)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView data_hdtra;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripLabel btn_them;
        private System.Windows.Forms.ToolStripLabel btn_sua;
        private System.Windows.Forms.ToolStripLabel btn_xoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ngaytra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_hdtra;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel btn_lm;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txt_idhdthue;
    }
}