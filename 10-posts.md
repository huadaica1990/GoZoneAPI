# 10. Tin tức

Module **Tin tức** quản lý nội dung dạng bài viết, bao gồm các danh mục, bài viết chi tiết và các sự kiện.

## 1. Danh mục tin tức

Module này cho phép tạo và quản lý cấu trúc phân cấp cho các bài viết.

* **Đường dẫn (Route):** `/posts/category`.

### 1.1. Danh sách Danh mục Tin tức (List View)

* **Tiêu đề:** `DANH MỤC TIN TỨC`.
* **Nút hành động:** `+ Thêm mới` mở modal cấu hình danh mục.

#### A. Bảng dữ liệu
| Cột | Dữ liệu mẫu |
| :--- | :--- |
| **Tiêu đề** | `Tin tức`. |
| **Trạng thái** | `ĐANG HOẠT ĐỘNG`. |
| **Giao diện** | `Default`. |
| **Hành động** | Bao gồm: `Chỉnh sửa` và `Xóa`. |

### 1.2. Cấu hình Danh mục Tin tức (Configuration)
* **Hỗ trợ đa ngôn ngữ:** `VI`, `EN`.
* **Trường:** `Danh mục cha`, `Tiêu đề *`, `URL *` (giới hạn `31/250` ký tự), `Meta SEO title *` (giới hạn `17/70` ký tự).
* **SEO:** `URL *`, `Meta SEO title *`.
* **Schema :** `Schema`, `Thumbnail (1200x630): dùng để chia sẻ các mạng xã hội`.
* **Trạng thái:** Toggle `Đang hoạt động` và `Không được xóa`.
* **Giao diện:** Quản lý giao diện của ở dưới cùng.

---

## 2. Danh sách tin tức

Module này quản lý toàn bộ các bài viết (post) đã được đăng tải trên hệ thống.

* **Đường dẫn (Route):** `/posts`.

### 2.1. Danh sách Bài viết (List View)
* **Bảng dữ liệu:** Hiển thị `Tiêu đề` (kèm `Ngày tạo`), `Danh mục` (`Tin tức`), `Trạng thái`.

### 2.2. Modal Thêm mới Tin tức (Quick Add)
* **Trường:** `Danh mục *`, `Tiêu đề *`, `URL *` (giới hạn `27/250` ký tự), `Meta SEO title *` (giới hạn `13/70` ký tự).
* **Trạng thái:** Toggle `Đang hoạt động`.

### 2.3. Giao diện Cấu hình Bài viết (Edit View)
* **Thông tin cốt lõi:** `Tiêu đề *`, `Mô tả`, `Nội dung` (Rich Text Editor).
* **Cấu hình:** `Danh mục *`, `Danh mục phụ`, `Tags/Nhãn`.
* **SEO:** `Tiêu đề SEO *`, `URL *` (giới hạn `27/250` ký tự), `Focus keyword`.
* **Schema :** `Schema`, `Thumbnail (1200x630): dùng để chia sẻ các mạng xã hội`.
* **Trạng thái:** Toggle `Đang hoạt động` và `Không được xóa`.
* **Giao diện:** Quản lý giao diện của ở dưới cùng.

---

## 3. Sự kiện

Module **Sự kiện** quản lý các bài viết có liên quan đến ngày tháng và địa điểm cụ thể.

* **Đường dẫn (Route):** `/posts/event`.

### 3.1. Danh sách Sự kiện (List View)
* **Bảng dữ liệu:** Hiển thị `Tiêu đề` (kèm `Ngày tạo`), `Danh mục` (`Sự kiện`), `Trạng thái`.

### 3.2. Modal Thêm mới Sự kiện (Quick Add)
* **Trường:** `Danh mục *`, `Tiêu đề *`, `URL *` (giới hạn `28/250` ký tự), `Meta SEO title *` (giới hạn `14/70` ký tự).

### 3.3. Giao diện Cấu hình Sự kiện (Edit View)
* **Thông tin cốt lõi:** `Tiêu đề *`, `Mô tả`, `Nội dung` (Rich Text Editor).
* **Cấu hình:** `Danh mục *`, `Danh mục phụ`, `Tags/Nhãn`.
* **SEO:** `Tiêu đề SEO *`, `URL *` (giới hạn `27/250` ký tự), `Focus keyword`.
* **Schema :** `Schema`, `Thumbnail (1200x630): dùng để chia sẻ các mạng xã hội`.
* **Trạng thái:** Toggle `Đang hoạt động` và `Không được xóa`.
* **Giao diện:** Quản lý giao diện của ở dưới cùng.
* **Thông tin cơ bản Sự kiện (Chuyên biệt):**
    * `Ngày bắt đầu/Ngày kết thúc` (Trường chọn ngày và giờ).
    * `Bản đồ` (URL và `iframe src` code), `Địa chỉ`.

---

## 4. Nhóm tin tức

Module **Nhóm tin tức** cho phép quản trị viên tạo các nhóm bài viết tùy chỉnh (Ví dụ: Tin tức nổi bật).

* **Đường dẫn (Route):** `/posts/group`.

### 4.1. Danh sách Nhóm Tin tức (List View)
* **Bảng dữ liệu:** Hiển thị `Tiêu đề` (`Tin tức nổi bật`), `Trạng thái`, `Loại` (`Mặc định`), `Giao diện`.

### 4.2. Giao diện Cấu hình Nhóm Tin tức (Edit View)
* **Cấu hình:** Cho phép chọn **Loại** nhóm (Dropdown: Mặc định / Random / Mới nhất).
* **SEO:** `Tiêu đề SEO *` (giới hạn `15/70` ký tự), `URL *` (giới hạn `17/250` ký tự).
* **Schema :** `Schema`, `Thumbnail (1200x630): dùng để chia sẻ các mạng xã hội`.
* **Quản lý Bài viết trong Nhóm:** Bảng `Luật bài viết` cho phép thêm các bài viết vào nhóm.
    * **Modal Thêm loạt Bài viết:** Cho phép chọn bài viết từ danh sách (Ví dụ: `Việt Nam Post_1765038877633`).
* **Giao diện:** Quản lý giao diện của ở dưới cùng.