using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bt_17_10_4._10
{
    public partial class Form1 : Form
    {
        // Danh sách gốc chứa tất cả các phiếu
        private BindingList<EquipmentCheckout> masterList = new BindingList<EquipmentCheckout>();
        // BindingSource trung gian cho DataGridView
        private BindingSource bsCheckouts = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoGiaoDienDatagridView();
            KhoiTaoDuLieuMau();

            cboFilterStatus.SelectedIndex = 0; // "Tất cả"
            bsCheckouts.DataSource = masterList;
            dgvCheckouts.DataSource = bsCheckouts;

            CapNhatThongKeStatusStrip();
        }

        // 1. Cấu hình cột DataGridView bằng code thủ công
        private void KhoiTaoGiaoDienDatagridView()
        {
            dgvCheckouts.AutoGenerateColumns = false;
            dgvCheckouts.Columns.Clear();

            dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CheckoutId", HeaderText = "Mã Phiếu", Width = 90 });
            dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StudentId", HeaderText = "Mã SV", Width = 90 });
            dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StudentName", HeaderText = "Tên Sinh Viên", Width = 150 });
            dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "EquipmentName", HeaderText = "Thiết Bị", Width = 130 });
            dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity", HeaderText = "Số Lượng", Width = 80 });

            var colBorrowDate = new DataGridViewTextBoxColumn { DataPropertyName = "BorrowDate", HeaderText = "Ngày Mượn", Width = 100 };
            colBorrowDate.DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvCheckouts.Columns.Add(colBorrowDate);

            var colDueDate = new DataGridViewTextBoxColumn { DataPropertyName = "DueDate", HeaderText = "Hạn Trả", Width = 100 };
            colDueDate.DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvCheckouts.Columns.Add(colDueDate);

            var colReturnDate = new DataGridViewTextBoxColumn { DataPropertyName = "ReturnDate", HeaderText = "Ngày Trả TT", Width = 100 };
            colReturnDate.DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvCheckouts.Columns.Add(colReturnDate);

            dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Condition", HeaderText = "Tình Trạng Thiết Bị", Width = 120 });
            dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Trạng Thái Phiếu", Width = 110 });

            // Nạp danh sách thiết bị mẫu vào ComboBox
            cboEquipment.Items.AddRange(new string[] {
                "Kính hiển vi quang học",
                "Máy dao động sóng (Oscilloscope)",
                "Bộ lập trình PLC Siemens",
                "Bộ kit Arduino Uno R3",
                "Máy đo vạn năng VOM",
                "Cảm biến nhiệt độ công nghiệp"
            });
            cboEquipment.SelectedIndex = 0;
        }

        // 2. Dữ liệu thử nghiệm
        private void KhoiTaoDuLieuMau()
        {
            masterList.Add(new EquipmentCheckout("PM001", "SV101", "Nguyễn Văn An", "Kính hiển vi quang học", 1, DateTime.Today.AddDays(-10), DateTime.Today.AddDays(-3), null, "Tốt")); // Quá hạn
            masterList.Add(new EquipmentCheckout("PM002", "SV102", "Trần Thị Bích", "Bộ kit Arduino Uno R3", 2, DateTime.Today.AddDays(-5), DateTime.Today.AddDays(2), null, "Mới")); // Đang mượn
            masterList.Add(new EquipmentCheckout("PM003", "SV103", "Lê Hoàng Nam", "Máy dao động sóng (Oscilloscope)", 1, DateTime.Today.AddDays(-15), DateTime.Today.AddDays(-8), DateTime.Today.AddDays(-8), "Trầy xước nhẹ")); // Đã trả
        }

        // 3. Hàm kiểm tra hợp lệ dữ liệu (Validate) bằng ErrorProvider
        private bool KiemTraHopLe(bool isUpdate = false)
        {
            epCheck.Clear();
            bool isValid = true;

            // Mã phiếu
            if (string.IsNullOrWhiteSpace(txtCheckoutId.Text))
            {
                epCheck.SetError(txtCheckoutId, "Mã phiếu không được để trống!");
                isValid = false;
            }
            else if (!isUpdate && masterList.Any(p => p.CheckoutId.Equals(txtCheckoutId.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                epCheck.SetError(txtCheckoutId, "Mã phiếu đã tồn tại trong hệ thống!");
                isValid = false;
            }

            // Mã sinh viên
            if (string.IsNullOrWhiteSpace(txtStudentId.Text))
            {
                epCheck.SetError(txtStudentId, "Mã sinh viên không được để trống!");
                isValid = false;
            }

            // Thiết bị
            if (cboEquipment.SelectedItem == null || string.IsNullOrWhiteSpace(cboEquipment.Text))
            {
                epCheck.SetError(cboEquipment, "Vui lòng chọn thiết bị!");
                isValid = false;
            }

            // Số lượng
            if (nudQuantity.Value <= 0)
            {
                epCheck.SetError(nudQuantity, "Số lượng mượn phải lớn hơn 0!");
                isValid = false;
            }

            // Hạn trả không trước ngày mượn
            if (dtpDueDate.Value.Date < dtpBorrowDate.Value.Date)
            {
                epCheck.SetError(dtpDueDate, "Hạn trả không được trước ngày mượn!");
                isValid = false;
            }

            // Ngày trả thực tế (nếu chọn) không trước ngày mượn
            if (chkHasReturnDate.Checked && dtpReturnDate.Value.Date < dtpBorrowDate.Value.Date)
            {
                epCheck.SetError(dtpReturnDate, "Ngày trả thực tế không được trước ngày mượn!");
                isValid = false;
            }

            return isValid;
        }

        // 4. Chức năng THÊM phiếu mượn
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe(isUpdate: false)) return;

            DateTime? returnDate = chkHasReturnDate.Checked ? (DateTime?)dtpReturnDate.Value.Date : null;

            EquipmentCheckout item = new EquipmentCheckout(
                txtCheckoutId.Text.Trim(),
                txtStudentId.Text.Trim(),
                txtStudentName.Text.Trim(),
                cboEquipment.Text,
                (int)nudQuantity.Value,
                dtpBorrowDate.Value,
                dtpDueDate.Value,
                returnDate,
                txtCondition.Text.Trim()
            );

            masterList.Add(item);
            ApDungLocVaTimKiem();
            CapNhatThongKeStatusStrip();
            ClearInputs();
            MessageBox.Show("Thêm phiếu mượn mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 5. Chức năng CẬP NHẬT
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCheckoutId.Text))
            {
                MessageBox.Show("Vui lòng chọn một phiếu từ danh sách để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!KiemTraHopLe(isUpdate: true)) return;

            var target = masterList.FirstOrDefault(p => p.CheckoutId.Equals(txtCheckoutId.Text.Trim(), StringComparison.OrdinalIgnoreCase));
            if (target != null)
            {
                target.StudentId = txtStudentId.Text.Trim();
                target.StudentName = txtStudentName.Text.Trim();
                target.EquipmentName = cboEquipment.Text;
                target.Quantity = (int)nudQuantity.Value;
                target.BorrowDate = dtpBorrowDate.Value.Date;
                target.DueDate = dtpDueDate.Value.Date;
                target.ReturnDate = chkHasReturnDate.Checked ? (DateTime?)dtpReturnDate.Value.Date : null;
                target.Condition = txtCondition.Text.Trim();

                dgvCheckouts.Refresh();
                ApDungLocVaTimKiem();
                CapNhatThongKeStatusStrip();
                ClearInputs();
                MessageBox.Show("Cập nhật thông tin phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 6. Chức năng XÓA (Có MessageBox xác nhận)
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCheckouts.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string checkoutId = txtCheckoutId.Text.Trim();
            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa phiếu mượn [{checkoutId}] không?",
                                              "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                var target = masterList.FirstOrDefault(p => p.CheckoutId.Equals(checkoutId, StringComparison.OrdinalIgnoreCase));
                if (target != null)
                {
                    masterList.Remove(target);
                    ApDungLocVaTimKiem();
                    CapNhatThongKeStatusStrip();
                    ClearInputs();
                    MessageBox.Show("Đã xóa phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // 7. Chức năng ĐÁNH DẤU ĐÃ TRẢ
        private void btnMarkReturned_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCheckoutId.Text))
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn cần đánh dấu đã trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var target = masterList.FirstOrDefault(p => p.CheckoutId.Equals(txtCheckoutId.Text.Trim(), StringComparison.OrdinalIgnoreCase));
            if (target != null)
            {
                if (target.ReturnDate.HasValue)
                {
                    MessageBox.Show("Phiếu này đã được hoàn trả trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                target.ReturnDate = DateTime.Today; // Cập nhật ngày trả thực tế = ngày hiện tại
                dgvCheckouts.Refresh();
                ApDungLocVaTimKiem();
                CapNhatThongKeStatusStrip();
                HienThiDongDangChon(target);
                MessageBox.Show($"Đã đánh dấu trả thiết bị cho phiếu [{target.CheckoutId}] vào ngày {DateTime.Today:dd/MM/yyyy}!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 8. Đẩy dữ liệu dòng chọn lên ô nhập liệu
        private void dgvCheckouts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvCheckouts.Rows.Count)
            {
                var selectedItem = dgvCheckouts.Rows[e.RowIndex].DataBoundItem as EquipmentCheckout;
                if (selectedItem != null)
                {
                    HienThiDongDangChon(selectedItem);
                }
            }
        }

        private void HienThiDongDangChon(EquipmentCheckout item)
        {
            txtCheckoutId.Text = item.CheckoutId;
            txtStudentId.Text = item.StudentId;
            txtStudentName.Text = item.StudentName;
            cboEquipment.Text = item.EquipmentName;
            nudQuantity.Value = item.Quantity;
            dtpBorrowDate.Value = item.BorrowDate;
            dtpDueDate.Value = item.DueDate;
            txtCondition.Text = item.Condition;

            if (item.ReturnDate.HasValue)
            {
                chkHasReturnDate.Checked = true;
                dtpReturnDate.Value = item.ReturnDate.Value;
            }
            else
            {
                chkHasReturnDate.Checked = false;
                dtpReturnDate.Value = DateTime.Today;
            }

            txtCheckoutId.ReadOnly = true; // Không cho phép sửa mã phiếu
        }

        // 9. Lọc và Tìm kiếm dữ liệu động
        private void ApDungLocVaTimKiem()
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            string filterStatus = cboFilterStatus.SelectedItem?.ToString() ?? "Tất cả";

            var filtered = masterList.Where(p =>
            {
                // Lọc theo từ khóa (Mã SV hoặc Tên thiết bị)
                bool matchKeyword = string.IsNullOrEmpty(keyword) ||
                                    p.StudentId.ToLower().Contains(keyword) ||
                                    p.EquipmentName.ToLower().Contains(keyword);

                // Lọc theo Trạng thái
                bool matchStatus = true;
                if (filterStatus == "Đang mượn") matchStatus = (p.Status == "Đang mượn");
                else if (filterStatus == "Quá hạn") matchStatus = (p.Status == "Quá hạn");
                else if (filterStatus == "Đã trả") matchStatus = (p.Status == "Đã trả");

                return matchKeyword && matchStatus;
            }).ToList();

            bsCheckouts.DataSource = new BindingList<EquipmentCheckout>(filtered);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => ApDungLocVaTimKiem();
        private void cboFilterStatus_SelectedIndexChanged(object sender, EventArgs e) => ApDungLocVaTimKiem();

        // 10. Cập nhật StatusStrip
        private void CapNhatThongKeStatusStrip()
        {
            int total = masterList.Count;
            int overdue = masterList.Count(p => p.Status == "Quá hạn");

            lblTotalCount.Text = $"Tổng số phiếu: {total}";
            lblOverdueCount.Text = $"Số phiếu quá hạn: {overdue}";
        }

        // 11. Xuất dữ liệu đang hiển thị ra file CSV
        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            var currentList = bsCheckouts.DataSource as IEnumerable<EquipmentCheckout>;
            if (currentList == null || !currentList.Any())
            {
                MessageBox.Show("Không có dữ liệu để xuất file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "File CSV (*.csv)|*.csv";
                sfd.FileName = $"PhieuMuonThietBi_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Xuất UTF-8 có BOM để Excel không bị lỗi phông tiếng Việt
                        using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                        {
                            sw.WriteLine("Mã Phiếu,Mã SV,Họ Tên SV,Thiết Bị,Số Lượng,Ngày Mượn,Hạn Trả,Ngày Trả TT,Tình Trạng,Trạng Thái");

                            foreach (var item in currentList)
                            {
                                string returnDateStr = item.ReturnDate.HasValue ? item.ReturnDate.Value.ToString("dd/MM/yyyy") : "";
                                string line = $"\"{item.CheckoutId}\",\"{item.StudentId}\",\"{item.StudentName}\",\"{item.EquipmentName}\",{item.Quantity},\"{item.BorrowDate:dd/MM/yyyy}\",\"{item.DueDate:dd/MM/yyyy}\",\"{returnDateStr}\",\"{item.Condition}\",\"{item.Status}\"";
                                sw.WriteLine(line);
                            }
                        }
                        MessageBox.Show("Xuất danh sách ra file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void chkHasReturnDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpReturnDate.Enabled = chkHasReturnDate.Checked;
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearInputs();

        private void ClearInputs()
        {
            txtCheckoutId.Clear();
            txtStudentId.Clear();
            txtStudentName.Clear();
            if (cboEquipment.Items.Count > 0) cboEquipment.SelectedIndex = 0;
            nudQuantity.Value = 1;
            dtpBorrowDate.Value = DateTime.Today;
            dtpDueDate.Value = DateTime.Today.AddDays(7);
            chkHasReturnDate.Checked = false;
            dtpReturnDate.Value = DateTime.Today;
            txtCondition.Text = "Tốt";

            txtCheckoutId.ReadOnly = false;
            epCheck.Clear();
            txtCheckoutId.Focus();
        }
    }
}