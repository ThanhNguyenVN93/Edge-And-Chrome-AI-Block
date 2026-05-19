using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace frm_edAI_chrAI_block
{
    public enum Lang { VI, EN }

    internal static class Strings
    {
        public static Lang Current = Lang.VI;

        // ── Persistence ───────────────────────────────────────────────────────
        private static readonly string _cfgPath =
            Path.Combine(Application.UserAppDataPath, "lang.cfg");

        public static void Load()
        {
            try
            {
                if (File.Exists(_cfgPath) && File.ReadAllText(_cfgPath).Trim() == "EN")
                    Current = Lang.EN;
            }
            catch { }
        }

        public static void Save()
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(_cfgPath));
                File.WriteAllText(_cfgPath, Current == Lang.EN ? "EN" : "VI");
            }
            catch { }
        }

        public static void Toggle()
        {
            Current = Current == Lang.VI ? Lang.EN : Lang.VI;
            Save();
        }

        // ── String table: index 0 = VI, index 1 = EN ─────────────────────────
        private static readonly Dictionary<string, string[]> _t =
            new Dictionary<string, string[]>
        {
            // Form / UI
            ["FormTitle"]          = new[] { "AI Block & Clean Tool  [Administrator]",               "AI Block & Clean Tool  [Administrator]" },
            ["HeaderSubtitle"]     = new[] { "Kiểm soát tính năng AI trên Chrome & Edge  |  Yêu cầu quyền Administrator", "Control AI on Chrome & Edge  |  Requires Administrator" },
            ["BtnBlock"]           = new[] { "🚫  CHẶN AI",                                           "🚫  BLOCK AI" },
            ["BtnUnblock"]         = new[] { "✅  HOÀN NGUYÊN",                                       "✅  RESTORE" },
            ["LogSectionTitle"]    = new[] { "NHẬT KÝ HOẠT ĐỘNG",                                    "ACTIVITY LOG" },
            ["Footer"]             = new[] { "v1.0  |  Chạy với quyền Administrator  |  .NET 4.5.2", "v1.0  |  Running as Administrator  |  .NET 4.5.2" },
            ["BtnLang"]            = new[] { "🌐 EN",                                                 "🌐 VI" },

            // Confirm dialog
            ["ConfirmTitle"]       = new[] { "Cảnh Báo — Sắp Đóng Trình Duyệt",                     "Warning — Browsers Will Close" },
            ["ConfirmBody"]        = new[] { "Tool cần đóng toàn bộ cửa sổ Chrome và Edge để tiến hành xử lý.\n\nVui lòng lưu lại công việc của bạn trước khi bấm OK để tiếp tục.",
                                             "The tool needs to close all Chrome and Edge windows.\n\nPlease save your work before clicking OK to continue." },

            // Log — Step headers
            ["LogSep"]             = new[] { "════════════════════════════════════════",              "════════════════════════════════════════" },
            ["LogBeginBlock"]      = new[] { "  BẮT ĐẦU: CHẾ ĐỘ CHẶN AI TRÌNH DUYỆT",              "  START: BROWSER AI BLOCK MODE" },
            ["LogBeginUnblock"]    = new[] { "  BẮT ĐẦU: CHẾ ĐỘ HOÀN NGUYÊN (UNBLOCK)",            "  START: RESTORE MODE (UNBLOCK)" },

            // Log — Step 1
            ["LogStep1"]           = new[] { "[BƯỚC 1] Ép tắt tiến trình trình duyệt...",           "[STEP 1] Force-closing browser processes..." },
            ["LogChromeKilled"]    = new[] { "  ✔ Chrome: đã gửi lệnh tắt {0} tiến trình.",         "  ✔ Chrome: sent kill signal to {0} process(es)." },
            ["LogEdgeKilled"]      = new[] { "  ✔ Edge  : đã gửi lệnh tắt {0} tiến trình.",         "  ✔ Edge  : sent kill signal to {0} process(es)." },
            ["LogChromeError"]     = new[] { "  ⚠ Chrome: {0}",                                      "  ⚠ Chrome: {0}" },
            ["LogEdgeError"]       = new[] { "  ⚠ Edge  : {0}",                                      "  ⚠ Edge  : {0}" },
            ["LogWaiting"]         = new[] { "  ... Chờ hệ thống giải phóng file (tối đa 5 giây)...","  ... Waiting for OS to release file locks (max 5s)..." },
            ["LogReady"]           = new[] { "  ✔ Hệ thống đã sẵn sàng.",                            "  ✔ System is ready." },

            // Log — Step 2A (block)
            ["LogStep2A"]          = new[] { "[BƯỚC 2A] Ghi Registry - KHÓA VAN...",                "[STEP 2A] Writing Registry - BLOCKING..." },
            ["LogChromePolicyOn"]  = new[] { "  ✔ Chrome Policy: GenAILocalFoundationalModelSettings = 1 (ĐÃ CHẶN)",  "  ✔ Chrome Policy: GenAILocalFoundationalModelSettings = 1 (BLOCKED)" },
            ["LogEdgePolicyOn"]    = new[] { "  ✔ Edge Policy  : GenAILocalFoundationalModelSettings = 1 (ĐÃ CHẶN)",  "  ✔ Edge Policy  : GenAILocalFoundationalModelSettings = 1 (BLOCKED)" },
            ["LogChromePolicyErr"] = new[] { "  ⚠ Chrome Registry: {0}",                             "  ⚠ Chrome Registry: {0}" },
            ["LogEdgePolicyErr"]   = new[] { "  ⚠ Edge Registry: {0}",                               "  ⚠ Edge Registry: {0}" },

            // Log — Step 2B (unblock)
            ["LogStep2B"]          = new[] { "[BƯỚC 2B] Xóa Registry - MỞ VAN...",                  "[STEP 2B] Deleting Registry - UNBLOCKING..." },
            ["LogChromePolicyOff"] = new[] { "  ✔ Chrome Policy: GenAILocalFoundationalModelSettings đã XÓA (UNBLOCK)", "  ✔ Chrome Policy: GenAILocalFoundationalModelSettings DELETED (UNBLOCK)" },
            ["LogEdgePolicyOff"]   = new[] { "  ✔ Edge Policy  : GenAILocalFoundationalModelSettings đã XÓA (UNBLOCK)", "  ✔ Edge Policy  : GenAILocalFoundationalModelSettings DELETED (UNBLOCK)" },

            // Log — Step 3
            ["LogStep3"]           = new[] { "[BƯỚC 3A] Quét đa Profile & xóa mô hình AI (~4GB)...", "[STEP 3A] Scanning all Profiles & deleting AI models (~4GB)..." },
            ["LogNoUserData"]      = new[] { "  – [{0}] Không tìm thấy User Data (bỏ qua): {1}",    "  – [{0}] User Data not found (skipping): {1}" },
            ["LogDeleted"]         = new[] { "  ✔ [{0}/{1}] Đã xóa ({2} MB): {3}",                  "  ✔ [{0}/{1}] Deleted ({2} MB): {3}" },
            ["LogLocked"]          = new[] { "  ⚠ [{0}/{1}] '{2}': Thư mục đang bị một tiến trình khác giữ (OneDrive, Antivirus...). Vui lòng thử lại hoặc khởi động lại máy.",
                                             "  ⚠ [{0}/{1}] '{2}': Folder locked by another process (OneDrive, Antivirus...). Please retry or restart." },
            ["LogIOErr"]           = new[] { "  ⚠ [{0}/{1}] '{2}': File đang bị khóa. Vui lòng thử lại hoặc khởi động lại máy để xóa hoàn toàn.",
                                             "  ⚠ [{0}/{1}] '{2}': File is locked. Please retry or restart to delete completely." },
            ["LogErrGeneric"]      = new[] { "  ⚠ [{0}/{1}] Lỗi xóa '{2}': {3}",                   "  ⚠ [{0}/{1}] Error deleting '{2}': {3}" },

            // Log — Done (block)
            ["LogDoneBlockHdr"]    = new[] { "  HOÀN TẤT! Vui lòng KHỞI ĐỘNG LẠI MÁY",             "  DONE! Please RESTART YOUR COMPUTER" },
            ["LogDoneBlockSub"]    = new[] { "  để Windows áp dụng Policy mới nhất.",               "  for Windows to apply the new Policy." },
            ["LogCheckHdr"]        = new[] { "  🔍 KIỂM TRA KẾT QUẢ:",                              "  🔍 VERIFY RESULT:" },
            ["LogCheckLine1"]      = new[] { "  Mở Chrome → gõ: chrome://policy",                   "  Open Chrome → type: chrome://policy" },
            ["LogCheckLine2"]      = new[] { "  Tìm: GenAILocalFoundationalModelSettings",           "  Find: GenAILocalFoundationalModelSettings" },
            ["LogCheckLine3"]      = new[] { "  Kết quả đúng: Status=Mandatory, Value=1",            "  Expected: Status=Mandatory, Value=1" },

            // Log — Done (unblock)
            ["LogDoneUnblockHdr"]  = new[] { "  HOÀN TẤT! Hệ thống đã mở khóa.",                   "  DONE! System has been unlocked." },
            ["LogUXNote1"]         = new[] { "  ℹ️  LƯU Ý: Các file AI đã bị xóa trước đó",         "  ℹ️  NOTE: AI files previously deleted" },
            ["LogUXNote2"]         = new[] { "  sẽ được trình duyệt tự động tải lại ngầm",           "  will be automatically re-downloaded by the browser" },
            ["LogUXNote3"]         = new[] { "  từ máy chủ Google/Microsoft khi bạn dùng",           "  from Google/Microsoft servers when you use" },
            ["LogUXNote4"]         = new[] { "  các tính năng AI liên quan trên Web.",               "  related AI features on the Web." },
            ["LogUXNote5"]         = new[] { "  (Tự động, phụ thuộc vào tốc độ mạng)",               "  (Automatic, depends on network speed)" },
            ["LogUXNote6"]         = new[] { "  → Khởi động lại máy để áp dụng đầy đủ.",            "  → Restart your computer to apply fully." },
            ["LogCheckUnblock1"]   = new[] { "  Kết quả đúng: GenAILocalFoundationalModelSettings", "  Expected: GenAILocalFoundationalModelSettings" },
            ["LogCheckUnblock2"]   = new[] { "  phải BIẾN MẤT hoàn toàn khỏi danh sách.",           "  must DISAPPEAR completely from the list." },

            // Popup — block done
            ["DoneBlockTitle"]     = new[] { "Hoàn Tất - CHẶN AI",                                  "Done - AI BLOCKED" },
            ["DoneBlockBody"]      = new[] { "Đã chặn thành công!\n\nVui lòng KHỞI ĐỘNG LẠI máy tính để\nWindows cập nhật Policy mới có hiệu lực.",
                                             "Blocked successfully!\n\nPlease RESTART your computer\nfor Windows to apply the new Policy." },

            // Popup — unblock done
            ["DoneUnblockTitle"]   = new[] { "Hoàn Tất - HOÀN NGUYÊN",                              "Done - RESTORED" },
            ["DoneUnblockBody"]    = new[] { "Đã hoàn nguyên thành công!\n\nCác file AI sẽ được trình duyệt tự tải lại\nkhi bạn sử dụng tính năng AI trên Web.\n\nVui lòng KHỞI ĐỘNG LẠI máy tính.",
                                             "Restored successfully!\n\nAI files will be re-downloaded by the browser\nwhen you use AI features on the Web.\n\nPlease RESTART your computer." },

            // Popup — check guide
            ["CheckFailTitle"]     = new[] { "Hướng Dẫn Kiểm Tra",                                  "Verification Guide" },
            ["CheckFailBody"]      = new[] { "Không thể mở Chrome tự động.\n\nVui lòng mở Chrome thủ công và gõ vào thanh địa chỉ:\n\n        chrome://policy\n\nTìm dòng: GenAILocalFoundationalModelSettings\n  • Sau CHẶN       : Status = Mandatory, Value = 1\n  • Sau HOÀN NGUYÊN: dòng này phải biến mất.",
                                             "Cannot open Chrome automatically.\n\nPlease open Chrome manually and type:\n\n        chrome://policy\n\nFind: GenAILocalFoundationalModelSettings\n  • After BLOCK  : Status = Mandatory, Value = 1\n  • After RESTORE: this row must disappear." },

            // Donate form
            ["DonateTitle"]        = new[] { "Ủng Hộ Tác Giả",                                      "Support the Author" },
            ["DonateLabel"]        = new[] { "☕  Ủng Hộ Tác Giả",                                   "☕  Support the Author" },
        };

        public static string Get(string key, params object[] args)
        {
            if (!_t.TryGetValue(key, out var vals)) return key;
            string s = vals[(int)Current];
            return args.Length > 0 ? string.Format(s, args) : s;
        }
    }
}
