# 08. Sản phẩm

Module Sản phẩm là trung tâm quản lý tất cả các sản phẩm, dịch vụ, và các yếu tố liên quan như danh mục, thương hiệu, thuộc tính và coupon.

## 1. Danh mục sản phẩm

Module này cho phép tạo và quản lý cấu trúc phân cấp (hierarchy) cho các sản phẩm, giúp người dùng dễ dàng tìm kiếm và điều hướng trên website.

* **Đường dẫn (Route):** `/products/category`.

### 1.1. Danh sách Danh mục (List View)
Hiển thị danh sách các danh mục sản phẩm đang tồn tại.

#### A. Công cụ lọc và tìm kiếm
| Chức năng | Mô tả |
| :--- | :--- |
| **Tìm kiếm** | Ô nhập liệu cho phép lọc theo từ khóa |
| **Chọn trạng thái** | Dropdown cho phép lọc theo trạng thái (`Đang hoạt động`/`Không hoạt động`). |

#### B. Bảng dữ liệu
| Cột | Dữ liệu mẫu |
| :--- | :--- |
| **Tiêu đề** | `Quần`. |
| **Trạng thái** | `ĐANG HOẠT ĐỘNG`. |
| **Giao diện** | `Default`. |
| **Hành động** | Bao gồm: `Chỉnh sửa` và `Xóa`. |

### 1.2. Thêm mới / Cấu hình Danh mục (Add / Configuration)
Modal `THÊM MỚI DANH MỤC` và giao diện chỉnh sửa chi tiết.

* **Thông tin cơ bản:** `Danh mục cha`, `Tiêu đề *`, `Mô tả`, `Nội dung` (Rich Text Editor), `Ảnh đại diện`.
* **SEO:** `URL *`, `Meta SEO title *`.
* **Schema :** `Schema`, `Thumbnail (1200x630): dùng để chia sẻ các mạng xã hội`.
* **Trạng thái:** `Đang hoạt động`, `Không được xóa`.
* **Bộ lọc:** Cho phép liên kết `Thương hiệu` và `Thuộc tính sản phẩm`.
* **Giao diện:** Quản lý giao diện của ở dưới cùng.

---

## 2. Danh sách sản phẩm

Module này quản lý toàn bộ các sản phẩm thường.

* **Đường dẫn (Route):** `/products`.

### 2.1. Danh sách Sản phẩm (List View)

* **Bộ lọc:** `Tìm kiếm`, `Chọn trạng thái`, `Chọn danh mục`.
* **Bảng dữ liệu:** Hiển thị `Tiêu đề` (kèm `Số lượng tồn kho`), `Giá tiền` (`1.500.000 đ`), `Danh mục` (`Quần`), `Trạng thái`.

### 2.2. Modal Thêm mới Sản phẩm (Quick Add)
* **Trường:** `Danh mục *`, `Tiêu đề *`, `URL *`, `Meta SEO title *`, `SKU *`, `Số lượng`, `Giá tiền`.

### 2.3. Giao diện Cấu hình Sản phẩm (Edit View)
* **Thông tin cơ bản:** `Danh mục sản phẩm chính và danh mục sản phẩm phụ`, `Tiêu đề *`, `Mô tả`, `Nội dung` (Rich Text Editor), `Ảnh đại diện`.
* **SKUs:** Bảng quản lý các biến thể sản phẩm. Nút `+ Thêm mới` mở modal nhập `SKU *`, `Số lượng`, `Giá tiền *`.
* **SEO:** `URL *`, `Meta SEO title *`.
* **Schema :** `Schema`, `Thumbnail (1200x630): dùng để chia sẻ các mạng xã hội`.
* **Đánh giá :** `Lượt xem`, `Tổng đánh giá`, `Đánh giá trung bình`, `Đánh giá cao nhất`, `Đánh giá thấp nhất`.
* **Qr Code :** Tự động tạo mã QR CODE cho sản phẩm.
* **Trạng thái:** `Đang hoạt động`, `Không được xóa`.
* **Bộ lọc:** Cho phép liên kết `Thương hiệu` và `Thuộc tính sản phẩm`.
* **Giao diện:** Quản lý giao diện của ở dưới cùng.

---

## 3. Sản phẩm du lịch

Module quản lý các sản phẩm có yếu tố lịch trình (Tour, Sự kiện).

* **Đường dẫn (Route):** `/products/travel`.

### 3.1. Danh sách Sản phẩm Du lịch (List View)
* **Bảng dữ liệu:** Hiển thị `Tiêu đề` (kèm `Số lượng: 10`), `Giá tiền` (`55.000.000 đ`), `Danh mục` (`Đông Nam Á`).

### 3.2. Cấu hình Sản phẩm Du lịch (Edit View)
* **Thông tin cơ bản:** `Danh mục sản phẩm chính và danh mục sản phẩm phụ`, `Tiêu đề *`, `Mô tả`, `Nội dung` (Rich Text Editor), `Ảnh đại diện`.
* **SKUs (Lịch trình):** Khu vực quản lý lịch khởi hành, bao gồm `Lịch` theo tháng.
    * **Danh sách lịch trình:** Hiển thị `SKU`, `Tổng cộng` (`140`), `Giá tiền` (`55.000.000 đ`), `Ngày bắt đầu`.
    * **Modal Thêm mới SKU:** Cho phép chọn `Danh sách ngày khởi hành` (Ví dụ: `08/12/2025`, `09/12/2025`).
* **SEO:** `URL *`, `Meta SEO title *`.
* **Schema :** `Schema`, `Thumbnail (1200x630): dùng để chia sẻ các mạng xã hội`.
* **Đánh giá :** `Lượt xem`, `Tổng đánh giá`, `Đánh giá trung bình`, `Đánh giá cao nhất`, `Đánh giá thấp nhất`.
* **Qr Code :** Tự động tạo mã QR CODE cho sản phẩm.
* **Trạng thái:** `Đang hoạt động`, `Không được xóa`.
* **Bộ lọc:** Cho phép liên kết `Thuộc tính sản phẩm`.
* **Giao diện:** Quản lý giao diện của ở dưới cùng.

---

## 4. Nhóm sản phẩm

Module quản lý các bộ sưu tập sản phẩm tùy chỉnh (Ví dụ: Sản phẩm nổi bật).

* **Đường dẫn (Route):** `/products/group`.

### 4.1. Danh sách Nhóm sản phẩm (List View)
* **Bảng dữ liệu:** Hiển thị `Tiêu đề` (`Sản phẩm nổi bật`), `Trạng thái`, `Loại` (`Mặc định`), `Giao diện`.

### 4.2. Giao diện Cấu hình Nhóm Sản phẩm (Edit View)
* **Cấu hình:** Cho phép chọn **Loại** nhóm (Dropdown: Mặc định / Random / Mới nhất).
* **SEO:** `Tiêu đề SEO *`, `Mô tả SEO`, `URL *`.
* **Schema :** `Schema`, `Thumbnail (1200x630): dùng để chia sẻ các mạng xã hội`.
* **Quản lý Sản phẩm trong Nhóm:**
    * `Sản phẩm (Thường)`: Bảng liệt kê sản phẩm thường đã thêm.
    * `Sản phẩm (Du lịch)`: Bảng liệt kê sản phẩm du lịch đã thêm.
    * **Modal Thêm loạt sản phẩm:** Cho phép chọn sản phẩm từ danh sách (cả thường và du lịch) để thêm vào nhóm.
* **Giao diện:** Quản lý giao diện của ở dưới cùng.

---

## 5. Thương hiệu

Module quản lý danh sách các Thương hiệu (Brand).

* **Đường dẫn (Route):** `/brands`.

### 5.1. Danh sách Thương hiệu (List View)
* **Bảng dữ liệu:** Hiển thị `Tiêu đề` (`Brand_1765035211373`), `Trạng thái`.

### 5.2. Modal Thêm mới Thương hiệu (Quick Add)
* **Trường:** `Tiêu đề *`, `URL *`, `Đang hoạt động`.

### 5.3. Giao diện Cấu hình Thương hiệu (Edit View)
* **Thông tin cơ bản:** `Số thứ tự`, `Ảnh đại diện`.
* **SEO:** `Tiêu đề SEO *`, `Mô tả SEO`, `URL *`.
* **Schema :** `Schema`, `Thumbnail (1200x630): dùng để chia sẻ các mạng xã hội`.
* **Giao diện:** Quản lý giao diện của ở dưới cùng.

---

## 6. Coupon

Module quản lý các mã khuyến mãi (voucher/coupon).

* **Đường dẫn (Route):** `/coupons`.

### 6.1. Danh sách Coupon (List View)
* **Bảng dữ liệu:** Hiển thị `CODE` (`CODE_1765035544764`), `Tiêu đề` (kèm `Số lượng: 10`, `Giá trị: 10%`).

### 6.2. Modal Thêm mới Coupon (Quick Add)
* **Trường:** `Code *`, `Số lượng`, `Giá trị *` (Dropdown: `Phần trăm` / Giá tiền), `Giá trị tiền lớn nhất`.

### 6.3. Giao diện Cấu hình Coupon (Edit View)
* **Quy tắc:** `Loại hình mã` (Giảm giá trên tổng đơn), `Khoảng giá được áp dụng`.
* **Thời gian:** `Ngày bắt đầu`, `Ngày kết thúc`.

---

## 7. Thuộc tính sản phẩm

Module định nghĩa các đặc tính phân loại sản phẩm (Kích cỡ, Màu sắc, Giá tiền).

### 7.1 Danh sách thuộc tính

* **Đường dẫn (Route):** `/attributes`.
* **Bảng dữ liệu:** Hiển thị `Tiêu đề` (`Giá tiền`, `Kích cỡ`, `Màu sắc`).
* **Modal Thêm mới:** `Tiêu đề *`, `URL *`.
* **Giao diện Cấu hình:** `Số thứ tự`, `Giao diện` (`Mặc định`).

### 7.2 Danh sách giá trị thuộc tính

* **Đường dẫn (Route):** `/attributes/attributevalues`.
* **Bảng dữ liệu:** Hiển thị `Tiêu đề` (`Màu trắng`).
* **Modal Thêm mới:** `Giá trị` (Dropdown: `String`, `Number`, `Khoảng giá`, `Color`, `Image`), `Tiêu đề *`, `URL *`.
* **Giao diện Cấu hình:** Cho phép chọn `Giá trị` là màu (Color picker).