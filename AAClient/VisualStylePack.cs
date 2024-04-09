using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AAClient
{
    /// <summary>
    /// A static helper to quickly grab Colors, Themes and Fonts.
    /// </summary>
    internal static class VisualStylePack
    {
        public static void PickColors(Control cont, Control[] conts)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = cont.ForeColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var item in conts)
                {
                    item.ForeColor = colorDialog.Color;
                }
            }
        }
        public static void PickFonts(Control cont, Control[] conts)
        {
            var fontDialog1 = new FontDialog();
            fontDialog1.ShowColor = true;
            fontDialog1.Font = cont.Font;
            fontDialog1.Color = cont.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                foreach (var item in conts)
                {
                    item.Font = fontDialog1.Font;
                    item.ForeColor = fontDialog1.Color;
                }
            }
        }
        public static void PickThemes(Control cont, Control[] conts)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = cont.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var item in conts)
                {
                    item.BackColor = colorDialog.Color;
                }
            }
            cont.Parent.BackColor = colorDialog.Color;
        }
    }
}
