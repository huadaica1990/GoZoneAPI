# 18. Phí giao hàng (Shipping Fees)

Module **Phí giao hàng** cho phép quản trị viên cấu hình chi tiết mức phí vận chuyển dựa trên khu vực địa lý (quốc gia, tỉnh/thành phố, quận/huyện).

* **Đường dẫn (Route):** `/shippings`.
* **Mục đích:** Thiết lập logic tính phí vận chuyển cho các đơn hàng.

## 1. Danh sách Phí giao hàng (Shipping Fee List)

Màn hình chính hiển thị danh sách các cấu hình phí giao hàng theo khu vực.

* **Tiêu đề:** `DANH SÁCH PHÍ`.
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
| **Tiêu đề** | Tên cấu hình/Khu vực áp dụng. | `Shipping_1765089507501 - Vietnam`. | Hiển thị `Giá trị` phí (Ví dụ: `20.000 đ` hoặc `0 đ`). |
| **Trạng thái** | Tình trạng hoạt động của cấu hình phí. | `ĐANG HOẠT ĐỘNG`. | |
| **Hành động** | Bao gồm `Chỉnh sửa [Icon bút chì]` và `Xóa [Icon thùng rác]`. | |

### 1.3. Modal Thêm mới Phí giao hàng (Quick Add)
Modal này cho phép tạo nhanh một cấu hình phí mới, thường áp dụng cho một Quốc gia/Vùng cụ thể.

| Trường thông tin | Loại dữ liệu | Ghi chú & Quy tắc |
| :--- | :--- | :--- |
| **Tiêu đề \*** | Text | Tên cấu hình. |
| **Quốc gia \*** | Dropdown | Chọn quốc gia áp dụng phí (Ví dụ: `Albania`). |
| **Giá tiền \*** | Number | Mức phí mặc định (Ví dụ: `0`). |
| **Đang hoạt động** | Toggle | Trạng thái kích hoạt. |

## 2. Cấu hình Chi tiết Phí giao hàng (Edit View)

Giao diện này cho phép định nghĩa mức phí vận chuyển phân cấp theo tỉnh/thành phố và quận/huyện.

* **Tiêu đề:** Tên cấu hình (Ví dụ: `SHIPPING_1765089507501`).

### 2.1. Cấu hình Cấp Quốc gia/Mặc định
Khu vực này thiết lập mức phí cơ sở và các phí đặc biệt.

| Trường | Mô tả | Giá trị mẫu |
| :--- | :--- | :--- |
| **Quốc gia \*** | Quốc gia áp dụng (Ví dụ: `Vietnam`). | `Vietnam`. |
| **Giá tiền \*** | Mức phí giao hàng mặc định (Ví dụ: `20.000`). | `20.000`. |
| **Toggle:** `Áp dụng giá hàng mặc định cho tất cả tỉnh/thành/quận/huyện`. | | |
| **Phí đặc biệt:** `Đặc Khu Kinh Tế/Quốc Phòng/Châu Âu/Khổ Thấp`. | Cho phép định nghĩa các mức phí riêng cho các khu vực đặc biệt. | `20.000`. |

### 2.2. Cấu hình Cấp Tỉnh/Thành phố và Huyện/Xã
Khu vực này cho phép override (ghi đè) phí mặc định bằng cách cấu hình phí riêng cho từng tỉnh/thành phố.

* **Danh sách Tỉnh/Thành phố:** Hiển thị danh sách các tỉnh/thành phố.
    * **Các cột:** `Tiêu đề` (Tên tỉnh/thành phố), `Giá trị` (Phí áp dụng), `Trạng thái`.
    * **Ví dụ:** Tỉnh `An Giang` có `Giá trị: 20.000 đ`.
* **Chỉnh sửa Chi tiết Quận/Huyện:** Khi chỉnh sửa một tỉnh/thành phố (Ví dụ: `An Giang`), một modal xuất hiện cho phép cấu hình phí cho từng cấp quận/huyện (Ví dụ: `Phường Bình Đức`, `Phường Châu Đốc`, `Phường Chi Lăng`).