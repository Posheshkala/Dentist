namespace Dentist
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.تعاربفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.نوبتدهیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حسابداریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.امکاناتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تنظیماتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پشتیبانیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.راهنماToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.TMSVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Location = new System.Drawing.Point(0, 425);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعاربفToolStripMenuItem,
            this.نوبتدهیToolStripMenuItem,
            this.حسابداریToolStripMenuItem,
            this.گزارشاتToolStripMenuItem,
            this.امکاناتToolStripMenuItem,
            this.تنظیماتToolStripMenuItem,
            this.پشتیبانیToolStripMenuItem,
            this.راهنماToolStripMenuItem,
            this.TSMAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // تعاربفToolStripMenuItem
            // 
            this.تعاربفToolStripMenuItem.Name = "تعاربفToolStripMenuItem";
            this.تعاربفToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.تعاربفToolStripMenuItem.Text = "تعاربف";
            // 
            // نوبتدهیToolStripMenuItem
            // 
            this.نوبتدهیToolStripMenuItem.Name = "نوبتدهیToolStripMenuItem";
            this.نوبتدهیToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.نوبتدهیToolStripMenuItem.Text = "نوبت دهی";
            // 
            // حسابداریToolStripMenuItem
            // 
            this.حسابداریToolStripMenuItem.Name = "حسابداریToolStripMenuItem";
            this.حسابداریToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.حسابداریToolStripMenuItem.Text = "حسابداری";
            // 
            // گزارشاتToolStripMenuItem
            // 
            this.گزارشاتToolStripMenuItem.Name = "گزارشاتToolStripMenuItem";
            this.گزارشاتToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.گزارشاتToolStripMenuItem.Text = "گزارشات";
            // 
            // امکاناتToolStripMenuItem
            // 
            this.امکاناتToolStripMenuItem.Name = "امکاناتToolStripMenuItem";
            this.امکاناتToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.امکاناتToolStripMenuItem.Text = "امکانات";
            // 
            // تنظیماتToolStripMenuItem
            // 
            this.تنظیماتToolStripMenuItem.Name = "تنظیماتToolStripMenuItem";
            this.تنظیماتToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.تنظیماتToolStripMenuItem.Text = "تنظیمات";
            // 
            // پشتیبانیToolStripMenuItem
            // 
            this.پشتیبانیToolStripMenuItem.Name = "پشتیبانیToolStripMenuItem";
            this.پشتیبانیToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.پشتیبانیToolStripMenuItem.Text = "پشتیبانی";
            // 
            // راهنماToolStripMenuItem
            // 
            this.راهنماToolStripMenuItem.Name = "راهنماToolStripMenuItem";
            this.راهنماToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.راهنماToolStripMenuItem.Text = "راهنما";
            // 
            // TSMAbout
            // 
            this.TSMAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TMSVersion});
            this.TSMAbout.Name = "TSMAbout";
            this.TSMAbout.Size = new System.Drawing.Size(60, 20);
            this.TSMAbout.Text = "درباره ما";
            // 
            // TMSVersion
            // 
            this.TMSVersion.Name = "TMSVersion";
            this.TMSVersion.Size = new System.Drawing.Size(180, 22);
            this.TMSVersion.Text = "نسخه نرم افزار";
            this.TMSVersion.Click += new System.EventHandler(this.TMSVersion_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem تعاربفToolStripMenuItem;
        private ToolStripMenuItem نوبتدهیToolStripMenuItem;
        private ToolStripMenuItem حسابداریToolStripMenuItem;
        private ToolStripMenuItem گزارشاتToolStripMenuItem;
        private ToolStripMenuItem امکاناتToolStripMenuItem;
        private ToolStripMenuItem تنظیماتToolStripMenuItem;
        private ToolStripMenuItem پشتیبانیToolStripMenuItem;
        private ToolStripMenuItem راهنماToolStripMenuItem;
        private ToolStripMenuItem TSMAbout;
        private ToolStripMenuItem TMSVersion;
    }
}