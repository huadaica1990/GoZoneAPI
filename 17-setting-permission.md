# 17. Quản trị viên (Admin Management)

Module **Quản trị viên** tập trung vào việc quản lý tài khoản người dùng có quyền truy cập vào hệ thống quản trị (Admin Panel) và phân quyền chi tiết cho từng nhóm người dùng.

* **Đường dẫn (Route):** `/roles`.

## 1. Quyền quản trị viên (Roles and Permissions)

Tab này cho phép tạo và cấu hình các vai trò (roles) khác nhau trong hệ thống.

### 1.1. Danh sách Vai trò (Role List)
Khu vực bên trái hiển thị danh sách các nhóm quyền đã được tạo.

* **Nút hành động:** `+ Thêm mới`.
* **Các vai trò mẫu:** `Admin`, `GoZone Customer`.

### 1.2. Cấu hình Quyền chi tiết (Permission Detail)
Khu vực bên phải hiển thị cấu hình quyền của vai trò được chọn.

#### A. Thông tin Vai trò
* **ID Name:** Mã định danh của vai trò (Ví dụ: `ADMIN`).
* **Tiêu đề:** Tên hiển thị của vai trò (Ví dụ: `Admin`).
* **Trạng thái:** Toggle `Đang hoạt động`.

#### B. Phân quyền Module
Hệ thống hiển thị một bảng phân quyền chi tiết cho từng module chức năng.

| Module chức năng | Mô tả chung | Các Quyền chi tiết |
| :--- | :--- | :--- |
| **Quản lý tài khoản** | Quản lý thông tin và mật khẩu cá nhân. | `GET`, `CREATE`, `UPDATE`, `DELETE`. |
| **Bán hàng** | Quản lý Đơn hàng. | `GET`, `CREATE`, `UPDATE`, `DELETE`. |
| **Chỉnh sửa giao diện** | Quản lý các mục thiết kế (Ví dụ: Menu, Banner). | `GET`, `CREATE`, `UPDATE`, `DELETE`. |
| **Cấu hình** | Cấu hình website, SEO. | `GET`, `CREATE`, `UPDATE`, `DELETE`. |

* **Lưu ý:** Vai trò `Admin` thường có toàn bộ quyền được đánh dấu cho tất cả các cột.

## 2. Danh sách quản trị viên (Admin List)

Tab này quản lý danh sách các tài khoản người dùng có quyền truy cập vào hệ thống quản trị.

* **Đường dẫn (Route):** `/users`.
* **Tiêu đề:** `DANH SÁCH QUẢN TRỊ VIÊN`.
* **Nút hành động:** `+ Thêm mới` mở modal `THÊM MỚI`.

### 2.1. Danh sách Tài khoản (List View)
| Cột | Mô tả | Dữ liệu mẫu | Ghi chú |
| :--- | :--- | :--- | :--- |
| **Tên đăng nhập** | Tên đăng nhập vào hệ thống. | `admin`. | |
| **Email** | Địa chỉ Email của quản trị viên. | `admin@admin.com (Chưa xác thực)`. | Hiển thị trạng thái xác thực Email. |
| **Trạng thái** | Tình trạng hoạt động của tài khoản. | `ĐANG HOẠT ĐỘNG`. | |
| **Hành động** | Bao gồm `Chỉnh sửa` và `Xóa`. | |

### 2.2. Modal Thêm mới Quản trị viên (Quick Add)
Modal này cho phép tạo nhanh một tài khoản quản trị viên mới.

* **Trường thông tin:** `Tên đăng nhập *`, `Tên *`, `Họ *`, `Email *`, `SĐT *`.
* **Quyền:** `Quyền quản trị viên *` (Dropdown chọn vai trò).

### 2.3. Giao diện Thông tin Cá nhân (Self-Management)
* **Thông tin tài khoản:** Hiển thị Tên, Họ, Email, SĐT, Quyền quản trị viên.
* **Cấu hình:** `Bật xác thực 2 bước`, `Đang hoạt động`, `Khóa tài khoản`.
* **Lịch sử:** Tab `Lịch sử` cho phép xem `Danh sách hoạt động` của tài khoản trên hệ thống.