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
    public partial class qlhoadonmuon : Form
    {
        public qlhoadonmuon()
        {
            InitializeComponent();
        }
        DataClasses1DataContext data = new DataClasses1DataContext();
        private void qlhoadonmuon_Load(object sender, EventArgs e)
        {
            data = new DataClasses1DataContext();
            var quyry = from a in data.hoadon_thues
                        join b in data.dausaches on a.id_dausach equals b.ma_dausach
                        join c in data.khachhangs on a.id_khachhang equals c.ma_khachhang
                        select new
                        {
                            Mã_Hóa_Đơn_Thuê = a.id_hoadon_thue,
                            Ngày_Thuê=a.ngay_thue,
                            Tên_Đầu_Sách = b.ten_dausach,
                            Tên_Khách_Hàng =c.ten_khachhang,
                            Giá_Thuê=a.gia_thue,
                            Tiền_Cọc=a.tien_coc
                        };

            cbo_tendausach.DataSource = data.dausaches;
            cbo_tendausach.DisplayMember = "ten_dausach";
            cbo_tendausach.ValueMember = "ma_dausach";

            cbo_tenkh.DataSource = data.khachhangs;
            cbo_tenkh.DisplayMember = "ten_khachhang";
            cbo_tenkh.ValueMember = "ma_khachhang";


            data_hdthue.DataSource = quyry.ToList();
            data_hdthue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txt_hdthue.Enabled = false;
            

        }

        private void data_hdthue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = data_hdthue.Rows[e.RowIndex];
            txt_hdthue.Text = row.Cells["Mã_Hóa_Đơn_Thuê"].Value.ToString();
            txt_hdthue.Enabled = false;
            txt_giathue.Text = row.Cells["Giá_Thuê"].Value.ToString();
            txt_ngaythue.Text = row.Cells["Ngày_Thuê"].Value.ToString();
            txt_tiencoc.Text = row.Cells["Tiền_Cọc"].Value.ToString();
            cbo_tenkh.Text = row.Cells["Tên_Khách_Hàng"].Value.ToString();
            cbo_tendausach.Text = row.Cells["Tên_Đầu_Sách"].Value.ToString();
           
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                DataClasses1DataContext data = new DataClasses1DataContext();
                hoadon_thue nk = new hoadon_thue();
                var a = (from ass in data.khachhangs
                         where ass.ten_khachhang == cbo_tenkh.Text
                         select ass.ma_khachhang).FirstOrDefault();

                nk.id_khachhang = a;

                var b = (from ass in data.dausaches
                         where ass.ten_dausach == cbo_tendausach.Text
                         select ass.ma_dausach).FirstOrDefault();

                nk.id_dausach = b;

                nk.ngay_thue = Convert.ToDateTime(txt_ngaythue.Text.ToString());
                nk.gia_thue = Convert.ToSingle(txt_giathue.Text.Trim());
                nk.tien_coc = Convert.ToSingle(txt_tiencoc.Text.Trim());
                data.hoadon_thues.InsertOnSubmit(nk);
                data.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại: " + ex.Message);
            }
            finally
            {
                var nk = data.hoadon_thues;
                data_hdthue.DataSource = nk;
                qlhoadonmuon_Load(sender, e);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                var nk1 = txt_hdthue.Text;
                hoadon_thue edit_nk = data.hoadon_thues.Where(o => o.id_hoadon_thue.Equals(nk1)).FirstOrDefault();
                var a = (from ass in data.khachhangs
                         where ass.ten_khachhang == cbo_tenkh.Text
                         select ass.ma_khachhang).FirstOrDefault();

                edit_nk.id_khachhang = a;

                var b = (from ass in data.dausaches
                         where ass.ten_dausach == cbo_tendausach.Text
                         select ass.ma_dausach).FirstOrDefault();

                edit_nk.id_dausach = b;

                edit_nk.ngay_thue = Convert.ToDateTime(txt_ngaythue.Text.ToString());
                edit_nk.gia_thue = Convert.ToSingle(txt_giathue.Text.Trim());
                edit_nk.tien_coc = Convert.ToSingle(txt_tiencoc.Text.Trim());


            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thất bại");
            }
            finally
            {
                var nnk = data.hoadon_thues;
                data_hdthue.DataSource = nnk;
                data.SubmitChanges();
                qlhoadonmuon_Load(sender, e);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                var nk2 = txt_hdthue.Text;
                hoadon_thue del_nk = data.hoadon_thues.Where(o => o.id_hoadon_thue.Equals(nk2)).FirstOrDefault();
                data.hoadon_thues.DeleteOnSubmit(del_nk);
                data.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại !");
            }
            finally
            {
                var nk3 = data.hoadon_thues;
                data_hdthue.DataSource = nk3;

                qlhoadonmuon_Load(sender, e);
                txt_giathue.Text = "";
                txt_hdthue.Text = "";
                txt_ngaythue.Text = "";
                txt_search.Text = "";
                txt_tiencoc.Text = "";
                cbo_tendausach.Text = "";
                cbo_tenkh.Text = "";

            }
        }

        private void btn_lm_Click(object sender, EventArgs e)
        {
            qlhoadonmuon_Load(sender, e);
            txt_giathue.Text = "";
            txt_hdthue.Text = "";
            txt_ngaythue.Text = "";
            txt_search.Text = "";
            txt_tiencoc.Text = "";
            cbo_tendausach.Text = "";
            cbo_tenkh.Text = "";
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            var d = txt_search.Text;
            var quyry = from a in data.hoadon_thues
                        join b in data.dausaches on a.id_dausach equals b.ma_dausach
                        join c in data.khachhangs on a.id_khachhang equals c.ma_khachhang
                        select new
                        {
                            Mã_Hóa_Đơn_Thuê = a.id_hoadon_thue,
                            Ngày_Thuê = a.ngay_thue,
                            Tên_Đầu_Sách = b.ten_dausach,
                            Tên_Khách_Hàng = c.ten_khachhang,
                            Giá_Thuê = a.gia_thue,
                            Tiền_Cọc = a.tien_coc
                        };

            var quyery2 = from k in quyry
                          where k.Tên_Khách_Hàng == d
                          select k;
            data_hdthue.DataSource = quyery2.ToList();
        }
    }
}
