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
    public partial class qldausach : Form
    {
        public qldausach()
        {
            InitializeComponent();
        }
        DataClasses1DataContext data = new DataClasses1DataContext();
        private void data_dausach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = data_dausach.Rows[e.RowIndex];
            txt_mads.Text = row.Cells["Mã_Đầu_Sách"].Value.ToString();
            txt_mads.Enabled = false;
            txt_tacgia.Text = row.Cells["Tên_Tác_Giả"].Value.ToString();
            txt_tends.Text = row.Cells["Tên_Đầu_Sách"].Value.ToString();
            txt_sl.Text = row.Cells["Số_Lượng"].Value.ToString();
            txt_theloai.Text = row.Cells["Thể_Loại"].Value.ToString();
            txt_slcl.Text = row.Cells["Số_Lượng_Còn_Lại"].Value.ToString();
        }

        private void qldausach_Load(object sender, EventArgs e)
        {
            data = new DataClasses1DataContext();
            var quyry = from a in data.dausaches
                        select new
                        {
                            Mã_Đầu_Sách = a.ma_dausach,
                            Tên_Đầu_Sách = a.ten_dausach,
                            Số_Lượng = a.so_luong,
                            Tên_Tác_Giả = a.ten_tacgia,
                            Thể_Loại = a.theloai,
                            Số_Lượng_Còn_Lại = a.soluongconlai
                        };
            data_dausach.DataSource = quyry.ToList();
            data_dausach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txt_slcl.Enabled = false;
            txt_mads.Enabled = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                dausach nk = new dausach();

                nk.ten_dausach = txt_tends.Text.ToString();
                nk.so_luong = Convert.ToInt32(txt_sl.Text.ToString());
                nk.ten_tacgia = txt_tacgia.Text.ToString();
                nk.theloai = txt_theloai.Text.ToString();
                nk.soluongconlai = Convert.ToInt32(txt_sl.Text.ToString());
                data.dausaches.InsertOnSubmit(nk);
                data.SubmitChanges();

                for (int i = 0; i < nk.so_luong; i++)
                {
                    sach newSach = new sach();
                    newSach.id_dausach = nk.ma_dausach; 
                    newSach.Trangthai = true; 
                    data.saches.InsertOnSubmit(newSach);
                }

                data.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm Thất Bại");
            }
            finally
            {
                var nk = data.dausaches;
                data_dausach.DataSource = nk;
                qldausach_Load(sender, e);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                var nk1 = txt_mads.Text;
                dausach edit_nk = data.dausaches.Where(o => o.ma_dausach.Equals(nk1)).FirstOrDefault();
                edit_nk.ten_tacgia = txt_tacgia.Text;
                edit_nk.ten_dausach = txt_tends.Text;
                edit_nk.theloai = txt_theloai.Text;
                edit_nk.so_luong = Convert.ToInt32(txt_sl.Text);


            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thất bại");
            }
            finally
            {
                var nnk = data.dausaches;
                data_dausach.DataSource = nnk;
                data.SubmitChanges();
                txt_mads.Enabled = false;
                qldausach_Load(sender, e);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                var nk2 = txt_mads.Text;
                dausach del_nk = data.dausaches.Where(o => o.ma_dausach.Equals(nk2)).FirstOrDefault();
                data.dausaches.DeleteOnSubmit(del_nk);
                data.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại !");
            }
            finally
            {
                var nk3 = data.dausaches;
                data_dausach.DataSource = nk3;
                
                qldausach_Load(sender, e);
                txt_mads.Text = "";
                txt_sl.Text = "";
                txt_tacgia.Text = "";
                txt_tends.Text = "";
                txt_theloai.Text = "";
            }
        }

        private void btn_lm_Click(object sender, EventArgs e)
        {
           
            qldausach_Load(sender, e);
            txt_mads.Text = "";
            txt_sl.Text = "";
            txt_tacgia.Text = "";
            txt_tends.Text = "";
            txt_theloai.Text = "";
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            var a = txt_search.Text;
            var quyry = from ab in data.dausaches
                        select new
                        {
                            Mã_Đầu_Sách = ab.ma_dausach,
                            Tên_Đầu_Sách = ab.ten_dausach,
                            Số_Lượng = ab.so_luong,
                            Tên_Tác_Giả = ab.ten_tacgia,
                            Thể_Loại = ab.theloai
                        };

            var quyery2 = from k in quyry
                          where k.Tên_Đầu_Sách == a
                          select k;
            data_dausach.DataSource = quyery2.ToList();
        }
    }
}
