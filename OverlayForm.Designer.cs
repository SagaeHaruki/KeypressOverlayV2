namespace KeypressOverlayV2
{
    partial class OverlayForm
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
            this.outpt_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outpt_txt
            // 
            this.outpt_txt.AutoSize = true;
            this.outpt_txt.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outpt_txt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.outpt_txt.Location = new System.Drawing.Point(12, 9);
            this.outpt_txt.Name = "outpt_txt";
            this.outpt_txt.Size = new System.Drawing.Size(20, 27);
            this.outpt_txt.TabIndex = 0;
            this.outpt_txt.Text = "-";
            // 
            // OverlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(184, 86);
            this.Controls.Add(this.outpt_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OverlayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "OverlayForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OverlayForm_FormClosing);
            this.Load += new System.EventHandler(this.OverlayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label outpt_txt;
    }
}