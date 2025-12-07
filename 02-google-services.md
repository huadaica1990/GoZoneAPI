# 02. Dịch vụ Google

Mô đun này quản lý các kết nối và đồng bộ dữ liệu giữa hệ thống GoZone và các dịch vụ của Google (Google Analytics, Google Sheets).

## 1. Google Analytics
Màn hình này hiển thị dữ liệu thống kê truy cập website được trích xuất trực tiếp từ tài khoản Google Analytics 4 (GA4) đã liên kết. Giúp quản trị viên theo dõi hiệu suất website mà không cần rời khỏi trang quản trị.

* **Đường dẫn (Route):** `/dashboards/analytics`
* **Quyền hạn:** Cần quyền truy cập API Google Analytics.

### 1.1. Thanh công cụ & Cấu hình (Top Bar)
Khu vực trên cùng cho phép cấu hình kết nối và bộ lọc dữ liệu nhanh.

* **Bộ lọc thời gian:** Ô nhập liệu ngày tháng + Nút `Xem`.
* **Shortcut:** Nút `Thêm mới Tin tức` (Màu xanh) hỗ trợ tạo nội dung nhanh.
* **Cấu hình Property ID:**
    * Ô nhập liệu chứa ID tài khoản GA4 (Ví dụ: `123456789`).
    * Nút `Cập nhật`: Lưu thay đổi ID mới.
    * Nút `Đăng xuất`: Ngắt kết nối tài khoản Google hiện tại.
    * Nút `Reload` (Icon vòng tròn đỏ): Làm mới dữ liệu thủ công.

### 1.2. Thẻ chỉ số tổng quan (Overview Cards)
Hiển thị 4 chỉ số hiệu suất chính (KPIs) so sánh với tháng trước (hiển thị % tăng/giảm).

| Chỉ số | Mô tả | Ghi chú hiển thị |
| :--- | :--- | :--- |
| **Người truy cập (Users)** | Tổng số người dùng duy nhất truy cập vào website. | Có hiển thị % thay đổi (Ví dụ: -68.00% tháng trước). |
| **Phiên (Sessions)** | Tổng số phiên truy cập bắt đầu. | |
| **Thời lượng trung bình** | Thời gian trung bình người dùng lưu lại trên trang (Ví dụ: 59s). | Đơn vị: Giây (s) hoặc Phút. |
| **Tỷ lệ thoát (Bounce Rate)** | Tỷ lệ phần trăm phiên truy cập không có tương tác (Ví dụ: 0%). | |

### 1.3. Biểu đồ phân tích (Analytical Charts)

#### A. Người dùng theo tỉnh thành (Users by City)
* **Loại biểu đồ:** Biểu đồ thanh ngang (Horizontal Bar Chart).
* **Dữ liệu:** Top các tỉnh/thành phố có lượng truy cập cao nhất.
* **Bộ lọc con:** Có tab `Tháng này` / `Tháng trước` ở góc phải biểu đồ để so sánh nhanh.

#### B. Người dùng theo thiết bị (Device Category)
* **Loại biểu đồ:** Biểu đồ Donut (Hình nhẫn).
* **Phân loại:** Mobile Users (Di động), Desktop Users (Máy tính bàn), Tablet Users (Máy tính bảng).
* **Chi tiết:** Hiển thị số lượng user cụ thể và % tăng trưởng so với tháng trước.

#### C. Nguồn truy cập (Top Referrals/Channels)
* **Tiêu đề trên UI:** *Top Referrals Pages*.
* **Các chỉ số:** Organic Search, Direct, Referral, Unassigned.
* **Hiển thị:** Dạng thanh tiến trình (Progress bar) và danh sách phần trăm tỷ trọng.

### 1.4. Bảng dữ liệu chi tiết (Data Tables)

#### A. Trang xem nhiều nhất (Top Pages)
Liệt kê các URL được truy cập nhiều nhất trên website.
* **Cột hiển thị:** URL (Đường dẫn), Phiên (Số lượng session), Tỷ lệ (%).

#### B. Sự kiện hàng đầu (Top Events)
Thống kê các hành động tương tác của người dùng trên trang.
* **Các sự kiện phổ biến:** `page_view`, `submit_form`, `session_start`, `first_visit`, `user_engagement`, `scroll`.

---

## 2. Google Sheets

Giao diện này cho phép quản trị viên liên kết hệ thống GoZone với các tệp Google Sheets, phục vụ cho mục đích nhập/xuất dữ liệu hàng loạt (Bulk data processing) như Sản phẩm, Khách hàng, hoặc Đơn hàng.

* **Đường dẫn (Route):** `/dashboards/sheets`

### 2.1. Thanh công cụ và Liên kết (Actions & Links)
* **Thêm mới Google Sheet ID:** Mở popup cho phép nhập Google Sheet ID để thiết lập kết nối.
* **Link Xuất Demo:** Tải về hoặc tạo một file Sheet mẫu (template).
* **Context Selector:** Hiển thị tên Sheet đang được chọn và làm việc (Ví dụ: `Demo`).
* **Khu vực làm việc:** Dưới tiêu đề `[Products] | Demo` xác nhận dữ liệu đang hiển thị là của module Sản phẩm.

### 2.2. Bảng dữ liệu đồng bộ (Synchronization Data Grid)
Hiển thị dữ liệu được đọc từ Google Sheet tương ứng.
* **Thao tác tìm kiếm và phân trang:** Hỗ trợ Tìm kiếm và chọn số lượng hàng hiển thị (`10 Hàng`).
* **Các cột dữ liệu chính:**
| Tên cột | Mô tả dữ liệu | Ghi chú |
| :--- | :--- | :--- |
| **skuId** | Định danh duy nhất của sản phẩm. | |
| **name** | Tên sản phẩm (Ví dụ: 'Việt Nam Product new!'). | |
| **sku** | Mã SKU (Stock Keeping Unit). | |
| **amount** | Giá bán niêm yết (Ví dụ: `1.500.000 đ`). | |
| **promoAmount** | Giá khuyến mãi (Ví dụ: `0 đ`). | |
| **quantity** | Số lượng tồn kho (Ví dụ: `3`). | |
| **Hành động** | Nút `[Icon bút chì]` để chỉnh sửa chi tiết một bản ghi. |

> **Ghi chú hệ thống:**
> * Dữ liệu được đọc từ Sheet và hiển thị dưới dạng lưới (grid) để xem và chỉnh sửa nhanh.

---

## 3. Cấu hình dịch vụ

### 3.1 Add GGSheets
Phần này mô tả quy trình và các trường thông tin cần thiết để thêm mới một kết nối Google Sheet.
* **Đường dẫn (Route):** `/google/sheets`

#### A. Giao diện quản lý cấu hình (Google Sheets List)
Đây là trang liệt kê các Sheet ID đã được cấu hình.
* **Nút hành động:** `+ Thêm mới` mở popup để tạo kết nối mới.
* **Các cột dữ liệu:**
    | Cột | Mô tả |
    | :--- | :--- |
    | **Tiêu đề** | Tên gợi nhớ do quản trị viên đặt (Ví dụ: `Demo`). |
    | **Google Sheet ID** | Mã định danh duy nhất của Sheet (Ví dụ: `19dGZbfM....`). |
    | **Hành động** | Nút chỉnh sửa `[Icon bút chì]` và Xóa `[Icon thùng rác]`. |

#### B. Popup Thêm mới (Add New Google Sheet)
Đây là các trường thông tin bắt buộc khi thêm một liên kết Sheet mới.

| Trường thông tin | Loại dữ liệu | Ghi chú & Quy tắc |
| :--- | :--- | :--- |
| **Giao diện** | Dropdown (Bắt buộc *) | Chọn module đồng bộ dữ liệu (Ví dụ: **Products**, **Travels**, **Posts**, **Orders**). |
| **Tiêu đề** | Text (Bắt buộc *) | Tên hiển thị trong danh sách cấu hình. |
| **Mô tả** | Text Area (Không bắt buộc) | Ghi chú về mục đích sử dụng Sheet. |
| **Google Sheet URL** | URL (Bắt buộc *) | Đường dẫn đầy đủ đến tệp Google Sheet. |
| **Google Sheet ID** | Text (Bắt buộc *) | Mã ID duy nhất trích xuất từ URL. |

> **Ghi chú kỹ thuật:**
> * Dấu hỏi `?` bên cạnh các trường là nút Tooltip, cung cấp hướng dẫn.