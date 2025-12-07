# 15. Cấu hình Website (Website Settings)

Module **Cấu hình website** quản lý các thông số cốt lõi của hệ thống, bao gồm thông tin liên hệ, tích hợp mạng xã hội, thông tin thanh toán, và các khóa API.

* **Đường dẫn (Route):** `/themesettings/websitesettings`.

## 1. Thông tin cơ bản (General Info)
Tab này chứa các thông số định danh và thông tin liên hệ chính của website.

* **Cập nhật cuối:** Hiển thị thời gian và người dùng thực hiện lần cập nhật cuối cùng (Ví dụ: `06/12/2025 02:50:40 | gozone`).

### 1.1. Các trường cấu hình đơn
| Trường | Mô tả | Giá trị lưu trữ mẫu |
| :--- | :--- | :--- |
| **Website Name** | Tên thương hiệu/website. | `WEBSITE_NAME`. |
| **Website Url** | Đường dẫn URL chính thức của website. | `WEBSITE_URL`. |
| **Website License** | Mã bản quyền hoặc giấy phép sử dụng. | `WEBSITE_LICENSE`. |

### 1.2. Bảng quản lý thông tin liên hệ (Đa ngôn ngữ)
Các thông tin này được quản lý dưới dạng bảng, cho phép lưu trữ nhiều địa chỉ/số điện thoại/email khác nhau.

* **Website Email:** Quản lý danh sách Email liên hệ.
    * **Cột:** `Tiêu đề`, `Giá trị` (`example@domain.com`).
* **Website Phone:** Quản lý danh sách Số điện thoại.
    * **Cột:** `Tiêu đề`, `Giá trị` (`090 0000 000`).
* **Website Address:** Quản lý danh sách Địa chỉ.
    * **Cột:** `Tiêu đề`, `Giá trị`, `Map` (Mã nhúng hoặc URL bản đồ).

## 2. Mạng xã hội (Social Media)
Tab này quản lý các liên kết đến trang Mạng xã hội của doanh nghiệp.

* **Các trường liên kết:** Zalo, Facebook, Youtube, Tiktok, WhatsApp, Shopee, Lazada, Twitter, Instagram, Pinterest.
* **Định dạng:** Các trường này lưu trữ Key định danh (Ví dụ: `WEBSITE_FACEBOOK`).

## 3. CSS & JS (Custom Code)
Tab này cho phép chèn mã tùy chỉnh (custom code) vào website.

* **Các khu vực chèn mã:**
    * **CSS:** Cho phép nhập mã CSS tùy chỉnh.
    * **JS (JavaScript):** Cho phép nhập mã JavaScript tùy chỉnh.

## 4. Thông tin thanh toán (Payment Info)
Tab này quản lý các thông tin tài khoản ngân hàng hoặc các phương thức thanh toán khác.

* **Quản lý danh sách:** Được quản lý dưới dạng bảng, cho phép thêm mới nhiều tài khoản.
* **Các cột:** `Tên ngân hàng`, `Chủ tài khoản`, `Số tài khoản`.
* **Nút hành động:** `+ Thêm mới`.

## 5. Email server
Tab này chứa các thông số cấu hình máy chủ gửi/nhận Email (SMTP).

* **Các trường cấu hình:**
    * **Email người nhận (Recipient):** `PRIMARY_EMAIL`, `SECONDARY_EMAIL`.
    * **Email server (SMTP):** `Username host mail` (`noreply@gozone.vn`), `Password`.
    * **Thông số kỹ thuật:** `Title email`, `Host email` (`mail.gozone.vn`), `Port email` (`25`), `Encryption email` (None/SSL/TLS).
    * **Template:** Có liên kết `Danh sách Email Template` để quản lý các mẫu thư gửi tự động.

## 6. Key config website (API Keys)
Tab này quản lý các khóa API quan trọng để tích hợp với các dịch vụ bên ngoài.

* **Tích hợp:** Google Analytics, Google Key (for login), Facebook Key (for login), Zalo Key (for login), ReCaptcha V3.
* **Các trường:** Mỗi dịch vụ yêu cầu `Client ID`, `Client Secret` hoặc `API Key/SiteKey/SecretKey`.
* **Trạng thái:** Có Toggle `Đang hoạt động` để bật/tắt từng tích hợp.

## 7. Config website (Global Settings)
Tab này chứa các thiết lập toàn cục (global settings) ảnh hưởng đến hiệu suất và hành vi của website.

* **Thông số kích thước:** `Page Size` cho `Post category`, `Product category`, `Comment`, `Tag`, `Breadcrumb`.
* **Hiệu suất:** Toggle `On/Off cache`.
* **Tỷ giá:** `Exchange Rate` (Ví dụ: `1 USD = 24000 VND`).
* **Validation & Bảo trì:** Toggle `Show/Hide page validate age (18+)` và `Show/Hide page comming soon/maintenance`.