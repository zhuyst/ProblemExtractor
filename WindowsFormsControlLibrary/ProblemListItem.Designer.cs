namespace WindowsFormsControlLibrary
{
    partial class ProblemListItem
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ContentLabel = new DSkin.Controls.DSkinButton();
            this.SuspendLayout();
            // 
            // ContentLabel
            // 
            this.ContentLabel.AdaptImage = true;
            this.ContentLabel.BaseColor = System.Drawing.Color.Transparent;
            this.ContentLabel.ButtonBorderColor = System.Drawing.Color.Green;
            this.ContentLabel.ButtonBorderWidth = 1;
            this.ContentLabel.ButtonStyle = DSkin.DirectUI.ButtonStyles.Style1;
            this.ContentLabel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ContentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentLabel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ContentLabel.HoverColor = System.Drawing.Color.Empty;
            this.ContentLabel.HoverImage = null;
            this.ContentLabel.IsPureColor = false;
            this.ContentLabel.Location = new System.Drawing.Point(0, 0);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.NormalImage = null;
            this.ContentLabel.PressColor = System.Drawing.Color.Empty;
            this.ContentLabel.PressedImage = null;
            this.ContentLabel.Radius = 15;
            this.ContentLabel.ShowButtonBorder = true;
            this.ContentLabel.Size = new System.Drawing.Size(795, 98);
            this.ContentLabel.TabIndex = 0;
            this.ContentLabel.Text = "dSkinButton1";
            this.ContentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ContentLabel.TextPadding = 10;
            // 
            // ProblemListItem
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ContentLabel);
            this.Name = "ProblemListItem";
            this.Size = new System.Drawing.Size(795, 98);
            this.Load += new System.EventHandler(this.ProblemListItem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DSkin.Controls.DSkinButton ContentLabel;
    }
}
