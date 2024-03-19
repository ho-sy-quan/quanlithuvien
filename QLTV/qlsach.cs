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
    public partial class qlsach : Form
    {
        public qlsach()
        {
            InitializeComponent();
        }
        DataClasses1DataContext data= new DataClasses1DataContext();
        private void qlsach_Load(object sender, EventArgs e)
        {
            data = new DataClasses1DataContext();
            var quyry = from a in data.saches
                        join b in data.dausaches on a.id_dausach equals b.ma_dausach
                        select new
                        {
                            Mã_Đầu_Sách = b.ma_dausach,
                            Mã_Sách = a.id_sach,
                            Tên_Đầu_Sách = b.ten_dausach,
                            Số_Lượng = b.so_luong,
                            Tên_Tác_Giả = b.ten_tacgia,
                            Thể_Loại = b.theloai,
                            Số_Lượng_Còn_Lại = b.soluongconlai,
                            Trạng_Thái = a.Trangthai
                        };
            data_sach.DataSource = quyry.ToList();
            data_sach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txt_masach.Enabled = false;
        }

        private void data_sach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = data_sach.Rows[e.RowIndex];
            txt_masach.Text = row.Cells["Mã_Sách"].Value.ToString();
            txt_masach.Enabled = false;
            txt_dausach2.Text = row.Cells["Mã_Đầu_Sách"].Value.ToString();
            txt_trangthai.Text = row.Cells["Trạng_Thái"].Value.ToString();
           

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {

                sach nk = new sach();

                nk.id_dausach = Convert.ToInt32(txt_dausach2.Text.ToString());
                nk.Trangthai = Convert.ToBoolean(txt_trangthai.Text.Trim());
                data.saches.InsertOnSubmit(nk);
                data.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm Thất Bại");
            }
            finally
            {
                var nk = data.saches;
                data_sach.DataSource = nk;
                qlsach_Load(sender, e);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                var nk1 = txt_masach.Text;
                sach edit_nk = data.saches.Where(o => o.id_sach.Equals(nk1)).FirstOrDefault();
                edit_nk.id_dausach = Convert.ToInt32(txt_dausach2.Text.ToString());
                edit_nk.Trangthai = Convert.ToBoolean(txt_trangthai.Text.Trim());


                bool trangThaiTruoc = Convert.ToBoolean(edit_nk.Trangthai);
                if (edit_nk.Trangthai != trangThaiTruoc)
                {
                    
                    if(edit_nk.Trangthai == false && trangThaiTruoc == true)
                    {
                        var dausach = data.dausaches.FirstOrDefault(ds => ds.ma_dausach == edit_nk.id_dausach);
                        if (dausach != null)
                        {
                            dausach.soluongconlai--;
                        }
                    }
                    if(edit_nk.Trangthai == true && trangThaiTruoc == false)
                    {
                        var dausach = data.dausaches.FirstOrDefault(ds => ds.ma_dausach == edit_nk.id_dausach);
                        if (dausach != null)
                        {
                            dausach.soluongconlai++;
                        }
                    }
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thất bại");
            }
            finally
            {
                var nnk = data.saches;
                data_sach.DataSource = nnk;
                data.SubmitChanges();
                qlsach_Load(sender, e);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                var nk2 = txt_masach.Text;
                sach del_nk = data.saches.Where(o => o.id_sach.Equals(nk2)).FirstOrDefault();
                data.saches.DeleteOnSubmit(del_nk);
                data.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại !");
            }
            finally
            {
                var nk3 = data.saches;
                data_sach.DataSource = nk3;

                qlsach_Load(sender, e);
                txt_masach.Text = "";
                txt_dausach2.Text = "";
                txt_trangthai.Text = "";
                txt_search.Text = "";
                
            }
        }

        private void btn_lm_Click(object sender, EventArgs e)
        {
            qlsach_Load(sender, e);
            txt_masach.Text = "";
            txt_dausach2.Text = "";
            txt_trangthai.Text = "";
            txt_search.Text = "";
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            var c = txt_search.Text;
            var quyry = from a in data.saches
                        join b in data.dausaches on a.id_dausach equals b.ma_dausach
                        select new
                        {
                            Mã_Đầu_Sách = b.ma_dausach,
                            Mã_Sách = a.id_sach,
                            Tên_Đầu_Sách = b.ten_dausach,
                            Số_Lượng = b.so_luong,
                            Tên_Tác_Giả = b.ten_tacgia,
                            Thể_Loại = b.theloai,
                            Số_Lượng_Còn_Lại = b.soluongconlai,
                            Trạng_Thái = a.Trangthai
                        };

            var quyery2 = from k in quyry
                          where k.Tên_Đầu_Sách == c
                          select k;
            data_sach.DataSource = quyery2.ToList();
        }
    }
}
