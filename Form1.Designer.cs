namespace frm_edAI_chrAI_block
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLang = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnUnblock = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.panelLog = new System.Windows.Forms.Panel();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.lblLogTitle = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.picDonate = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelLog.SuspendLayout();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDonate)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelHeader.Controls.Add(this.btnLang);
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panelHeader.Size = new System.Drawing.Size(580, 80);
            this.panelHeader.TabIndex = 2;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblSubtitle.Location = new System.Drawing.Point(22, 44);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(397, 15);
            this.lblSubtitle.TabIndex = 0;
            this.lblSubtitle.Text = "Kiểm soát tính năng AI trên Chrome & Edge  |  Yêu cầu quyền Administrator";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.lblTitle.Location = new System.Drawing.Point(18, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(253, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "🛡  AI Block & Clean Tool";
            //
            // btnLang
            //
            this.btnLang.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnLang.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.btnLang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.btnLang.FlatAppearance.BorderSize = 1;
            this.btnLang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.btnLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLang.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnLang.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.btnLang.Location = new System.Drawing.Point(504, 10);
            this.btnLang.Name = "btnLang";
            this.btnLang.Size = new System.Drawing.Size(58, 26);
            this.btnLang.TabIndex = 2;
            this.btnLang.Text = "🌐 EN";
            this.btnLang.UseVisualStyleBackColor = false;
            this.btnLang.Click += new System.EventHandler(this.btnLang_Click);
            //
            // panelButtons
            //
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelButtons.Controls.Add(this.btnBlock);
            this.panelButtons.Controls.Add(this.btnUnblock);
            this.panelButtons.Controls.Add(this.btnCheck);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 80);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.panelButtons.Size = new System.Drawing.Size(580, 90);
            this.panelButtons.TabIndex = 1;
            // 
            // btnBlock
            // 
            this.btnBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnBlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlock.FlatAppearance.BorderSize = 0;
            this.btnBlock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlock.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnBlock.ForeColor = System.Drawing.Color.White;
            this.btnBlock.Location = new System.Drawing.Point(20, 18);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(240, 52);
            this.btnBlock.TabIndex = 0;
            this.btnBlock.Text = "🚫  CHẶN AI";
            this.btnBlock.UseVisualStyleBackColor = false;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnUnblock
            // 
            this.btnUnblock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnUnblock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnblock.FlatAppearance.BorderSize = 0;
            this.btnUnblock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnUnblock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnblock.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnUnblock.ForeColor = System.Drawing.Color.White;
            this.btnUnblock.Location = new System.Drawing.Point(280, 18);
            this.btnUnblock.Name = "btnUnblock";
            this.btnUnblock.Size = new System.Drawing.Size(210, 52);
            this.btnUnblock.TabIndex = 1;
            this.btnUnblock.Text = "✅  HOÀN NGUYÊN";
            this.btnUnblock.UseVisualStyleBackColor = false;
            this.btnUnblock.Click += new System.EventHandler(this.btnUnblock_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(508, 18);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(52, 52);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Tag = "Kiểm tra kết quả tại chrome://policy";
            this.btnCheck.Text = "🔍";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // panelLog
            // 
            this.panelLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panelLog.Controls.Add(this.txtLog);
            this.panelLog.Controls.Add(this.lblLogTitle);
            this.panelLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLog.Location = new System.Drawing.Point(0, 170);
            this.panelLog.Name = "panelLog";
            this.panelLog.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.panelLog.Size = new System.Drawing.Size(580, 302);
            this.panelLog.TabIndex = 0;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 9.5F);
            this.txtLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.txtLog.Location = new System.Drawing.Point(16, 28);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(928, 472);
            this.txtLog.TabIndex = 0;
            this.txtLog.Text = "";
            this.txtLog.WordWrap = false;
            // 
            // lblLogTitle
            // 
            this.lblLogTitle.AutoSize = true;
            this.lblLogTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLogTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblLogTitle.Location = new System.Drawing.Point(16, 8);
            this.lblLogTitle.Name = "lblLogTitle";
            this.lblLogTitle.Size = new System.Drawing.Size(133, 15);
            this.lblLogTitle.TabIndex = 1;
            this.lblLogTitle.Text = "NHẬT KÝ HOẠT ĐỘNG";
            // 
            // panelFooter
            //
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelFooter.Controls.Add(this.picDonate);
            this.panelFooter.Controls.Add(this.lblFooter);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 472);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(580, 32);
            this.panelFooter.TabIndex = 3;
            //
            // lblFooter
            //
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblFooter.Location = new System.Drawing.Point(16, 9);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(257, 13);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.Text = "v1.0  |  Chạy với quyền Administrator  |  .NET 4.5.2";
            //
            // picDonate
            //
            this.picDonate.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top;
            this.picDonate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDonate.Name = "picDonate";
            this.picDonate.Size = new System.Drawing.Size(80, 24);
            this.picDonate.Location = new System.Drawing.Point(488, 4);
            this.picDonate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDonate.TabIndex = 1;
            this.picDonate.TabStop = false;
            this.picDonate.Click += new System.EventHandler(this.picDonate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(580, 500);
            this.Controls.Add(this.panelLog);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AI Block & Clean Tool  [Administrator]";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelLog.ResumeLayout(false);
            this.panelLog.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDonate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnLang;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnUnblock;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Panel panelLog;
        private System.Windows.Forms.Label lblLogTitle;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.PictureBox picDonate;
    }
}
