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
    public partial class qlkhachhang : Form
    {
        public qlkhachhang()
        {
            InitializeComponent();
        }
        DataClasses1DataContext data = new DataClasses1DataContext();
        private void data_kh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = data_kh.Rows[e.RowIndex];
            txt_makh.Text = row.Cells["Mã_Khách_Hàng"].Value.ToString();
            txt_makh.Enabled = false;
 
            txt_sdt.Text = row.Cells["Số_Điện_Thoại"].Value.ToString();
            txt_tenkh.Text = row.Cells["Tên_Khách_Hàng"].Value.ToString();
        }

        private void qlkhachhang_Load(object sender, EventArgs e)
        {
            data = new DataClasses1DataContext();
            var quyry = from a in data.khachhangs
                        select new
                        {
                            Mã_Khách_Hàng = a.ma_khachhang,
                            Tên_Khách_Hàng = a.ten_khachhang,
                            Số_Điện_Thoại = a.so_dienthoai,
                        };
            data_kh.DataSource = quyry.ToList();
            data_kh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                khachhang nk = new khachhang();

                nk.ten_khachhang = txt_tenkh.Text.ToString();
              
                nk.so_dienthoai = txt_sdt.Text.ToString();
              
                data.khachhangs.InsertOnSubmit(nk);
                data.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm Thất Bại");
            }
            finally
            {
                var nk = data.khachhangs;
                data_kh.DataSource = nk;
                qlkhachhang_Load(sender, e);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                var nk1 = txt_makh.Text;
                khachhang edit_nk = data.khachhangs.Where(o => o.ma_khachhang.Equals(nk1)).FirstOrDefault();
                edit_nk.ten_khachhang = txt_tenkh.Text;
               
                edit_nk.so_dienthoai = txt_sdt.Text;
              

            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thất bại");
            }
            finally
            {
                var nnk = data.khachhangs;
                data_kh.DataSource = nnk;
                data.SubmitChanges();
                txt_makh.Enabled = false;
                qlkhachhang_Load(sender, e);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                var nk2 = txt_makh.Text;
                khachhang del_nk = data.khachhangs.Where(o => o.ma_khachhang.Equals(nk2)).FirstOrDefault();
                data.khachhangs.DeleteOnSubmit(del_nk);
                data.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại !");
            }
            finally
            {
                var nk3 = data.khachhangs;
                data_kh.DataSource = nk3;
                txt_makh.Enabled = true;
                qlkhachhang_Load(sender, e);
                txt_makh.Text = "";
               
                txt_tenkh.Text = "";
                txt_sdt.Text = "";
            }
        }

        private void btn_lm_Click(object sender, EventArgs e)
        {
            txt_makh.Text = "";
            txt_makh.Enabled = true;
            txt_tenkh.Text = "";
            txt_sdt.Text = "";
            qlkhachhang_Load(sender, e);
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            var a = txt_search.Text;
            var quyry = from ab in data.khachhangs
                        select new
                        {
                            Mã_Khách_Hàng = ab.ma_khachhang,
                            Tên_Khách_Hàng = ab.ten_khachhang,
                            Số_Điện_Thoại = ab.so_dienthoai,
                        };

            var quyery2 = from k in quyry
                          where k.Tên_Khách_Hàng == a
                          select k;
            data_kh.DataSource = quyery2.ToList();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
