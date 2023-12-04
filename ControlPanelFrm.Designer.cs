namespace KeypressOverlayV2
{
    partial class ControlPanel
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
            this.redBar = new System.Windows.Forms.TrackBar();
            this.rd_lbl = new System.Windows.Forms.Label();
            this.gr_lbl = new System.Windows.Forms.Label();
            this.grBar = new System.Windows.Forms.TrackBar();
            this.bl_lbl = new System.Windows.Forms.Label();
            this.blBar = new System.Windows.Forms.TrackBar();
            this.outpt_lbl = new System.Windows.Forms.Label();
            this.txtSty_cmb = new System.Windows.Forms.ComboBox();
            this.fntSty_cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSzBar = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.char_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtclr_btn = new System.Windows.Forms.Button();
            this.opn_overlay = new System.Windows.Forms.Button();
            this.txtsz_lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.maxchBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.redBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSzBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxchBar)).BeginInit();
            this.SuspendLayout();
            // 
            // redBar
            // 
            this.redBar.Location = new System.Drawing.Point(12, 84);
            this.redBar.Name = "redBar";
            this.redBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.redBar.Size = new System.Drawing.Size(45, 170);
            this.redBar.TabIndex = 0;
            this.redBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.redBar.Scroll += new System.EventHandler(this.redBar_Scroll);
            // 
            // rd_lbl
            // 
            this.rd_lbl.AutoSize = true;
            this.rd_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_lbl.Location = new System.Drawing.Point(11, 60);
            this.rd_lbl.Name = "rd_lbl";
            this.rd_lbl.Size = new System.Drawing.Size(22, 19);
            this.rd_lbl.TabIndex = 1;
            this.rd_lbl.Text = "R:";
            // 
            // gr_lbl
            // 
            this.gr_lbl.AutoSize = true;
            this.gr_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_lbl.Location = new System.Drawing.Point(59, 60);
            this.gr_lbl.Name = "gr_lbl";
            this.gr_lbl.Size = new System.Drawing.Size(25, 19);
            this.gr_lbl.TabIndex = 3;
            this.gr_lbl.Text = "G:";
            // 
            // grBar
            // 
            this.grBar.Location = new System.Drawing.Point(63, 84);
            this.grBar.Name = "grBar";
            this.grBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.grBar.Size = new System.Drawing.Size(45, 170);
            this.grBar.TabIndex = 2;
            this.grBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.grBar.Scroll += new System.EventHandler(this.grBar_Scroll);
            // 
            // bl_lbl
            // 
            this.bl_lbl.AutoSize = true;
            this.bl_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bl_lbl.Location = new System.Drawing.Point(110, 60);
            this.bl_lbl.Name = "bl_lbl";
            this.bl_lbl.Size = new System.Drawing.Size(21, 19);
            this.bl_lbl.TabIndex = 5;
            this.bl_lbl.Text = "B:";
            // 
            // blBar
            // 
            this.blBar.Location = new System.Drawing.Point(114, 84);
            this.blBar.Name = "blBar";
            this.blBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.blBar.Size = new System.Drawing.Size(45, 170);
            this.blBar.TabIndex = 4;
            this.blBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.blBar.Scroll += new System.EventHandler(this.blBar_Scroll);
            // 
            // outpt_lbl
            // 
            this.outpt_lbl.AutoSize = true;
            this.outpt_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outpt_lbl.Location = new System.Drawing.Point(8, 9);
            this.outpt_lbl.Name = "outpt_lbl";
            this.outpt_lbl.Size = new System.Drawing.Size(117, 20);
            this.outpt_lbl.TabIndex = 6;
            this.outpt_lbl.Text = "OUTPUT TEXT";
            // 
            // txtSty_cmb
            // 
            this.txtSty_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSty_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSty_cmb.FormattingEnabled = true;
            this.txtSty_cmb.Location = new System.Drawing.Point(161, 131);
            this.txtSty_cmb.Name = "txtSty_cmb";
            this.txtSty_cmb.Size = new System.Drawing.Size(229, 24);
            this.txtSty_cmb.TabIndex = 7;
            this.txtSty_cmb.SelectedIndexChanged += new System.EventHandler(this.txtSty_cmb_SelectedIndexChanged);
            // 
            // fntSty_cmb
            // 
            this.fntSty_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fntSty_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fntSty_cmb.FormattingEnabled = true;
            this.fntSty_cmb.Location = new System.Drawing.Point(161, 82);
            this.fntSty_cmb.Name = "fntSty_cmb";
            this.fntSty_cmb.Size = new System.Drawing.Size(229, 24);
            this.fntSty_cmb.TabIndex = 8;
            this.fntSty_cmb.SelectedIndexChanged += new System.EventHandler(this.fntSty_cmb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Text Style:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Font Style:";
            // 
            // txtSzBar
            // 
            this.txtSzBar.Location = new System.Drawing.Point(161, 182);
            this.txtSzBar.Name = "txtSzBar";
            this.txtSzBar.Size = new System.Drawing.Size(229, 45);
            this.txtSzBar.TabIndex = 11;
            this.txtSzBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.txtSzBar.Scroll += new System.EventHandler(this.txtSzBar_Scroll);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maxchBar);
            this.panel1.Controls.Add(this.char_lbl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtclr_btn);
            this.panel1.Controls.Add(this.opn_overlay);
            this.panel1.Controls.Add(this.txtsz_lbl);
            this.panel1.Controls.Add(this.fntSty_cmb);
            this.panel1.Controls.Add(this.txtSzBar);
            this.panel1.Controls.Add(this.redBar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rd_lbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grBar);
            this.panel1.Controls.Add(this.gr_lbl);
            this.panel1.Controls.Add(this.txtSty_cmb);
            this.panel1.Controls.Add(this.blBar);
            this.panel1.Controls.Add(this.bl_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 318);
            this.panel1.TabIndex = 12;
            // 
            // char_lbl
            // 
            this.char_lbl.AutoSize = true;
            this.char_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.char_lbl.Location = new System.Drawing.Point(3, 257);
            this.char_lbl.Name = "char_lbl";
            this.char_lbl.Size = new System.Drawing.Size(47, 19);
            this.char_lbl.TabIndex = 22;
            this.char_lbl.Text = "Char:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Apply to:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(288, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "Background";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtclr_btn
            // 
            this.txtclr_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclr_btn.Location = new System.Drawing.Point(162, 222);
            this.txtclr_btn.Name = "txtclr_btn";
            this.txtclr_btn.Size = new System.Drawing.Size(102, 32);
            this.txtclr_btn.TabIndex = 14;
            this.txtclr_btn.Text = "Text";
            this.txtclr_btn.UseVisualStyleBackColor = true;
            this.txtclr_btn.Click += new System.EventHandler(this.txtclr_btn_Click);
            // 
            // opn_overlay
            // 
            this.opn_overlay.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opn_overlay.Location = new System.Drawing.Point(288, 260);
            this.opn_overlay.Name = "opn_overlay";
            this.opn_overlay.Size = new System.Drawing.Size(102, 32);
            this.opn_overlay.TabIndex = 13;
            this.opn_overlay.Text = "Open Overlay";
            this.opn_overlay.UseVisualStyleBackColor = true;
            this.opn_overlay.Click += new System.EventHandler(this.opn_overlay_Click);
            // 
            // txtsz_lbl
            // 
            this.txtsz_lbl.AutoSize = true;
            this.txtsz_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsz_lbl.Location = new System.Drawing.Point(157, 158);
            this.txtsz_lbl.Name = "txtsz_lbl";
            this.txtsz_lbl.Size = new System.Drawing.Size(79, 21);
            this.txtsz_lbl.TabIndex = 12;
            this.txtsz_lbl.Text = "Text Size:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.outpt_lbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 51);
            this.panel2.TabIndex = 13;
            // 
            // maxchBar
            // 
            this.maxchBar.Location = new System.Drawing.Point(7, 279);
            this.maxchBar.Name = "maxchBar";
            this.maxchBar.Size = new System.Drawing.Size(85, 45);
            this.maxchBar.TabIndex = 23;
            this.maxchBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.maxchBar.Scroll += new System.EventHandler(this.maxchBar_Scroll);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(400, 318);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ControlPanel";
            this.Text = "Control Panel";
            this.Load += new System.EventHandler(this.ControlPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.redBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSzBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxchBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar redBar;
        private System.Windows.Forms.Label rd_lbl;
        private System.Windows.Forms.Label gr_lbl;
        private System.Windows.Forms.TrackBar grBar;
        private System.Windows.Forms.Label bl_lbl;
        private System.Windows.Forms.TrackBar blBar;
        private System.Windows.Forms.Label outpt_lbl;
        private System.Windows.Forms.ComboBox txtSty_cmb;
        private System.Windows.Forms.ComboBox fntSty_cmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar txtSzBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtsz_lbl;
        private System.Windows.Forms.Button opn_overlay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button txtclr_btn;
        private System.Windows.Forms.Label char_lbl;
        private System.Windows.Forms.TrackBar maxchBar;
    }
}

