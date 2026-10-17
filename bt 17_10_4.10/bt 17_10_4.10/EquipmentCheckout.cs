using System;

namespace bt_17_10_4._10
{
    public class EquipmentCheckout
    {
        public string CheckoutId { get; set; }      // Mã phiếu
        public string StudentId { get; set; }       // Mã sinh viên
        public string StudentName { get; set; }     // Họ tên sinh viên
        public string EquipmentName { get; set; }   // Tên thiết bị
        public int Quantity { get; set; }          // Số lượng
        public DateTime BorrowDate { get; set; }    // Ngày mượn
        public DateTime DueDate { get; set; }       // Hạn trả
        public DateTime? ReturnDate { get; set; }   // Ngày trả thực tế (nullable)
        public string Condition { get; set; }      // Tình trạng thiết bị khi mượn/trả

        // Tự động xác định tình trạng phiếu mượn
        public string Status
        {
            get
            {
                if (ReturnDate.HasValue)
                    return "Đã trả";
                if (DueDate.Date < DateTime.Today)
                    return "Quá hạn";
                return "Đang mượn";
            }
        }

        public EquipmentCheckout() { }

        public EquipmentCheckout(string checkoutId, string studentId, string studentName,
                                 string equipmentName, int quantity, DateTime borrowDate,
                                 DateTime dueDate, DateTime? returnDate = null, string condition = "Tốt")
        {
            CheckoutId = checkoutId;
            StudentId = studentId;
            StudentName = studentName;
            EquipmentName = equipmentName;
            Quantity = quantity;
            BorrowDate = borrowDate.Date;
            DueDate = dueDate.Date;
            ReturnDate = returnDate?.Date;
            Condition = condition;
        }
    }
}
