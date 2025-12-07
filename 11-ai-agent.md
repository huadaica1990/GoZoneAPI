# 11. AI Agent

Module **AI Agent** quản lý các công cụ tự động hóa nội dung, bao gồm việc tạo và theo dõi các từ khóa gốc (Seed words) và chủ đề (Topic) để phục vụ cho việc phát triển nội dung.

## 1. Seed words

### 1.1 Danh sách từ khóa

Module **Danh sách từ khóa** (Seed words) cho phép quản trị viên nhập, quản lý và theo dõi trạng thái của các từ khóa gốc được sử dụng làm đầu vào cho quá trình tạo nội dung bằng AI.

* **Đường dẫn (Route):** `/aiagents/niches`.
* **Tiêu đề:** `DANH SÁCH TỪ KHÓA`.

#### A. Công cụ tìm kiếm và lọc
| Chức năng | Mô tả |
| :--- | :--- |
| **Tìm kiếm** | Ô nhập liệu cho phép lọc theo từ khóa. |
| **10 Hàng** | Dropdown chọn số lượng bản ghi hiển thị. |

#### B. Nút hành động
| Nút | Mô tả |
| :--- | :--- |
| `+ Đánh dấu sẵn sàng` | Hành động hàng loạt, có thể là chuyển trạng thái các từ khóa đã chọn sang `Sẵn sàng`. |
| `+ Thêm mới` | Mở Modal `THÊM MỚI` để tạo từ khóa mới. |

#### C. Bảng dữ liệu
| Cột | Mô tả / Dữ liệu mẫu |
| :--- | :--- |
| **Tiêu đề** | Tên của từ khóa gốc (Ví dụ: `Khóa học 123`). |
| **Người tạo** | Tên người dùng tạo từ khóa (Ví dụ: `gozone`). |
| **Ngày tạo** | Thời gian từ khóa được tạo. |
| **Sẵn sàng** | Trạng thái cho biết từ khóa đã sẵn sàng để xử lý (Checkbox). |
| **Hoàn thành** | Trạng thái cho biết quá trình xử lý từ khóa đã hoàn tất (Checkbox). |
| **Hành động** | Bao gồm `Chỉnh sửa` và `Xóa`. |

#### D. Modal Thêm mới Từ khóa
Modal này được sử dụng để nhập một từ khóa gốc mới.
* **Tiêu đề Modal:** `THÊM MỚI`.
* **Trường nhập liệu:** `Seed word *`.
* **Trạng thái:** Toggle `Sẵn sàng` và `Hoàn thành`.
* **Nút hành động:** `Thêm mới` và `Đóng`.

### 1.2 Danh sách topic

Module **Danh sách topic** quản lý các chủ đề (Topics) được tạo ra dựa trên các từ khóa gốc (Seed words), dùng để phát triển các bài viết chi tiết hơn bằng AI.

* **Đường dẫn (Route):** `/aiagents/topiccontents`.
* **Tiêu đề:** `DANH SÁCH TOPIC`.

#### A. Công cụ tìm kiếm và lọc
| Chức năng | Mô tả |
| :--- | :--- |
| **Tìm kiếm** | Ô nhập liệu cho phép lọc theo từ khóa. |
| **Chọn danh mục** | Dropdown cho phép lọc theo danh mục. |
| **10 Hàng** | Dropdown chọn số lượng bản ghi hiển thị. |

#### B. Nút hành động
| Nút | Mô tả |
| :--- | :--- |
| `+ Đánh dấu sẵn sàng` | Chuyển trạng thái các topic đã chọn sang `Sẵn sàng`. |
| `+ Thêm mới` | Mở Modal `THÊM MỚI` để tạo topic mới. |

#### C. Bảng dữ liệu
| Cột | Mô tả / Dữ liệu mẫu |
| :--- | :--- |
| **Niche** | Nhóm chủ đề hoặc danh mục của Topic (Ví dụ: `du hoc`). |
| **Tiêu đề** | Tên của Topic (Ví dụ: `Khóa học 123`). |
| **Người tạo** | Tên người dùng tạo Topic (Ví dụ: `gozone`). |
| **Ngày tạo** | Thời gian Topic được tạo. |
| **Sẵn sàng** | Trạng thái Topic đã sẵn sàng để xử lý (Checkbox). |
| **Đang viết** | Trạng thái cho biết Topic đang được AI xử lý/viết bài (Checkbox). |
| **Hoàn thành** | Trạng thái cho biết Topic đã hoàn tất (Checkbox). |
| **Hành động** | Bao gồm `Chỉnh sửa` và `Xóa`. |

#### D. Modal Thêm mới Topic
Modal này được sử dụng để nhập một chủ đề mới.
* **Trường nhập liệu:** `Seed word *` (Dropdown chọn từ khóa gốc), `Tiêu đề *`, `Mô tả`, `URL *` (giới hạn `0/250` ký tự).
* **Trạng thái:** Toggle `Sẵn sàng`, `Đang viết`, `Hoàn thành`.
* **Nút hành động:** `Thêm mới` và `Đóng`.