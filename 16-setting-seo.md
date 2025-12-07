# 16. Cấu hình SEO

Module **Cấu hình SEO** (Search Engine Optimization) tập trung vào việc quản lý các thẻ meta, mã code tùy chỉnh và cấu hình Schema/Sitemap toàn cục, giúp tối ưu hóa website cho các công cụ tìm kiếm.

* **Đường dẫn (Route):** `/seosettings`.

## 1. Cấu hình cơ bản

Tab này chứa các thông số SEO tổng quát ảnh hưởng đến toàn bộ website, đặc biệt là cấu hình hiển thị trên các nền tảng mạng xã hội (Open Graph).

* **Hỗ trợ đa ngôn ngữ:** Có 2 tabs `VI` và `EN`.

### 1.1. Thông tin SEO chung
| Trường | Mô tả | Giá trị lưu trữ mẫu |
| :--- | :--- | :--- |
| **Tiêu đề SEO trang chủ** | Thẻ `<title>` cho trang chủ. | `INDEX_META_TITLE_VI`. |
| **Mô tả SEO trang chủ** | Thẻ `<meta name="description">` cho trang chủ. | `INDEX_META_DESCRIPTION_VI`. |

### 1.2. Hình ảnh Share Facebook (Open Graph Image)
Khu vực này cho phép tải lên hình ảnh được sử dụng khi chia sẻ website lên Facebook và các mạng xã hội khác.

### 1.3. Chèn Mã Code Tùy chỉnh (Global Custom Code)
Khu vực này cho phép chèn các đoạn mã quan trọng vào các vị trí cố định của tệp HTML.

* **Chèn code ở trong thẻ `<head>`:** Thường dùng cho các mã xác minh, Google Analytics.
* **Chèn code ngay sau thẻ `<body>`:** Vị trí lý tưởng cho các mã theo dõi hiển thị ngay khi trang tải.
* **Chèn code ở cuối thẻ `<body>`:** Thường dùng cho các mã JavaScript không quan trọng, cần tải sau cùng.

## 2. Cấu hình nâng cao

Tab này chứa các thiết lập SEO kỹ thuật, cho phép quản trị viên tùy chỉnh các tệp quan trọng liên quan đến việc thu thập dữ liệu (crawling).
* **Đường dẫn (Route):** `/seosettings/advanceseosetting`.

### 2.1. Cấu hình File Sitemap và Robots
Khu vực này cho phép tùy chỉnh nội dung của các file quan trọng cho việc lập chỉ mục.

* **Sitemap.xml:** Trường hiển thị đường dẫn hoặc nội dung của file sitemap.
* **Robots.txt:** Khu vực Text Area cho phép tùy chỉnh các lệnh `Allow` và `Disallow` cho các bot thu thập dữ liệu.
    * **Lệnh Disallow mẫu:** Ngăn chặn truy cập vào các thư mục quản trị và chức năng hệ thống (Ví dụ: `/admin/`, `/register/`, `/login/`, `/forgot-password/`).
    
* **Llms.txt:** Khu vực Text Area cho phép tùy chỉnh các lệnh `Allow` và `Disallow` cho các AI thu thập dữ liệu.

## 3. Cáu hình Schema

Tab này cho phép quản trị viên quản lý và tùy chỉnh các đánh dấu dữ liệu có cấu trúc (Schema Markup) được nhúng vào website.
* **Đường dẫn (Route):** `/seosettings/schemasetting`.

* **Tiêu đề:** `CẤU HÌNH SCHEMA`.

### 3.1. Cấu hình theo Loại Schema (Schema Type)
Giao diện được phân loại theo các loại Schema thường gặp thông qua các Tabs:
* **Các loại Schema có sẵn (Tabs):** `Schema Index`, `Schema Page`, `Schema Product Category / Schema Product`, `Schema Post Category / Schema Post`.

### 3.2. Khu vực Tùy chỉnh Mã Schema
* **Trường chỉnh sửa:** Hiển thị mã JSON-LD hiện tại (Ví dụ: `SCHEMA_INDEX_VI`).
* **Nút hành động:** `Bật lại mặc định` và `Lưu`.

### 3.3. Hướng dẫn và Biến Hệ thống
* **Biến động (Variables) mẫu:** Cho phép sử dụng các biến toàn cục như `[website_name]`, `[website_url]`, `[website_email]`, `[website_facebook]`, v.v., trong mã Schema.