# 09. Quản lý Cửa hàng (Stores Management)

Module **Danh sách cửa hàng** cho phép quản trị viên quản lý thông tin chi tiết về các địa điểm cửa hàng vật lý hoặc chi nhánh. Thông tin này thường được sử dụng để hiển thị trên bản đồ, trang liên hệ hoặc trang tìm kiếm cửa hàng.

* **Đường dẫn (Route):** `/stores`.

## 1. Danh sách Cửa hàng (List View)

Màn hình chính hiển thị danh sách các cửa hàng đã được tạo.

* **Tiêu đề:** `DANH SÁCH CỬA HÀNG`.
* **Nút hành động:** `+ Thêm mới` mở modal `THÊM MỚI`, e01f6cd0-9a02-4454-ac0f-b2e288af416f.

### 1.1. Công cụ lọc và tìm kiếm

| Chức năng | Mô tả |
| :--- | :--- |
| **Tìm kiếm** | Ô nhập liệu cho phép lọc theo từ khóa (dựa trên cột `Tiêu đề`). |
| **Chọn trạng thái** | Dropdown cho phép lọc theo trạng thái hoạt động. |
| **10 Hàng** | Dropdown chọn số lượng bản ghi hiển thị trên mỗi trang. |

### 1.2. Bảng dữ liệu

| Cột | Mô tả | Dữ liệu mẫu |
| :--- | :--- | :--- |
| **#** | Số thứ tự/Mã định danh. | `0`. |
| **Tiêu đề** | Tên cửa hàng. | `Việt Nam Store_1765038164982`. |
| **Trạng thái** | Tình trạng hoạt động của cửa hàng. | `ĐANG HOẠT ĐỘNG`. |
| **Giao diện** | Template hiển thị. | `Default`. |
| **Hành động** | Bao gồm các nút: `Chỉnh sửa [Icon bút chì]` và `Xóa [Icon thùng rác]`. |

## 2. Cấu hình Cửa hàng (Configuration View)

Khi thêm mới hoặc chỉnh sửa, hệ thống chuyển sang giao diện cấu hình chi tiết.

* **Hỗ trợ đa ngôn ngữ:** Có 2 tabs để nhập liệu cho 2 ngôn ngữ: `VI` và `EN`.

### 2.1. Thông tin cơ bản và Nội dung

| Trường thông tin | Loại dữ liệu | Ghi chú & Quy tắc |
| :--- | :--- | :--- |
| **Tiêu đề \*** | Text | Tên cửa hàng. |
| **Mô tả** | Text Area | Mô tả ngắn về cửa hàng. |
| **Nội dung** | Rich Text Editor | Mô tả chi tiết. |
| **Số thứ tự** | Number | Sắp xếp thứ tự hiển thị. |
| **Đang hoạt động** | Toggle | Trạng thái kích hoạt. |

### 2.2. Thông tin liên hệ và Địa lý

* **Tỉnh/Thành phố, Phường/Xã:** Dropdown chọn địa điểm (có tính chất phân cấp).
* **Địa chỉ:** Địa chỉ chi tiết.
* **Giờ mở cửa, Ngày nghỉ thường niên:** Trường nhập liệu thời gian hoạt động.
* **Số điện thoại:** Trường nhập liệu số điện thoại liên hệ.
* **Vị trí (Latitude - Longitude):** Cặp tọa độ.

### 2.3. Hình ảnh và Giao diện

* **Ảnh đại diện:** Khu vực tải lên hình ảnh cho cửa hàng.
* **SEO:** Chứa các trường SEO (`Tiêu đề SEO`, `Mô tả SEO`, `URL *`).
* **Schema :** `Schema`, `Thumbnail (1200x630): dùng để chia sẻ các mạng xã hội`.
* **Giao diện:** Quản lý giao diện của ở dưới cùng.
    * Dropdown chọn template (`Default`).
    * `Gallery` (Bộ sưu tập ảnh): Bảng quản lý album ảnh.