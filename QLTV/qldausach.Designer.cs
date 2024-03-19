namespace QLTV
{
    partial class qldausach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(qldausach));
            this.txt_tacgia = new System.Windows.Forms.TextBox();
            this.data_dausach = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_sl = new System.Windows.Forms.TextBox();
            this.txt_theloai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tends = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mads = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_slcl = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.ToolStripLabel();
            this.btn_sua = new System.Windows.Forms.ToolStripLabel();
            this.btn_xoa = new System.Windows.Forms.ToolStripLabel();
            this.btn_lm = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.data_dausach)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_tacgia
            // 
            this.txt_tacgia.Location = new System.Drawing.Point(560, 144);
            this.txt_tacgia.Name = "txt_tacgia";
            this.txt_tacgia.Size = new System.Drawing.Size(233, 22);
            this.txt_tacgia.TabIndex = 69;
            // 
            // data_dausach
            // 
            this.data_dausach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_dausach.Location = new System.Drawing.Point(0, 227);
            this.data_dausach.Name = "data_dausach";
            this.data_dausach.RowHeadersWidth = 51;
            this.data_dausach.RowTemplate.Height = 24;
            this.data_dausach.Size = new System.Drawing.Size(832, 222);
            this.data_dausach.TabIndex = 57;
            this.data_dausach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_dausach_CellClick);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(422, 189);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(373, 24);
            this.txt_search.TabIndex = 59;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "Tác Giả:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(453, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 67;
            this.label8.Text = "Số Lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 68;
            this.label6.Text = "Tên Thể Loại:";
            // 
            // txt_sl
            // 
            this.txt_sl.Location = new System.Drawing.Point(558, 71);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(235, 22);
            this.txt_sl.TabIndex = 65;
            // 
            // txt_theloai
            // 
            this.txt_theloai.Location = new System.Drawing.Point(560, 106);
            this.txt_theloai.Name = "txt_theloai";
            this.txt_theloai.Size = new System.Drawing.Size(235, 22);
            this.txt_theloai.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 64;
            this.label5.Text = "Tên Sách:";
            // 
            // txt_tends
            // 
            this.txt_tends.Location = new System.Drawing.Point(184, 124);
            this.txt_tends.Name = "txt_tends";
            this.txt_tends.Size = new System.Drawing.Size(188, 22);
            this.txt_tends.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 62;
            this.label4.Text = "Mã Đầu Sách";
            // 
            // txt_mads
            // 
            this.txt_mads.Location = new System.Drawing.Point(184, 86);
            this.txt_mads.Name = "txt_mads";
            this.txt_mads.Size = new System.Drawing.Size(188, 22);
            this.txt_mads.TabIndex = 61;
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
            this.toolStrip1.Size = new System.Drawing.Size(832, 25);
            this.toolStrip1.TabIndex = 60;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 67);
            this.label3.TabIndex = 56;
            this.label3.Text = "   ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 55;
            this.label1.Text = "Quản Lí Đầu Sách";
            // 
            // txt_slcl
            // 
            this.txt_slcl.Location = new System.Drawing.Point(184, 162);
            this.txt_slcl.Name = "txt_slcl";
            this.txt_slcl.Size = new System.Drawing.Size(188, 22);
            this.txt_slcl.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 16);
            this.label9.TabIndex = 64;
            this.label9.Text = "Số Lượng Còn Lại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(369, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 25);
            this.label7.TabIndex = 58;
            this.label7.Text = "       ";
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
            // qldausach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 452);
            this.Controls.Add(this.txt_tacgia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.data_dausach);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_sl);
            this.Controls.Add(this.txt_theloai);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_slcl);
            this.Controls.Add(this.txt_tends);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_mads);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "qldausach";
            this.Text = "qldausach";
            this.Load += new System.EventHandler(this.qldausach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_dausach)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel btn_xoa;
        private System.Windows.Forms.ToolStripLabel btn_sua;
        private System.Windows.Forms.ToolStripLabel btn_them;
        private System.Windows.Forms.ToolStripLabel btn_lm;
        private System.Windows.Forms.TextBox txt_tacgia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView data_dausach;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_sl;
        private System.Windows.Forms.TextBox txt_theloai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tends;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mads;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_slcl;
        private System.Windows.Forms.Label label9;
    }
}