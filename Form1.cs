using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace frm_edAI_chrAI_block
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            Strings.Load();
            ApplyLanguage();
            LoadDonateImage();
        }

        // ─────────────────────────────────────────────────────────────────────
        //  LANGUAGE
        // ─────────────────────────────────────────────────────────────────────
        private void btnLang_Click(object sender, EventArgs e)
        {
            Strings.Toggle();
            ApplyLanguage();
        }

        private void ApplyLanguage()
        {
            this.Text          = Strings.Get("FormTitle");
            lblSubtitle.Text   = Strings.Get("HeaderSubtitle");
            btnBlock.Text      = Strings.Get("BtnBlock");
            btnUnblock.Text    = Strings.Get("BtnUnblock");
            lblLogTitle.Text   = Strings.Get("LogSectionTitle");
            lblFooter.Text     = Strings.Get("Footer");
            btnLang.Text       = Strings.Get("BtnLang");
        }

        private void LoadDonateImage()
        {
            picDonate.Image = ResourceHelper.LoadImage("donate.jpg");
        }

        // ─────────────────────────────────────────────────────────────────────
        //  BUTTON: CHẶN / BLOCK
        // ─────────────────────────────────────────────────────────────────────
        private async void btnBlock_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                Strings.Get("ConfirmBody"),
                Strings.Get("ConfirmTitle"),
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.OK) return;

            HideAllActionButtons();
            txtLog.Clear();

            Log(Strings.Get("LogSep"));
            Log(Strings.Get("LogBeginBlock"));
            Log(Strings.Get("LogSep"));

            await Task.Run(() =>
            {
                KillBrowserProcesses();
                BlockRegistry();
                DeleteAIFolders();
            });

            Log("");
            Log(Strings.Get("LogSep"));
            Log(Strings.Get("LogDoneBlockHdr"));
            Log(Strings.Get("LogDoneBlockSub"));
            Log(Strings.Get("LogSep"));
            Log("");
            Log(Strings.Get("LogCheckHdr"));
            Log(Strings.Get("LogCheckLine1"));
            Log(Strings.Get("LogCheckLine2"));
            Log(Strings.Get("LogCheckLine3"));

            ShowAfterBlock();
            MessageBox.Show(
                Strings.Get("DoneBlockBody"),
                Strings.Get("DoneBlockTitle"),
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ─────────────────────────────────────────────────────────────────────
        //  BUTTON: HOÀN NGUYÊN / RESTORE
        // ─────────────────────────────────────────────────────────────────────
        private async void btnUnblock_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                Strings.Get("ConfirmBody"),
                Strings.Get("ConfirmTitle"),
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.OK) return;

            HideAllActionButtons();
            txtLog.Clear();

            Log(Strings.Get("LogSep"));
            Log(Strings.Get("LogBeginUnblock"));
            Log(Strings.Get("LogSep"));

            await Task.Run(() =>
            {
                KillBrowserProcesses();
                UnblockRegistry();
            });

            Log("");
            Log(Strings.Get("LogSep"));
            Log(Strings.Get("LogDoneUnblockHdr"));
            Log(Strings.Get("LogSep"));
            Log("");
            Log(Strings.Get("LogUXNote1"));
            Log(Strings.Get("LogUXNote2"));
            Log(Strings.Get("LogUXNote3"));
            Log(Strings.Get("LogUXNote4"));
            Log(Strings.Get("LogUXNote5"));
            Log("");
            Log(Strings.Get("LogUXNote6"));
            Log(Strings.Get("LogSep"));
            Log("");
            Log(Strings.Get("LogCheckHdr"));
            Log(Strings.Get("LogCheckLine1"));
            Log(Strings.Get("LogCheckUnblock1"));
            Log(Strings.Get("LogCheckUnblock2"));

            ShowAfterUnblock();
            MessageBox.Show(
                Strings.Get("DoneUnblockBody"),
                Strings.Get("DoneUnblockTitle"),
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ─────────────────────────────────────────────────────────────────────
        //  STEP 1: Kill browsers
        // ─────────────────────────────────────────────────────────────────────
        private void KillBrowserProcesses()
        {
            Log(Strings.Get("LogStep1"));

            try
            {
                int n = KillProcessByName("chrome");
                Log(Strings.Get("LogChromeKilled", n));
            }
            catch (Exception ex) { Log(Strings.Get("LogChromeError", ex.Message)); }

            try
            {
                int n = KillProcessByName("msedge");
                Log(Strings.Get("LogEdgeKilled", n));
            }
            catch (Exception ex) { Log(Strings.Get("LogEdgeError", ex.Message)); }

            Log(Strings.Get("LogWaiting"));
            WaitForProcessExit("chrome", maxWaitMs: 5000);
            WaitForProcessExit("msedge", maxWaitMs: 5000);
            Log(Strings.Get("LogReady"));
        }

        private int KillProcessByName(string name)
        {
            var procs = Process.GetProcessesByName(name);
            foreach (var p in procs)
                try { p.Kill(); } catch { }
            return procs.Length;
        }

        private void WaitForProcessExit(string name, int maxWaitMs)
        {
            int elapsed = 0;
            while (elapsed < maxWaitMs)
            {
                if (Process.GetProcessesByName(name).Length == 0) return;
                Thread.Sleep(200);
                elapsed += 200;
            }
        }

        // ─────────────────────────────────────────────────────────────────────
        //  STEP 2A: Block Registry
        // ─────────────────────────────────────────────────────────────────────
        private void BlockRegistry()
        {
            Log(Strings.Get("LogStep2A"));

            try
            {
                SetRegistryValue(@"SOFTWARE\Policies\Google\Chrome", "GenAILocalFoundationalModelSettings", 1);
                Log(Strings.Get("LogChromePolicyOn"));
            }
            catch (Exception ex) { Log(Strings.Get("LogChromePolicyErr", ex.Message)); }

            try
            {
                SetRegistryValue(@"SOFTWARE\Policies\Microsoft\Edge", "GenAILocalFoundationalModelSettings", 1);
                Log(Strings.Get("LogEdgePolicyOn"));
            }
            catch (Exception ex) { Log(Strings.Get("LogEdgePolicyErr", ex.Message)); }
        }

        // ─────────────────────────────────────────────────────────────────────
        //  STEP 2B: Unblock Registry
        // ─────────────────────────────────────────────────────────────────────
        private void UnblockRegistry()
        {
            Log(Strings.Get("LogStep2B"));

            try
            {
                DeleteRegistryValue(@"SOFTWARE\Policies\Google\Chrome", "GenAILocalFoundationalModelSettings");
                Log(Strings.Get("LogChromePolicyOff"));
            }
            catch (Exception ex) { Log(Strings.Get("LogChromePolicyErr", ex.Message)); }

            try
            {
                DeleteRegistryValue(@"SOFTWARE\Policies\Microsoft\Edge", "GenAILocalFoundationalModelSettings");
                Log(Strings.Get("LogEdgePolicyOff"));
            }
            catch (Exception ex) { Log(Strings.Get("LogEdgePolicyErr", ex.Message)); }
        }

        private void SetRegistryValue(string subKey, string valueName, int data)
        {
            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            using (var key = hklm.CreateSubKey(subKey, RegistryKeyPermissionCheck.ReadWriteSubTree))
                key.SetValue(valueName, data, RegistryValueKind.DWord);
        }

        private void DeleteRegistryValue(string subKey, string valueName)
        {
            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            using (var key = hklm.OpenSubKey(subKey, RegistryKeyPermissionCheck.ReadWriteSubTree))
            {
                if (key == null) return;
                key.DeleteValue(valueName, throwOnMissingValue: false);
            }
        }

        // ─────────────────────────────────────────────────────────────────────
        //  STEP 3A: Delete AI folders — multi-profile scan
        // ─────────────────────────────────────────────────────────────────────
        private void DeleteAIFolders()
        {
            Log(Strings.Get("LogStep3"));

            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            DeleteAIFoldersForBrowser("Chrome",
                Path.Combine(localAppData, @"Google\Chrome\User Data"));

            DeleteAIFoldersForBrowser("Edge",
                Path.Combine(localAppData, @"Microsoft\Edge\User Data"));
        }

        private static readonly string[] AiFolderNames = new[]
        {
            "OptimizationGuide",
            "optimization_guide_model_store",
            "EdgeWalletAIBundles",
            "GenAI",
        };

        private void DeleteAIFoldersForBrowser(string browser, string userDataPath)
        {
            if (!Directory.Exists(userDataPath))
            {
                Log(Strings.Get("LogNoUserData", browser, userDataPath));
                return;
            }

            ScanAndDelete(browser, userDataPath, isProfileRoot: false);

            foreach (var profileDir in Directory.GetDirectories(userDataPath))
            {
                string dirName = Path.GetFileName(profileDir);
                if (!dirName.StartsWith("Default", StringComparison.OrdinalIgnoreCase) &&
                    !dirName.StartsWith("Profile", StringComparison.OrdinalIgnoreCase))
                    continue;

                ScanAndDelete(browser, profileDir, isProfileRoot: true);
            }
        }

        private void ScanAndDelete(string browser, string basePath, bool isProfileRoot)
        {
            string label = isProfileRoot ? Path.GetFileName(basePath) : "UserData";

            foreach (var folderName in AiFolderNames)
            {
                string target = Path.Combine(basePath, folderName);
                try
                {
                    if (!Directory.Exists(target)) continue;
                    long sizeMB = GetDirectorySizeMB(target);
                    Directory.Delete(target, recursive: true);
                    Log(Strings.Get("LogDeleted", browser, label, sizeMB, folderName));
                }
                catch (UnauthorizedAccessException)
                {
                    Log(Strings.Get("LogLocked", browser, label, folderName));
                }
                catch (IOException)
                {
                    Log(Strings.Get("LogIOErr", browser, label, folderName));
                }
                catch (Exception ex)
                {
                    Log(Strings.Get("LogErrGeneric", browser, label, folderName, ex.Message));
                }
            }
        }

        private long GetDirectorySizeMB(string path)
        {
            try
            {
                long bytes = 0;
                foreach (var f in Directory.GetFiles(path, "*", SearchOption.AllDirectories))
                    bytes += new FileInfo(f).Length;
                return bytes / (1024 * 1024);
            }
            catch { return 0; }
        }

        // ─────────────────────────────────────────────────────────────────────
        //  HELPER: Thread-safe log
        // ─────────────────────────────────────────────────────────────────────
        private void Log(string message)
        {
            if (txtLog.InvokeRequired)
                txtLog.Invoke(new Action(() => txtLog.AppendText(message + System.Environment.NewLine)));
            else
                txtLog.AppendText(message + System.Environment.NewLine);
        }

        // ─────────────────────────────────────────────────────────────────────
        //  BUTTON: KIỂM TRA / CHECK
        // ─────────────────────────────────────────────────────────────────────
        private void btnCheck_Click(object sender, EventArgs e)
        {
            bool opened = TryStartProcess("chrome.exe", "chrome://policy") ||
                          TryStartProcess("msedge.exe", "chrome://policy");

            if (!opened)
            {
                MessageBox.Show(
                    Strings.Get("CheckFailBody"),
                    Strings.Get("CheckFailTitle"),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private bool TryStartProcess(string exe, string args)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = exe,
                    Arguments = args,
                    UseShellExecute = true,
                });
                return true;
            }
            catch { return false; }
        }

        // ─────────────────────────────────────────────────────────────────────
        //  BUTTON VISIBILITY
        // ─────────────────────────────────────────────────────────────────────
        private void HideAllActionButtons()
        {
            btnBlock.Visible   = false;
            btnUnblock.Visible = false;
            btnCheck.Visible   = false;
        }

        private void ShowAfterBlock()
        {
            btnBlock.Visible   = false;
            btnUnblock.Visible = true;
            btnCheck.Visible   = true;
        }

        private void ShowAfterUnblock()
        {
            btnBlock.Visible   = true;
            btnUnblock.Visible = false;
            btnCheck.Visible   = true;
        }

        // ─────────────────────────────────────────────────────────────────────
        //  BUTTON: DONATE
        // ─────────────────────────────────────────────────────────────────────
        private void picDonate_Click(object sender, EventArgs e)
        {
            using (var donate = new DonateForm())
                donate.ShowDialog(this);
        }
    }
}
