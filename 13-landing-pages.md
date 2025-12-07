# 13. Quản lý Landing Pages

Module **Landing pages** cho phép quản trị viên tạo và quản lý các trang đích được thiết kế chuyên biệt cho các chiến dịch marketing (marketing campaigns). Các trang này thường tập trung vào một mục tiêu chuyển đổi duy nhất.

* **Đường dẫn (Route):** `/landingpages`.
* **Mục đích:** Hỗ trợ chiến dịch quảng cáo, tối ưu hóa tỷ lệ chuyển đổi.

## 1. Danh sách Landing Pages (List View)

Màn hình chính hiển thị danh sách các trang đích đã được tạo.

* **Tiêu đề:** `LANDING PAGES LIST`.
* **Nút hành động:** `+ Thêm mới` mở modal `THÊM MỚI`.

### 1.1. Công cụ lọc và tìm kiếm

| Chức năng | Mô tả |
| :--- | :--- |
| **Tìm kiếm** | Ô nhập liệu cho phép lọc theo từ khóa. |
| **Chọn trạng thái** | Dropdown cho phép lọc theo trạng thái hoạt động. |
| **10 Hàng** | Dropdown chọn số lượng bản ghi hiển thị trên mỗi trang. |

### 1.2. Bảng dữ liệu

| Cột | Mô tả | Dữ liệu mẫu |
| :--- | :--- | :--- |
| **Tiêu đề** | Tên Landing Page. | `Bán hàng 12/12`. |
| **Trạng thái** | Tình trạng hoạt động của trang. | `ĐANG HOẠT ĐỘNG`. |
| **Giao diện** | Template hiển thị. | `Default`. |
| **Hành động** | Bao gồm các nút: `Chỉnh sửa [Icon bút chì]` và `Xóa [Icon thùng rác]`. |

## 2. Thêm mới / Cấu hình Landing Page (Configuration View)

### 2.1. Modal Thêm mới (Quick Add)
Modal này cho phép tạo nhanh một trang Landing Page mới.

* **Hỗ trợ đa ngôn ngữ:** Có 2 tabs để nhập liệu cho 2 ngôn ngữ: `VI` và `EN`.
* **Trường thông tin:**
    * **Tiêu đề \***.
    * **URL \*** (giới hạn `35/250` ký tự).
    * **Meta SEO title \*** (giới hạn `21/70` ký tự).
* **Trạng thái:** Toggle `Đang hoạt động` và `Không được xóa`.

### 2.2. Giao diện Chỉnh sửa Chi tiết (Edit View)
Giao diện chỉnh sửa chi tiết Landing Page có cấu trúc phức tạp, bao gồm các tab cấu hình chuyên sâu.

#### A. Tab Thông tin cơ bản
* **Thông tin cơ bản:** `Tiêu đề`, `Mô tả`, `Nội dung` (Rich Text Editor).
* **Thông tin Liên hệ:** Bảng quản lý các thông tin liên hệ như `Website Email`, `Website Phone`, `Website Address`.
* **Ảnh đại diện:** Khu vực tải lên hình ảnh cho trang.
* **SEO:** `Tiêu đề SEO *` (giới hạn `11/70` ký tự), `Mô tả SEO`, `URL *` (giới hạn `25/250` ký tự).
* **Schema :** `Schema`, `Thumbnail (1200x630): dùng để chia sẻ các mạng xã hội`.
* **Giao diện:** Quản lý giao diện của ở dưới cùng.

#### B. Tab Theme config (Cấu hình Giao diện)
Tab này cho phép tùy chỉnh các yếu tố giao diện.
* **Logo/Favicon:** Quản lý các logo hiển thị cho Favicon, Header, Mobile, và Footer.
* **Popup, Mạng xã hội:** Các mục để cấu hình popup hiển thị và liên kết mạng xã hội.
* **SEO cơ bản, CSS, JS...:** Khu vực để chèn mã tùy chỉnh (custom code).