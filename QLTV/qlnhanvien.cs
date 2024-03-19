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
    public partial class qlnhanvien : Form
    {
        public qlnhanvien()
        {
            InitializeComponent();
        }

        DataClasses1DataContext data = new DataClasses1DataContext();

        

        private void qlnhanvien_Load(object sender, EventArgs e)
        {
            data = new DataClasses1DataContext();
            var quyry = from a in data.nhanviens
                        select new
                        {
                            Mã_Nhân_Viên = a.ma_nhanvien,
                            Tên_Nhân_Viên = a.ten_nhanvien,
                            Số_Điện_Thoại = a.so_dienthoai,
                            Giới_Tính=a.gioitinh,
                            Địa_Chỉ=a.dia_chi

                        };
            data_nv.DataSource = quyry.ToList();
            data_nv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void data_nv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = data_nv.Rows[e.RowIndex];
            txt_mannv.Text = row.Cells["Mã_Nhân_Viên"].Value.ToString();
            txt_mannv.Enabled = false;
            txt_gioitinh.Text = row.Cells["Giới_Tính"].Value.ToString();
            txt_diachi.Text = row.Cells["Địa_Chỉ"].Value.ToString();
            txt_sdt.Text = row.Cells["Số_Điện_Thoại"].Value.ToString();
            txt_tennv.Text = row.Cells["Tên_Nhân_Viên"].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                nhanvien nk = new nhanvien();
              
                nk.ten_nhanvien = txt_tennv.Text.ToString();
                nk.dia_chi = txt_diachi.Text.ToString();
                nk.so_dienthoai = txt_sdt.Text.ToString();
                nk.gioitinh=txt_gioitinh.Text.ToString();
                data.nhanviens.InsertOnSubmit(nk);
                data.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm Thất Bại");
            }
            finally
            {
                var nk = data.nhanviens;
                data_nv.DataSource = nk;
                qlnhanvien_Load(sender, e);
            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                var nk1 = txt_mannv.Text;
                nhanvien edit_nk = data.nhanviens.Where(o => o.ma_nhanvien.Equals(nk1)).FirstOrDefault();
                edit_nk.ten_nhanvien = txt_tennv.Text;
                edit_nk.dia_chi = txt_diachi.Text;
                edit_nk.so_dienthoai = txt_sdt.Text;
                edit_nk.gioitinh = txt_gioitinh.Text;


            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thất bại");
            }
            finally
            {
                var nnk = data.nhanviens;
                data_nv.DataSource = nnk;
                data.SubmitChanges();
                txt_mannv.Enabled = false;
                qlnhanvien_Load(sender, e);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                var nk2 = txt_mannv.Text;
                nhanvien del_nk = data.nhanviens.Where(o => o.ma_nhanvien.Equals(nk2)).FirstOrDefault();
                data.nhanviens.DeleteOnSubmit(del_nk);
                data.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại !");
            }
            finally
            {
                var nk3 = data.nhanviens;
                data_nv.DataSource = nk3;
                
                qlnhanvien_Load(sender, e);
                txt_mannv.Text = "";
                txt_gioitinh.Text = "";
                txt_tennv.Text = "";
                txt_diachi.Text = "";
                txt_sdt.Text = "";
            }
        }

        private void btn_lm_Click(object sender, EventArgs e)
        {
           
            txt_mannv.Text = "";
            txt_gioitinh.Text = "";
            txt_tennv.Text = "";
            txt_diachi.Text = "";
            txt_sdt.Text = "";
            qlnhanvien_Load(sender, e);

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            var a = txt_search.Text;
            var quyry = from ab in data.nhanviens
                        select new
                        {
                            Mã_Nhân_Viên = ab.ma_nhanvien,
                            Tên_Nhân_Viên = ab.ten_nhanvien,
                            Số_Điện_Thoại = ab.so_dienthoai,
                            Giới_Tính = ab.gioitinh,
                            Địa_Chỉ = ab.dia_chi




                        };

            var quyery2 = from k in quyry
                          where k.Tên_Nhân_Viên == a 
                          select k;
            data_nv.DataSource = quyery2.ToList();
        }
    }
}
