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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
            var conn = data.nguoidungs;
            var vt = data.vaiTros;

            try
            {

                var tk = txt_tk.Text;
                var mk = txt_mk.Text;
                var admin = conn.FirstOrDefault(a => a.tendangnhap == tk && a.matkhau == mk );
                var admin1 = vt.FirstOrDefault(u => u.tenVaiTro == "Admin");

                if (admin != null && admin1 != null)
                {


                    this.Hide();
                    Main ac = new Main();
                    ac.ShowDialog();
                    ac = null;
                    this.Show();


                }
                
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            doimk cam = new doimk();
            cam.ShowDialog();
            cam = null;
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
