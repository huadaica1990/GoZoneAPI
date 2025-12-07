# 21. Hệ thống (System Management)

Module **Hệ thống** tập hợp các công cụ quản trị kỹ thuật và cấu hình nâng cao, giúp duy trì hiệu suất, bảo mật và khả năng mở rộng của website.

## 1. Cache

Tab **Cache** cung cấp các chức năng quản lý bộ nhớ đệm, giúp cải thiện tốc độ tải trang.
* **Đường dẫn (Route):** `/caches`.

* **Tiêu đề:** `QUẢN LÝ CACHE`.
* **Mục đích:** Xóa bộ nhớ đệm khi cần thiết.

### 1.1. Các Loại Cache
Giao diện liệt kê các loại cache khác nhau của hệ thống.

| Loại Cache | Mô tả | Nút hành động |
| :--- | :--- | :--- |
| **Clear all cache** | Xóa toàn bộ bộ nhớ đệm. | `Xóa cache`. |
| **Cache page** | Bộ nhớ đệm dành cho giao diện người dùng. | `Xóa cache`. |
| **Cache js/css** | Bộ nhớ đệm cho các tệp tĩnh. | `Xóa cache`. |

## 2. Redirects (Chuyển hướng)

Tab **Redirects** quản lý các quy tắc chuyển hướng URL, giúp duy trì SEO.
* **Đường dẫn (Route):** `/redirects`.

* **Tiêu đề:** `QUẢN LÝ REDIRECTS`.
* **Nút hành động:** `+ Thêm mới`.

### 2.1. Danh sách Chuyển hướng (Redirect List)
| Cột | Mô tả | Dữ liệu mẫu |
| :--- | :--- | :--- |
| **URL Gốc** | Đường dẫn cũ cần được chuyển hướng. | `/tin-tuc/bai-viet-cu-da-xoa`. |
| **URL Đích** | Đường dẫn mới mà người dùng sẽ được chuyển đến. | `/tin-tuc/bai-viet-moi-thay-the`. |

## 3. IP hạn chế (Restricted IPs)

Tab **IP hạn chế** cho phép thiết lập danh sách các địa chỉ IP bị cấm hoặc hạn chế truy cập.
* **Đường dẫn (Route):** `/ipconfigs`.

* **Tiêu đề:** `DANH SÁCH IP HẠN CHẾ`.
* **Nút hành động:** `+ Thêm mới`.
* **Modal Thêm mới:** Cho phép nhập `Tiêu đề *`, `IP *`, và toggle `Chặn truy cập`.

## 4. Email Templates (Mẫu Email)

Tab này quản lý các mẫu email tự động được hệ thống sử dụng (Ví dụ: xác nhận đơn hàng, đặt lại mật khẩu).
* **Đường dẫn (Route):** `/emailtemplates`.

* **Danh sách Templates:** Bao gồm `invoice`, `reset password`, `info contact`.
* **Cấu hình:** Mỗi template (Ví dụ: `invoice`) bao gồm `Tiêu đề *`, `Mô tả`, `Nội dung *` (mã HTML).
* **Demo:** Hiển thị bản xem trước với các placeholder động (Ví dụ: `{{WEBSITE_NAME}}`, `{{ORDER_ID}}`).

## 5. API Keys (Khóa API)

Tab **API Keys** quản lý các khóa API được sử dụng để tích hợp hệ thống với các dịch vụ bên ngoài (Ví dụ: Google Gemini, OpenAI).
* **Đường dẫn (Route):** `/apikeys`.

* **Tiêu đề:** `DANH SÁCH API KEY`.
* **Dữ liệu mẫu:** Khóa `Gemini` thuộc nhà cung cấp `Google Gemini`.
* **Modal Thêm mới:** Cho phép nhập `Tiêu đề *`, `Loại` (Ví dụ: `Open Ai`), `Key *`, và `URL *` (API Endpoint).