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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void quảnLíNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            qlnhanvien cam = new qlnhanvien();
            cam.ShowDialog();
            cam = null;
            this.Show();
        }

        private void quảnLíKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            qlkhachhang cam = new qlkhachhang();
            cam.ShowDialog();
            cam = null;
            this.Show();
        }

        private void quảnLíĐầuSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            qldausach cam = new qldausach();
            cam.ShowDialog();
            cam = null;
            this.Show();
        }

        private void quảnLíSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            qlsach cam = new qlsach();
            cam.ShowDialog();
            cam = null;
            this.Show();
        }

        private void quảnLíHóaĐơnMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            qlhoadonmuon cam = new qlhoadonmuon();
            cam.ShowDialog();
            cam = null;
            this.Show();
        }

        private void quảnLíHóaĐơnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            qlhoadontra cam = new qlhoadontra();
            cam.ShowDialog();
            cam = null;
            this.Show();
        }
    }
}
