namespace ProblemExtractor
{
    partial class ProblemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProblemForm));
            this.dSkinLabel1 = new DSkin.Controls.DSkinLabel();
            this.ProblemListPanel = new DSkin.Controls.DSkinFlowLayoutPanel();
            this.ReloadButton = new DSkin.Controls.DSkinButton();
            this.CloseButton = new DSkin.Controls.DSkinButton();
            this.SuspendLayout();
            // 
            // dSkinLabel1
            // 
            this.dSkinLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinLabel1.AutoSize = false;
            this.dSkinLabel1.EffectColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(125)))), ((int)(((byte)(49)))));
            this.dSkinLabel1.EffectValue = 2;
            this.dSkinLabel1.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold);
            this.dSkinLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(173)))));
            this.dSkinLabel1.Location = new System.Drawing.Point(75, 135);
            this.dSkinLabel1.Name = "dSkinLabel1";
            this.dSkinLabel1.Size = new System.Drawing.Size(105, 358);
            this.dSkinLabel1.TabIndex = 1;
            this.dSkinLabel1.Text = "动漫灯谜";
            this.dSkinLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinLabel1.TextEffect = DSkin.DirectUI.TextEffects.Path;
            // 
            // ProblemListPanel
            // 
            this.ProblemListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProblemListPanel.AutoScroll = true;
            this.ProblemListPanel.BackColor = System.Drawing.Color.Transparent;
            this.ProblemListPanel.BitmapCache = false;
            this.ProblemListPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ProblemListPanel.Location = new System.Drawing.Point(255, 37);
            this.ProblemListPanel.Name = "ProblemListPanel";
            this.ProblemListPanel.RightBottom = ((System.Drawing.Image)(resources.GetObject("ProblemListPanel.RightBottom")));
            this.ProblemListPanel.Size = new System.Drawing.Size(810, 520);
            this.ProblemListPanel.TabIndex = 2;
            this.ProblemListPanel.WrapContents = false;
            // 
            // ReloadButton
            // 
            this.ReloadButton.AdaptImage = true;
            this.ReloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReloadButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(173)))));
            this.ReloadButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(125)))), ((int)(((byte)(49)))));
            this.ReloadButton.ButtonBorderWidth = 1;
            this.ReloadButton.ButtonStyle = DSkin.DirectUI.ButtonStyles.Style1;
            this.ReloadButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ReloadButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReloadButton.HoverColor = System.Drawing.Color.Empty;
            this.ReloadButton.HoverImage = null;
            this.ReloadButton.IsPureColor = false;
            this.ReloadButton.Location = new System.Drawing.Point(487, 569);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.NormalImage = null;
            this.ReloadButton.PressColor = System.Drawing.Color.Empty;
            this.ReloadButton.PressedImage = null;
            this.ReloadButton.Radius = 10;
            this.ReloadButton.ShowButtonBorder = true;
            this.ReloadButton.Size = new System.Drawing.Size(157, 52);
            this.ReloadButton.TabIndex = 3;
            this.ReloadButton.Text = "重新抽题";
            this.ReloadButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReloadButton.TextPadding = 0;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AdaptImage = true;
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(173)))));
            this.CloseButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(125)))), ((int)(((byte)(49)))));
            this.CloseButton.ButtonBorderWidth = 1;
            this.CloseButton.ButtonStyle = DSkin.DirectUI.ButtonStyles.Style1;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CloseButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloseButton.HoverColor = System.Drawing.Color.Empty;
            this.CloseButton.HoverImage = null;
            this.CloseButton.IsPureColor = false;
            this.CloseButton.Location = new System.Drawing.Point(722, 569);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.NormalImage = null;
            this.CloseButton.PressColor = System.Drawing.Color.Empty;
            this.CloseButton.PressedImage = null;
            this.CloseButton.Radius = 10;
            this.CloseButton.ShowButtonBorder = true;
            this.CloseButton.Size = new System.Drawing.Size(157, 52);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "关闭";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton.TextPadding = 0;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ProblemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProblemExtractor.Properties.Resources.背景;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CaptionShowMode = DSkin.TextShowModes.None;
            this.ClientSize = new System.Drawing.Size(1135, 638);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ReloadButton);
            this.Controls.Add(this.ProblemListPanel);
            this.Controls.Add(this.dSkinLabel1);
            this.DrawIcon = false;
            this.EnabledDWM = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProblemForm";
            this.Opacity = 0.98D;
            this.Radius = 25;
            this.Text = "抽题";
            this.Load += new System.EventHandler(this.ProblemForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DSkin.Controls.DSkinLabel dSkinLabel1;
        private DSkin.Controls.DSkinFlowLayoutPanel ProblemListPanel;
        private DSkin.Controls.DSkinButton ReloadButton;
        private DSkin.Controls.DSkinButton CloseButton;
    }
}