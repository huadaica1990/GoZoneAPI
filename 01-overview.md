# 01. Tổng quan Dashboard (Overview)

Website hỗ trợ: https://gozone.vn/
Zalo hỗ trợ: 08 589 790 92
Email hỗ trợ kỹ thuật: tronghuy2208@gmail.com

## 1. Giới thiệu chung
Màn hình **Tổng quan (Dashboard)** là giao diện trung tâm hiển thị ngay sau khi quản trị viên đăng nhập vào hệ thống quản trị GoZone. Trang này cung cấp các báo cáo tóm tắt, biểu đồ hiệu suất kinh doanh và các lối tắt (shortcuts) đến các chức năng quan trọng.

* **Mục đích:** Giúp người quản trị nắm bắt nhanh tình hình doanh thu, đơn hàng, khách hàng và hiệu quả của các kênh bán hàng.

---

## 2. Cấu trúc trang
Giao diện được chia thành 3 khu vực chính:
1.  **Sidebar (Menu trái):** Thanh điều hướng chứa toàn bộ các module chức năng của hệ thống (Đơn hàng, Khách hàng, Sản phẩm, Tin tức, Cấu hình...).
2.  **Header Bar (Thanh trên):**
    * Nút đóng/mở menu.
    * Ô tìm kiếm toàn cục: tại đây bạn có thể tìm kiếm mọi thứ trên website.
    * Thông báo, Ngôn ngữ, Chuyển đổi giao diện (Dark/Light mode), Thông tin tài khoản.
    * Lối tắt: Xem website, Xóa hết cache, Reset ISS, Báo lỗi bằng video
    * Sitemap website: `/sitemaps`
3.  **Main Content (Khu vực nội dung chính):** Hiển thị dữ liệu báo cáo chi tiết.

---

## 3. Chi tiết chức năng & Hiển thị

### 3.1. Bộ lọc và Hành động nhanh (Global Filter & Actions)
Nằm ở phía trên cùng của khu vực nội dung chính.

* **Lời chào:** Hiển thị lời chào theo thời gian thực (Ví dụ: *"Xin chào buổi chiều, GoZone!"*) kèm thông tin lần đăng nhập gần nhất.
* **Bộ lọc thời gian:**
    * Mặc định: Hiển thị tháng hiện tại (Từ ngày 01 đến ngày cuối tháng).
    * Định dạng: `dd/mm/yyyy HH:mm`.
* **Nút chức năng:**
    * `[Icon Lịch]`: Mở popup chọn khoảng thời gian tùy chỉnh.
    * `Thêm mới Sản phẩm`: Nút CTA (Call to Action) giúp tạo nhanh sản phẩm mới mà không cần truy cập vào menu Sản phẩm.

### 3.2. Các thẻ chỉ số (Summary Cards)
Hệ thống hiển thị 5 thẻ báo cáo tóm tắt dữ liệu trong khoảng thời gian được chọn.

| Tên thẻ | Mô tả dữ liệu | Hành động (Link điều hướng) |
| :--- | :--- | :--- |
| **TỔNG DOANH THU** | Tổng giá trị tiền của các đơn hàng thành công. Đơn vị: `đ`. | (Chỉ hiển thị chỉ số) |
| **ĐƠN HÀNG** | Tổng số lượng đơn hàng phát sinh. | `Xem đơn hàng` -> Điều hướng đến DS Đơn hàng. |
| **LIÊN HỆ** | Số lượng contact khách hàng gửi về. | `Xem liên hệ` -> Điều hướng đến DS Liên hệ. |
| **SẢN PHẨM** | Tổng số sản phẩm hiện có/mới tạo. | `Xem sản phẩm` -> Điều hướng đến DS Sản phẩm. |
| **TIN TỨC** | Số lượng bài viết tin tức đã đăng tải. | `Xem bài viết` -> Điều hướng đến Module Tin tức. |

> **Ghi chú hệ thống:**
> * Số liệu mặc định là `0` nếu không có dữ liệu.
> * Biểu tượng (Icon) ở góc phải mỗi thẻ giúp nhận diện trực quan loại dữ liệu.

### 3.3. Biểu đồ doanh thu (Revenue Analytics)
Khu vực phân tích sâu về hiệu quả kinh doanh theo dòng thời gian.

* **Tabs lọc nhanh:** `Hôm nay`, `Hôm qua`, `7 ngày trước`, `Tháng này`, `Tháng trước`.
* **Các chỉ số chi tiết (Sub-metrics):**
    * **Đơn hàng:** Số lượng đơn.
    * **Doanh thu kì vọng:** Dựa trên tổng giá trị đơn đặt hàng (bao gồm đơn chưa thanh toán).
    * **Doanh thu thực tế:** Dựa trên đơn đã hoàn tất thanh toán.
    * **Tỉ lệ chốt:** Tỷ lệ phần trăm chuyển đổi thành công.
* **Biểu đồ đường (Line Chart):**
    * **Trục Y:** Giá trị tiền tệ (Đơn vị: Triệu VNĐ).
    * **Trục X:** Mốc thời gian (Giờ trong ngày hoặc Ngày trong tháng).
    * **Legend (Chú thích):** Phân biệt màu sắc giữa Đơn hàng, Doanh thu kì vọng, Doanh thu thực tế.

### 3.4. Widget bổ trợ (Bottom Widgets)

#### A. Sản phẩm bán chạy nhất (Best Selling)
* Liệt kê danh sách sản phẩm có số lượng bán ra cao nhất.
* **Trạng thái rỗng (Empty State):**
    * Hiển thị icon kính lúp.
    * Thông báo: *"Sorry! Không tìm thấy kết quả"*.
    * Footer: *"Tổng cộng 0 dữ liệu"*.
* **Phân trang:** Nút điều hướng `<` và `>` ở góc phải dưới.

#### B. Nguồn đơn hàng (Order Source)
* Biểu đồ tròn (Pie Chart) thể hiện tỷ lệ đơn hàng đến từ các kênh.
* **Các nguồn mặc định:** Other (Khác), Website, Facebook.

#### C. Thông tin bản quyền & Hỗ trợ (License & Support)
* **Tiêu đề:** Hỗ trợ.
* **Trạng thái:** Hiển thị ngày hết hạn gói dịch vụ (Ví dụ: `01/01/2030`).
* **Label:** Tag `Hỗ trợ` màu xanh nhạt.

---

## 4. Ghi chú kỹ thuật (Technical Notes)

* **Quyền truy cập:** Dữ liệu trên Dashboard phụ thuộc vào quyền của tài khoản (Ví dụ: Nhân viên bán hàng chỉ thấy doanh thu của mình, Admin thấy toàn bộ).