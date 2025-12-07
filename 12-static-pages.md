# 12. Quản lý Trang tĩnh (Static Pages Management)

Module **Trang tĩnh** cho phép quản trị viên tạo và quản lý nội dung cho các trang không thay đổi thường xuyên (static pages), chẳng hạn như trang Giới thiệu (About Us), Chính sách bảo mật, Điều khoản dịch vụ, hoặc trang Liên hệ.

* **Đường dẫn (Route):** `/staticpages`.
* **Mục đích:** Quản lý nội dung cố định và quan trọng của website.

## 1. Danh sách Trang tĩnh (List View)

Màn hình chính hiển thị danh sách các trang tĩnh đã được tạo.

* **Tiêu đề:** `DANH SÁCH TRANG TĨNH`.
* **Nút hành động:** `+ Thêm mới` mở modal `THÊM MỚI`.

### 1.1. Công cụ lọc và tìm kiếm

| Chức năng | Mô tả |
| :--- | :--- |
| **Tìm kiếm** | Ô nhập liệu cho phép lọc theo từ khóa. |
| **Chọn trạng thái** | Dropdown cho phép lọc theo trạng thái hoạt động. |
| **10 Hàng** | Dropdown chọn số lượng bản ghi hiển thị trên mỗi trang. |

### 1.2. Bảng dữ liệu

| Cột | Mô tả | Dữ liệu mẫu | Ghi chú |
| :--- | :--- | :--- | :--- |
| **Tiêu đề** | Tên trang. | `Chính sách xóa dữ liệu người dùng`, `Liên hệ`, `Giới thiệu`. | |
| **Trạng thái** | Tình trạng hoạt động của trang. | `ĐANG HOẠT ĐỘNG`. | |
| **Giao diện** | Template hiển thị. | `Contact Page` hoặc `Default`. | |
| **Hành động** | Bao gồm các nút: `Chỉnh sửa [Icon bút chì]` và `Xóa [Icon thùng rác]`. | |

## 2. Thêm mới / Cấu hình Trang tĩnh (Configuration View)

### 2.1. Modal Thêm mới (Quick Add)
Modal này cho phép tạo nhanh một trang tĩnh mới.

* **Hỗ trợ đa ngôn ngữ:** Có 2 tabs để nhập liệu cho 2 ngôn ngữ: `VI` và `EN`.
* **Trường thông tin:**
    * **Tiêu đề \***.
    * **URL \*** (giới hạn `34/250` ký tự).
    * **Meta SEO title \*** (giới hạn `20/70` ký tự).
* **Trạng thái:** Toggle `Đang hoạt động` và `Không được xóa`.

### 2.2. Giao diện Chỉnh sửa Chi tiết (Edit View)
Giao diện chỉnh sửa chi tiết cung cấp đầy đủ các tùy chọn nội dung và SEO.

* **Thông tin cơ bản:**
    * **Tiêu đề \***.
    * **Mô tả**, **Nội dung** (Rich Text Editor).
    * **Số thứ tự** (`0`).
    * **Trạng thái:** Toggle `Đang hoạt động` và `Không được xóa`.
* **SEO:** Chứa các trường SEO cơ bản.
    * **Tiêu đề SEO \*** (giới hạn `13/70` ký tự).
    * **URL \*** (giới hạn `23/250` ký tự).
* **Schema :** `Schema`, `Thumbnail (1200x630): dùng để chia sẻ các mạng xã hội`.
* **Giao diện:** Quản lý giao diện của ở dưới cùng.