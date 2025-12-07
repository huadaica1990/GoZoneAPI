# 19. Ngôn ngữ (Languages Management)

Module **Ngôn ngữ** cho phép quản trị viên thêm, sửa, xóa các ngôn ngữ được hỗ trợ trên website.

* **Đường dẫn (Route):** `/languages`.

## 1. Danh sách Ngôn ngữ (Language List)

Màn hình này hiển thị danh sách các ngôn ngữ đang được kích hoạt hoặc có sẵn trong hệ thống.

* **Tiêu đề:** `DANH SÁCH NGÔN NGỮ`.
* **Nút hành động:** `+ Thêm mới` mở modal `THÊM MỚI`.

### 1.1. Bảng dữ liệu
| Cột | Mô tả | Dữ liệu mẫu | Ghi chú |
| :--- | :--- | :--- | :--- |
| **Tiêu đề** | Tên đầy đủ của ngôn ngữ. | `Tiếng Việt`, `English (United Kingdom)`. | |
| **Code** | Mã ngôn ngữ tiêu chuẩn (Ví dụ: ISO 639-1). | `vi`, `en`. | |
| **Trạng thái** | Tình trạng hoạt động của ngôn ngữ đó trên website. | `ĐANG HOẠT ĐỘNG`. | |
| **Ngôn ngữ mặc định** | Hiển thị ngôn ngữ được chọn làm mặc định cho website. | `ĐANG HOẠT ĐỘNG`. | Chỉ có một ngôn ngữ được phép làm mặc định. |
| **Hành động** | Bao gồm `Chỉnh sửa [Icon bút chì]`, `Xóa [Icon thùng rác]`. | |

### 1.2. Chỉnh sửa chi tiết
Khi nhấn `Chỉnh sửa`, một modal xuất hiện cho phép sửa đổi nội dung dịch của một Key cụ thể cho tất cả các ngôn ngữ đang hoạt động.

| Trường thông tin | Loại dữ liệu | Ghi chú & Quy tắc |
| :--- | :--- | :--- |
| **Key Name \*** | Text (Read-only) | Mã định danh không thể thay đổi. |
| **Tiếng Việt \*** | Text Area | Nội dung dịch thuật. |
| **English (UK) \*** | Text Area | Nội dung dịch thuật. |