using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KeypressOverlayV2
{
    public partial class ControlPanel : Form
    {
        OverlayForm frm = new OverlayForm();

        public int red_val;
        public int blu_val;
        public int gre_val;
        public string selected_style;
        public string fontStl;
        public int txt_size;
        public int width;
        public int length;

        FontStyle fontStyle = FontStyle.Regular;

        public ControlPanel()
        {
            InitializeComponent();
            redBar.Maximum = 255;
            grBar.Maximum = 255;
            blBar.Maximum = 255;
            txtSzBar.Minimum = 12;
            txtSzBar.Maximum = 20;
            maxchBar.Minimum = 40;
            maxchBar.Maximum = 90;
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            foreach (FontStyle fontStyle in Enum.GetValues(typeof(FontStyle)))
            {
                string styleName = fontStyle.ToString();
                txtSty_cmb.Items.Add(styleName);
            }

            foreach (FontFamily fontFamily in FontFamily.Families)
            {
                fntSty_cmb.Items.Add(fontFamily.Name);
            }
            txtSty_cmb.SelectedIndex = 0;
            txtSzBar.Value = 15;
            txtsz_lbl.Text = "Text Size: 15";
            txt_size = txtSzBar.Value;
            fntSty_cmb.SelectedIndex = 0;
            maxchBar.Value = 50;
            char_lbl.Text = "Char: 50";
            frm.CharLength = 50;
        }

        private void fntSty_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_style = fntSty_cmb.SelectedItem.ToString();
            outpt_lbl.Text = selected_style + " (" + fontStl + ") ";
            outpt_lbl.Font = new Font(selected_style, outpt_lbl.Font.Size, outpt_lbl.Font.Style);
            frm.outpt_txt.Font = new Font(selected_style, outpt_lbl.Font.Size, outpt_lbl.Font.Style);
        }

        private void txtSty_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontStl = txtSty_cmb.SelectedItem.ToString();

            switch (fontStl)
            {
                case "Regular":
                    fontStyle = FontStyle.Regular;
                    break;
                case "Bold":
                    fontStyle = FontStyle.Bold;
                    break;
                case "Italic":
                    fontStyle = FontStyle.Italic;
                    break;
                case "Underline":
                    fontStyle = FontStyle.Underline;
                    break;
                    
            }
            outpt_lbl.Text = selected_style + " (" + fontStl + ") ";
            outpt_lbl.Font = new Font(outpt_lbl.Font.FontFamily, outpt_lbl.Font.Size, fontStyle);
            frm.outpt_txt.Font = new Font(outpt_lbl.Font.FontFamily, outpt_lbl.Font.Size, fontStyle);
        }

        private void redBar_Scroll(object sender, EventArgs e)
        {
            red_val = redBar.Value;
            rd_lbl.Text = "R: " + red_val.ToString();
            rd_lbl.ForeColor = Color.FromArgb(red_val, 0, 0);

            outpt_lbl.ForeColor = Color.FromArgb(red_val, gre_val, blu_val);
        }

        private void grBar_Scroll(object sender, EventArgs e)
        {
            gre_val = grBar.Value;
            gr_lbl.Text = "G: " + gre_val.ToString();
            gr_lbl.ForeColor = Color.FromArgb(0, gre_val, 0);

            outpt_lbl.ForeColor = Color.FromArgb(red_val, gre_val, blu_val);
        }

        private void blBar_Scroll(object sender, EventArgs e)
        {
            blu_val = blBar.Value;
            bl_lbl.Text = "B: " + blu_val.ToString();
            bl_lbl.ForeColor = Color.FromArgb(0, 0, blu_val);

            outpt_lbl.ForeColor = Color.FromArgb(red_val, gre_val, blu_val);
        }

        private void txtSzBar_Scroll(object sender, EventArgs e)
        {
            txt_size = txtSzBar.Value;
            outpt_lbl.Font = new System.Drawing.Font(outpt_lbl.Font.FontFamily, txt_size);
            txtsz_lbl.Text = "Text Size: " + txt_size.ToString();

            frm.outpt_txt.Font = new System.Drawing.Font(outpt_lbl.Font.FontFamily, txt_size);
            frm.Refresh();
        }

        private void opn_overlay_Click(object sender, EventArgs e)
        {
            if (frm.IsDisposed)
            {
                frm = new OverlayForm();
            }
            frm.Show();

            frm.outpt_txt.Font = new Font(selected_style, outpt_lbl.Font.Size, outpt_lbl.Font.Style);
            frm.outpt_txt.Font = new Font(outpt_lbl.Font.FontFamily, outpt_lbl.Font.Size, fontStyle);
            frm.outpt_txt.Font = new System.Drawing.Font(outpt_lbl.Font.FontFamily, txt_size);
            frm.Refresh();
        }

        private void txtclr_btn_Click(object sender, EventArgs e)
        {
            frm.outpt_txt.ForeColor = Color.FromArgb(red_val, gre_val, blu_val);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm.BackColor = Color.FromArgb(red_val, gre_val, blu_val);
        }

        private void maxchBar_Scroll(object sender, EventArgs e)
        {
            frm.CharLength = maxchBar.Value;
            char_lbl.Text = "Char: " + maxchBar.Value;
        }
    }
}
