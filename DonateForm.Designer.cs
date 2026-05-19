namespace frm_edAI_chrAI_block
{
    partial class DonateForm
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
            this.picTCB = new System.Windows.Forms.PictureBox();
            this.picMomo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picTCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMomo)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = false;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 188, 212);
            this.lblTitle.Height = 40;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "☕  Ủng Hộ Tác Giả";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // picTCB
            this.picTCB.Location = new System.Drawing.Point(16, 48);
            this.picTCB.Name = "picTCB";
            this.picTCB.Size = new System.Drawing.Size(240, 320);
            this.picTCB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTCB.TabIndex = 1;
            this.picTCB.TabStop = false;

            // picMomo
            this.picMomo.Location = new System.Drawing.Point(272, 48);
            this.picMomo.Name = "picMomo";
            this.picMomo.Size = new System.Drawing.Size(240, 320);
            this.picMomo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMomo.TabIndex = 2;
            this.picMomo.TabStop = false;

            // DonateForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.ClientSize = new System.Drawing.Size(528, 384);
            this.Controls.Add(this.picTCB);
            this.Controls.Add(this.picMomo);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DonateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ủng Hộ Tác Giả";

            ((System.ComponentModel.ISupportInitialize)(this.picTCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMomo)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox picTCB;
        private System.Windows.Forms.PictureBox picMomo;
        private System.Windows.Forms.Label lblTitle;
    }
}
