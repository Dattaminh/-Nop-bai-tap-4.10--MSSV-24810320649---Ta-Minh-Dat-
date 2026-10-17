namespace bt_17_10_4._10
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grpInput = new GroupBox();
            txtCondition = new TextBox();
            lblCondition = new Label();
            chkHasReturnDate = new CheckBox();
            dtpReturnDate = new DateTimePicker();
            lblReturnDate = new Label();
            dtpDueDate = new DateTimePicker();
            lblDueDate = new Label();
            dtpBorrowDate = new DateTimePicker();
            lblBorrowDate = new Label();
            nudQuantity = new NumericUpDown();
            lblQuantity = new Label();
            cboEquipment = new ComboBox();
            lblEquipment = new Label();
            txtStudentName = new TextBox();
            lblStudentName = new Label();
            txtStudentId = new TextBox();
            lblStudentId = new Label();
            txtCheckoutId = new TextBox();
            lblCheckoutId = new Label();
            grpActions = new GroupBox();
            btnMarkReturned = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            grpFilter = new GroupBox();
            btnExportCsv = new Button();
            cboFilterStatus = new ComboBox();
            lblFilterStatus = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvCheckouts = new DataGridView();
            statusStrip1 = new StatusStrip();
            lblTotalCount = new ToolStripStatusLabel();
            lblOverdueCount = new ToolStripStatusLabel();
            epCheck = new ErrorProvider(components);
            grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            grpActions.SuspendLayout();
            grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCheckouts).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epCheck).BeginInit();
            SuspendLayout();
            // 
            // grpInput
            // 
            grpInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpInput.Controls.Add(txtCondition);
            grpInput.Controls.Add(lblCondition);
            grpInput.Controls.Add(chkHasReturnDate);
            grpInput.Controls.Add(dtpReturnDate);
            grpInput.Controls.Add(lblReturnDate);
            grpInput.Controls.Add(dtpDueDate);
            grpInput.Controls.Add(lblDueDate);
            grpInput.Controls.Add(dtpBorrowDate);
            grpInput.Controls.Add(lblBorrowDate);
            grpInput.Controls.Add(nudQuantity);
            grpInput.Controls.Add(lblQuantity);
            grpInput.Controls.Add(cboEquipment);
            grpInput.Controls.Add(lblEquipment);
            grpInput.Controls.Add(txtStudentName);
            grpInput.Controls.Add(lblStudentName);
            grpInput.Controls.Add(txtStudentId);
            grpInput.Controls.Add(lblStudentId);
            grpInput.Controls.Add(txtCheckoutId);
            grpInput.Controls.Add(lblCheckoutId);
            grpInput.Location = new Point(12, 12);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(810, 180);
            grpInput.TabIndex = 0;
            grpInput.TabStop = false;
            grpInput.Text = "Thông tin phiếu mượn thiết bị";
            // 
            // txtCondition
            // 
            txtCondition.Location = new Point(620, 135);
            txtCondition.Name = "txtCondition";
            txtCondition.Size = new Size(165, 27);
            txtCondition.TabIndex = 18;
            txtCondition.Text = "Tốt";
            // 
            // lblCondition
            // 
            lblCondition.AutoSize = true;
            lblCondition.Location = new Point(535, 138);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(79, 20);
            lblCondition.TabIndex = 17;
            lblCondition.Text = "Tình trạng:";
            // 
            // chkHasReturnDate
            // 
            chkHasReturnDate.AutoSize = true;
            chkHasReturnDate.Location = new Point(515, 100);
            chkHasReturnDate.Name = "chkHasReturnDate";
            chkHasReturnDate.Size = new Size(18, 17);
            chkHasReturnDate.TabIndex = 16;
            chkHasReturnDate.UseVisualStyleBackColor = true;
            chkHasReturnDate.CheckedChanged += chkHasReturnDate_CheckedChanged;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.CustomFormat = "dd/MM/yyyy";
            dtpReturnDate.Enabled = false;
            dtpReturnDate.Format = DateTimePickerFormat.Custom;
            dtpReturnDate.Location = new Point(365, 135);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(140, 27);
            dtpReturnDate.TabIndex = 15;
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Location = new Point(270, 138);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(93, 20);
            lblReturnDate.TabIndex = 14;
            lblReturnDate.Text = "Ngày trả TT:";
            // 
            // dtpDueDate
            // 
            dtpDueDate.CustomFormat = "dd/MM/yyyy";
            dtpDueDate.Format = DateTimePickerFormat.Custom;
            dtpDueDate.Location = new Point(365, 95);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(140, 27);
            dtpDueDate.TabIndex = 13;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(270, 98);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(61, 20);
            lblDueDate.TabIndex = 12;
            lblDueDate.Text = "Hạn trả:";
            // 
            // dtpBorrowDate
            // 
            dtpBorrowDate.CustomFormat = "dd/MM/yyyy";
            dtpBorrowDate.Format = DateTimePickerFormat.Custom;
            dtpBorrowDate.Location = new Point(365, 55);
            dtpBorrowDate.Name = "dtpBorrowDate";
            dtpBorrowDate.Size = new Size(140, 27);
            dtpBorrowDate.TabIndex = 11;
            // 
            // lblBorrowDate
            // 
            lblBorrowDate.AutoSize = true;
            lblBorrowDate.Location = new Point(270, 58);
            lblBorrowDate.Name = "lblBorrowDate";
            lblBorrowDate.Size = new Size(89, 20);
            lblBorrowDate.TabIndex = 10;
            lblBorrowDate.Text = "Ngày mượn:";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(105, 135);
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(140, 27);
            nudQuantity.TabIndex = 9;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(15, 138);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(72, 20);
            lblQuantity.TabIndex = 8;
            lblQuantity.Text = "Số lượng:";
            // 
            // cboEquipment
            // 
            cboEquipment.FormattingEnabled = true;
            cboEquipment.Location = new Point(105, 95);
            cboEquipment.Name = "cboEquipment";
            cboEquipment.Size = new Size(140, 28);
            cboEquipment.TabIndex = 7;
            // 
            // lblEquipment
            // 
            lblEquipment.AutoSize = true;
            lblEquipment.Location = new Point(15, 98);
            lblEquipment.Name = "lblEquipment";
            lblEquipment.Size = new Size(63, 20);
            lblEquipment.TabIndex = 6;
            lblEquipment.Text = "Thiết bị:";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(365, 20);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(140, 27);
            txtStudentName.TabIndex = 5;
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Location = new Point(270, 23);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(57, 20);
            lblStudentName.TabIndex = 4;
            lblStudentName.Text = "Tên SV:";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(105, 55);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(140, 27);
            txtStudentId.TabIndex = 3;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(15, 58);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(54, 20);
            lblStudentId.TabIndex = 2;
            lblStudentId.Text = "Mã SV:";
            // 
            // txtCheckoutId
            // 
            txtCheckoutId.Location = new Point(105, 20);
            txtCheckoutId.Name = "txtCheckoutId";
            txtCheckoutId.Size = new Size(140, 27);
            txtCheckoutId.TabIndex = 1;
            // 
            // lblCheckoutId
            // 
            lblCheckoutId.AutoSize = true;
            lblCheckoutId.Location = new Point(15, 23);
            lblCheckoutId.Name = "lblCheckoutId";
            lblCheckoutId.Size = new Size(74, 20);
            lblCheckoutId.TabIndex = 0;
            lblCheckoutId.Text = "Mã phiếu:";
            // 
            // grpActions
            // 
            grpActions.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            grpActions.Controls.Add(btnMarkReturned);
            grpActions.Controls.Add(btnClear);
            grpActions.Controls.Add(btnDelete);
            grpActions.Controls.Add(btnUpdate);
            grpActions.Controls.Add(btnAdd);
            grpActions.Location = new Point(830, 12);
            grpActions.Name = "grpActions";
            grpActions.Size = new Size(140, 245);
            grpActions.TabIndex = 1;
            grpActions.TabStop = false;
            grpActions.Text = "Thao tác";
            // 
            // btnMarkReturned
            // 
            btnMarkReturned.BackColor = Color.LightGreen;
            btnMarkReturned.Location = new Point(10, 195);
            btnMarkReturned.Name = "btnMarkReturned";
            btnMarkReturned.Size = new Size(120, 35);
            btnMarkReturned.TabIndex = 4;
            btnMarkReturned.Text = "Đánh Dấu Trả";
            btnMarkReturned.UseVisualStyleBackColor = false;
            btnMarkReturned.Click += btnMarkReturned_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(10, 155);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 35);
            btnClear.TabIndex = 3;
            btnClear.Text = "Làm Mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(10, 110);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 35);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa Phiếu";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(10, 68);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 35);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Cập Nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(10, 25);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 35);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm Mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // grpFilter
            // 
            grpFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpFilter.Controls.Add(btnExportCsv);
            grpFilter.Controls.Add(cboFilterStatus);
            grpFilter.Controls.Add(lblFilterStatus);
            grpFilter.Controls.Add(txtSearch);
            grpFilter.Controls.Add(lblSearch);
            grpFilter.Location = new Point(12, 195);
            grpFilter.Name = "grpFilter";
            grpFilter.Size = new Size(810, 62);
            grpFilter.TabIndex = 2;
            grpFilter.TabStop = false;
            grpFilter.Text = "Tìm kiếm & Lọc";
            // 
            // btnExportCsv
            // 
            btnExportCsv.Location = new Point(640, 20);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(145, 30);
            btnExportCsv.TabIndex = 4;
            btnExportCsv.Text = "Xuất CSV";
            btnExportCsv.UseVisualStyleBackColor = true;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // cboFilterStatus
            // 
            cboFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterStatus.FormattingEnabled = true;
            cboFilterStatus.Items.AddRange(new object[] { "Tất cả", "Đang mượn", "Quá hạn", "Đã trả" });
            cboFilterStatus.Location = new Point(475, 21);
            cboFilterStatus.Name = "cboFilterStatus";
            cboFilterStatus.Size = new Size(140, 28);
            cboFilterStatus.TabIndex = 3;
            cboFilterStatus.SelectedIndexChanged += cboFilterStatus_SelectedIndexChanged;
            // 
            // lblFilterStatus
            // 
            lblFilterStatus.AutoSize = true;
            lblFilterStatus.Location = new Point(390, 25);
            lblFilterStatus.Name = "lblFilterStatus";
            lblFilterStatus.Size = new Size(78, 20);
            lblFilterStatus.TabIndex = 2;
            lblFilterStatus.Text = "Trạng thái:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(105, 22);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(250, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(15, 25);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(73, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm kiếm:";
            // 
            // dgvCheckouts
            // 
            dgvCheckouts.AllowUserToAddRows = false;
            dgvCheckouts.AllowUserToDeleteRows = false;
            dgvCheckouts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCheckouts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCheckouts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckouts.Location = new Point(12, 265);
            dgvCheckouts.MultiSelect = false;
            dgvCheckouts.Name = "dgvCheckouts";
            dgvCheckouts.ReadOnly = true;
            dgvCheckouts.RowHeadersWidth = 51;
            dgvCheckouts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCheckouts.Size = new Size(958, 275);
            dgvCheckouts.TabIndex = 3;
            dgvCheckouts.CellClick += dgvCheckouts_CellClick;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTotalCount, lblOverdueCount });
            statusStrip1.Location = new Point(0, 547);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(982, 26);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTotalCount
            // 
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(116, 20);
            lblTotalCount.Text = "Tổng số phiếu: 0";
            // 
            // lblOverdueCount
            // 
            lblOverdueCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOverdueCount.ForeColor = Color.Red;
            lblOverdueCount.Name = "lblOverdueCount";
            lblOverdueCount.Size = new Size(145, 20);
            lblOverdueCount.Text = "Số phiếu quá hạn: 0";
            // 
            // epCheck
            // 
            epCheck.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 573);
            Controls.Add(statusStrip1);
            Controls.Add(dgvCheckouts);
            Controls.Add(grpFilter);
            Controls.Add(grpActions);
            Controls.Add(grpInput);
            MinimumSize = new Size(1000, 620);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab Equipment Checkout - Quản Lý Mượn Trả Thiết Bị";
            Load += Form1_Load;
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            grpActions.ResumeLayout(false);
            grpFilter.ResumeLayout(false);
            grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCheckouts).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epCheck).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpInput;
        private TextBox txtCheckoutId;
        private Label lblCheckoutId;
        private TextBox txtStudentName;
        private Label lblStudentName;
        private TextBox txtStudentId;
        private Label lblStudentId;
        private ComboBox cboEquipment;
        private Label lblEquipment;
        private NumericUpDown nudQuantity;
        private Label lblQuantity;
        private DateTimePicker dtpBorrowDate;
        private Label lblBorrowDate;
        private DateTimePicker dtpDueDate;
        private Label lblDueDate;
        private CheckBox chkHasReturnDate;
        private DateTimePicker dtpReturnDate;
        private Label lblReturnDate;
        private TextBox txtCondition;
        private Label lblCondition;
        private GroupBox grpActions;
        private Button btnMarkReturned;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox grpFilter;
        private ComboBox cboFilterStatus;
        private Label lblFilterStatus;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button btnExportCsv;
        private DataGridView dgvCheckouts;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTotalCount;
        private ToolStripStatusLabel lblOverdueCount;
        private ErrorProvider epCheck;
    }
}
