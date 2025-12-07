# 14. Giao diện

Module **Giao diện** (Themes/Design) quản lý các thành phần trực quan và cấu hình hiển thị của website, bao gồm thư viện media, menu điều hướng, form và các tùy chỉnh bố cục (layout).

## 1. Quản lý hình ảnh

### 1.1 Thư viện

Module **Thư viện** là nơi lưu trữ tập trung tất cả các tệp media.
* **Đường dẫn (Route):** `/imageslib`.

* **Tiêu đề:** `QUẢN LÝ ẢNH`.
* **Giao diện:** Dạng trình quản lý tệp tin (File Explorer).
* **Thanh công cụ:** Bao gồm các nút Tải lên, Thêm thư mục mới, Xóa, và chuyển đổi Chế độ xem.

### 1.2 File manager

Phần **File Manager** cung cấp giao diện chi tiết để quản lý, tối ưu kích thước nếu tệp tin > 500MB, theo dõi và xem trước các tệp tin media.
* **Đường dẫn (Route):** `/filemanager`.

* **Tiêu đề:** `QUẢN LÝ FILE`.
* **Thống kê:** Hiển thị biểu đồ Donut và phân loại dung lượng lưu trữ (Ví dụ: `Media` đang sử dụng `11.67 MB`).
* **Thông tin chi tiết tệp:** Bao gồm `File Name`, `File Type`, `Size`, `Ngày cập nhật`, `Dimensions` (kích thước vật lý), và `Path` (Đường dẫn URL).

## 2. Banner – Logo

Module này quản lý các thành phần hình ảnh quan trọng như Logo, Favicon và các Banner/Popup.
* **Đường dẫn (Route):** `/banners`.

* **Tiêu đề:** `QUẢN LÝ BANNER-LOGO`.

### 2.1. Cấu hình Logo & Favicon
* **Cấu hình:** Cho phép upload ảnh cho `Favicon`, `Logo Header`, `Logo Mobile`, và `Logo Footer`.
* **Chi tiết Ảnh:** Có các trường `Alt` (Mô tả thay thế), `Url` (Đường dẫn), và `Opt` (Tùy chọn).

### 2.2. Cấu hình Popup
* **Cấu hình:** Cho phép quản lý banner hiển thị dưới dạng Popup quảng cáo.
* **Danh sách Banner:** Quản lý hình ảnh cho cả giao diện **Desktop** và **Mobile**.

## 3. Quản lý menus

Module **Quản lý menus** cho phép quản trị viên tạo và cấu hình các khối menu điều hướng (Ví dụ: Header Menu, Footer Menu).
* **Đường dẫn (Route):** `/menus`.

* **Tiêu đề:** `QUẢN LÝ MENUS`.

### 3.1. Danh sách Menus (List View)
* **Bảng dữ liệu:** Hiển thị `Tiêu đề` (`Header`, `Footer`), `Trạng thái` (`ĐANG HOẠT ĐỘNG`).

### 3.2. Modal Thêm mới Menu (Quick Add)
* **Trường:** `Tiêu đề *`, `URL *`, `Đang hoạt động`.

### 3.3. Giao diện Cấu hình Menu (Edit View)
Giao diện này cho phép cấu hình chi tiết các liên kết và cấu trúc phân cấp của menu (tối đa 3 cấp).

* **Thông tin cơ bản Menu Block:** `Tiêu đề *`, `URL *`.
* **Quản lý Mục và Menu Con (Item Management):**
    * **Cấu trúc Menu:** Xây dựng theo mô hình phân cấp.
    * **Di chuyển:** Nút mũi tên cho phép thay đổi vị trí/cấp độ.
    * **Sửa:** Chỉnh sửa Tiêu đề và URL của mục.
    * **Quản lý menu con:** Cho phép thêm/sửa/xóa các mục menu cấp dưới.
    * **Xóa:** Nút xóa mục menu.
## 4. Quản lý forms

Module này cho phép tạo và cấu hình các biểu mẫu (forms) thu thập dữ liệu (Ví dụ: Form Liên hệ).
* **Đường dẫn (Route):** `/forms`.

* **Tiêu đề:** `QUẢN LÝ FORMS`.

### 4.1. Giao diện Cấu hình Form (Edit View)
* **Cấu hình Backend:** Bao gồm `ID Name *`, `Action Form *`, `Link Google Sheet/Monday API...`, và `Link Call back`.
* **Cấu trúc Form:** Cho phép xây dựng các trường nhập liệu (field) (tối đa 2 cấp form).
* **Quản lý trường:** Mỗi trường có thuộc tính `Type *` (Ví dụ: `input[type=text]`), `Name *`, và `Chọn trạng thái *` (bắt buộc/không bắt buộc).

## 5. Tùy chỉnh giao diện

### 5.1 Trang chủ

Module **Tùy chỉnh Trang chủ** cho phép cấu hình nội dung và bố cục của trang chủ thông qua các block nội dung (sections).
* **Đường dẫn (Route):** `/themesettings/homepage`.

* **Tiêu đề:** `TÙY CHỈNH TRANG CHỦ`.
* **Danh sách Block:** Liệt kê các section xây dựng trang chủ (Ví dụ: `mainSlider`, `section1`, `video`).
* **Cấu hình Block:** Mỗi block có thể được tùy chỉnh chi tiết thông qua bảng dữ liệu (`Desktop`, `Mobile`, `Hình ảnh`, `Nội dung`).

### 5.2 Header

Module **Tùy chỉnh Header** cho phép cấu hình nội dung và bố cục của header thông qua các block nội dung (sections).
* **Đường dẫn (Route):** `/themesettings/headerpage`.

### 5.3 Footer

Module **Tùy chỉnh Header** cho phép cấu hình nội dung và bố cục của footer thông qua các block nội dung (sections).
* **Đường dẫn (Route):** `/themesettings/footerpage`.

### 5.4 Nội dung mặc định

Module **Tùy chỉnh Header** cho phép cấu hình nội dung và bố cục của dùng chung cho các trang (lợi ít của website...) thông qua các block nội dung (sections).
* **Đường dẫn (Route):** `/themesettings/defaultcontent`.