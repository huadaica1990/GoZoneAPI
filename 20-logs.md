# 20. Hoạt động (Activity Logs)

Module **Hoạt động** cung cấp lịch sử chi tiết về các thao tác và tương tác của người dùng (quản trị viên và hệ thống) trên Admin Panel, giúp theo dõi, kiểm soát và phục vụ cho mục đích kiểm toán.

* **Đường dẫn (Route):** `/logs`.
* **Tiêu đề:** `DANH SÁCH HOẠT ĐỘNG`.

## 1. Danh sách Hoạt động (Activity List)

### 1.1. Công cụ lọc và tìm kiếm
| Chức năng | Mô tả |
| :--- | :--- |
| **Tìm kiếm** | Ô nhập liệu cho phép lọc theo từ khóa (Ví dụ: tên, tiêu đề). |
| **Khoảng thời gian** | Cho phép lọc theo phạm vi ngày/giờ. |
| **Chọn danh mục** | Dropdown cho phép lọc theo module/chức năng được thao tác. |
| **10 Hàng** | Dropdown chọn số lượng bản ghi hiển thị trên mỗi trang. |

### 1.2. Bảng dữ liệu
Bảng hiển thị chi tiết lịch sử thao tác của các tài khoản.

| Cột | Mô tả | Dữ liệu mẫu | Ghi chú |
| :--- | :--- | :--- | :--- |
| **Ngày tạo** | Thời gian xảy ra hoạt động (Ví dụ: `07/12/2025 06:39 AM`). | | |
| **Tiêu đề** | Mô tả ngắn gọn về hành động được thực hiện. | `Cập nhật phí ship Shipping_1765089507501`, `Tạo banner mới Banner_1765083130478`. | |
| **IP** | Địa chỉ IP của người dùng thực hiện hành động. | `::1 - Local`. | |
| **Người tạo** | Tên người dùng hoặc hệ thống (Ví dụ: `gozone`). | `gozone`. | |
| **Danh mục** | Module bị ảnh hưởng (Ví dụ: `TIN TỨC`, `LANDING PAGES`). | `TIN TỨC`. | |
| **Loại** | Phân loại hành động (Ví dụ: `Cập nhật`, `Thêm mới`). | `Cập nhật`, `Thêm mới`. | |
| **Hành động** | Liên kết để xem chi tiết bản ghi. | `Cập nhật`, `Thêm mới`. | |