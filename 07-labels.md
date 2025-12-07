# 07. Quản lý Nhãn (Labels Management)

Module **Nhãn (Nhãn)** cho phép quản trị viên tạo, quản lý và phân loại các nhãn tùy chỉnh. Các nhãn này thường được sử dụng để phân loại và gắn thẻ cho các đối tượng khác nhau trong hệ thống như Sản phẩm, Bài viết, hoặc Khách hàng.

* **Đường dẫn (Route):** `/labels`
* **Mục đích:** Hỗ trợ phân loại linh hoạt ngoài các danh mục cố định.

## 1. Danh sách Nhãn (List View)

Màn hình chính hiển thị danh sách các nhãn đã tạo, đi kèm các công cụ tìm kiếm và quản lý cơ bản.

* **Tiêu đề:** `DANH SÁCH NHÃN`

### 1.1. Công cụ tìm kiếm và Phân trang

| Chức năng | Mô tả |
| :--- | :--- |
| **Tìm kiếm** | Ô nhập liệu cho phép tìm kiếm nhãn theo từ khóa. |
| **10 Hàng** | Dropdown chọn số lượng bản ghi hiển thị trên mỗi trang. |
| **Phân trang** | Nút điều hướng giữa các trang dữ liệu (Ví dụ: `Tổng cộng 1 dữ liệu`). |

### 1.2. Bảng dữ liệu

| Cột | Mô tả | Ghi chú |
| :--- | :--- | :--- |
| **#** | Số thứ tự của nhãn. | |
| **Tiêu đề** | Tên nhãn được tạo (Ví dụ: `New`). | |
| **Hành động** | Bao gồm các nút: `Chỉnh sửa [Icon bút chì]` và `Xóa [Icon thùng rác]`. | |

### 1.3. Hành động chính

* **Nút `+ Thêm mới`**: Nằm ở góc trên bên phải, dùng để mở giao diện `THÊM MỚI` nhãn (xem mục 2).

## 2. Thêm/Chỉnh sửa Nhãn (Add/Edit Modal)

Khi nhấn nút `+ Thêm mới` hoặc nút `Chỉnh sửa`, một modal (popup) có tiêu đề `THÊM MỚI` sẽ xuất hiện.

* **Hỗ trợ đa ngôn ngữ:** Có 2 tabs để nhập liệu cho 2 ngôn ngữ: `VI` (Tiếng Việt) và `EN` (Tiếng Anh).

### 2.1. Các trường dữ liệu

| Trường | Loại dữ liệu | Ghi chú & Quy tắc |
| :--- | :--- | :--- |
| **Ảnh đại diện** | Image Upload | Cho phép tải lên hình ảnh đại diện cho nhãn. |
| **Color** | Color Picker | Cho phép chọn mã màu để hiển thị nhãn. |
| **Tiêu đề** | Text (Bắt buộc \*) | Tên chính thức của nhãn (Ví dụ: `Việt Nam Label_1765033844902`). |
| **URL** | Slug/URL (Bắt buộc \*) | Đường dẫn thân thiện cho SEO. Cần giới hạn ký tự (Ví dụ: `27/250`). |

### 2.2. Hành động trong Modal

* **Đóng:** Hủy bỏ thao tác, thoát modal.
* **Thêm mới:** Hoàn tất việc tạo (hoặc cập nhật) nhãn.