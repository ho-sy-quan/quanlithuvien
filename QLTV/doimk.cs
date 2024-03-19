using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class doimk : Form
    { 
        public doimk()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
            var conn = data.nguoidungs;
            var vt = data.vaiTros;

            try
            {

                var tk = txt_tk2.Text;
                var mk = txt_mkcu.Text;
                var mkmoi = txt_mkmoi.Text;
                var admin = conn.FirstOrDefault(a => a.tendangnhap == tk && a.matkhau == mk);
                var admin1 = vt.FirstOrDefault(u => u.tenVaiTro == "Admin");

                if (admin != null && admin1 != null)
                {

                    admin.matkhau = mkmoi;
                    data.SubmitChanges();

                    MessageBox.Show("Đổi mật khẩu thành công!");
                    this.Hide();
                    Form1 cam = new Form1();
                    cam.ShowDialog();
                    cam = null;
                    this.Show();



                }

                else
                {
                    MessageBox.Show("Đổi không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!");
            }
        }
    }
}
