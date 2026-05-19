# 🛡 Edge And Chrome AI Block

> Công cụ chặn và dọn dẹp tính năng AI cục bộ trên trình duyệt Chrome & Edge — nhanh, gọn, không cần cài đặt.

[![Platform](https://img.shields.io/badge/platform-Windows-blue)](https://www.microsoft.com/windows)
[![Framework](https://img.shields.io/badge/.NET-4.5.2-purple)](https://dotnet.microsoft.com)
[![License](https://img.shields.io/badge/license-MIT-green)](LICENSE)
[![Admin](https://img.shields.io/badge/requires-Administrator-red)]()

---

## Vấn Đề

Từ năm 2024, Google Chrome và Microsoft Edge âm thầm tải về các mô hình AI (~4GB) lưu thẳng vào ổ cứng máy người dùng mà không hỏi ý kiến. Điều này gây ra:

- **Tốn dung lượng ổ cứng** lên đến 4GB mà không được thông báo
- **Ảnh hưởng hiệu suất** do trình duyệt chạy mô hình AI ngầm
- **Mất quyền kiểm soát** dữ liệu và tài nguyên máy tính cá nhân

---

## Tính Năng

| Tính năng | Mô tả |
|---|---|
| 🚫 **Chặn AI** | Ghi Policy Registry ngăn Chrome & Edge tải mô hình AI |
| ✅ **Hoàn Nguyên** | Xóa Policy, trình duyệt tự tải lại AI khi cần |
| 🧹 **Dọn Rác** | Xóa toàn bộ file AI (~4GB) trên mọi Profile |
| 🔍 **Kiểm Tra** | Mở thẳng `chrome://policy` để xác nhận kết quả |
| 📋 **Nhật Ký** | Log real-time từng bước xử lý chi tiết |

---

## Yêu Cầu Hệ Thống

- Windows 10 / 11 (64-bit)
- Quyền **Administrator** (tool tự yêu cầu qua UAC khi khởi động)
- .NET Framework 4.5.2 trở lên (có sẵn trên Windows 10+)

---

## Cách Dùng

1. **Tải file `.exe`** từ trang [Releases](../../releases)
2. **Click chuột phải → Run as Administrator** (hoặc double-click, UAC sẽ tự hỏi)
3. Bấm nút phù hợp với nhu cầu:

```
┌─────────────────────────────────────────────────────────┐
│  🛡  AI Block & Clean Tool                              │
├─────────────────────────────────────────────────────────┤
│                                                         │
│  [ 🚫  CHẶN AI ]   [ ✅  HOÀN NGUYÊN ]   [ 🔍 ]        │
│                                                         │
├─────────────────────────────────────────────────────────┤
│  NHẬT KÝ HOẠT ĐỘNG                                      │
│  [BƯỚC 1] Ép tắt tiến trình trình duyệt...              │
│    ✔ Chrome: đã gửi lệnh tắt 3 tiến trình.             │
│    ✔ Edge  : đã gửi lệnh tắt 2 tiến trình.             │
│  [BƯỚC 2A] Ghi Registry - KHÓA VAN...                   │
│    ✔ Chrome Policy: = 1 (ĐÃ CHẶN)                      │
│  [BƯỚC 3A] Quét đa Profile & xóa mô hình AI...         │
│    ✔ [Chrome/Default] Đã xóa (412 MB): OptGuide        │
└─────────────────────────────────────────────────────────┘
```

### Kiểm Tra Kết Quả

Sau khi chạy, bấm nút **🔍** hoặc mở Chrome và gõ vào thanh địa chỉ:

```
chrome://policy
```

- **Sau CHẶN**: Tìm dòng `GenAILocalFoundationalModelSettings` → Value = `1`
- **Sau HOÀN NGUYÊN**: Dòng đó phải biến mất hoàn toàn

---

## Cách Hoạt Động

```
[Bấm nút] → Cảnh báo lưu công việc
          → Ép tắt Chrome/Edge (smart wait tối đa 5s)
          → Ghi/Xóa Registry Policy (Windows API 64-bit)
          → Quét & xóa folder AI trên mọi Profile
          → Hiện log kết quả + nhắc khởi động lại máy
```

**Registry bị tác động:**
```
HKLM\SOFTWARE\Policies\Google\Chrome\GenAILocalFoundationalModelSettings
HKLM\SOFTWARE\Policies\Microsoft\Edge\GenAILocalFoundationalModelSettings
```

**Thư mục AI bị xóa (trên mọi Profile):**
```
%LocalAppData%\Google\Chrome\User Data\[Profile]\OptimizationGuide
%LocalAppData%\Google\Chrome\User Data\[Profile]\optimization_guide_model_store
%LocalAppData%\Microsoft\Edge\User Data\[Profile]\OptimizationGuide
%LocalAppData%\Microsoft\Edge\User Data\[Profile]\EdgeWalletAIBundles
%LocalAppData%\Microsoft\Edge\User Data\[Profile]\GenAI
```

---

## Build Từ Source

**Yêu cầu:** Visual Studio 2019+ với .NET Framework 4.5.2

```bash
git clone https://github.com/<your-username>/frm_edAI_chrAI_block.git
cd frm_edAI_chrAI_block
```

Mở `frm_edAI_chrAI_block.slnx` trong Visual Studio → Build → Release.

> **Lưu ý:** Thêm `donate.jpg`, `tcb.jpg`, `momo.jpg` vào thư mục gốc trước khi build nếu muốn có ảnh donate (các file này không được commit lên repo).

---

## Điểm Kỹ Thuật Nổi Bật

- **Windows Registry API** thay vì `cmd.exe` → không bị Antivirus gắn cờ
- **`RegistryView.Registry64`** → tránh WOW64 redirect trên Windows 64-bit
- **`async/await + Task.Run`** → UI không đóng băng trong lúc xử lý
- **Multi-Profile scan** → dọn sạch cả `Default`, `Profile 1`, `Profile 2`...
- **Smart wait loop** → chờ tiến trình chết thật sự, không sleep cố định
- **Phân loại IOException** → thông báo lỗi thân thiện theo từng loại

---

## Đóng Góp

Pull requests và issues luôn được chào đón.  
Nếu tool hữu ích, hãy ⭐ star repo để ủng hộ tác giả.

---

## License

[MIT](LICENSE) © 2026
