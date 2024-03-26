using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAClient
{
    /// <summary>
    /// A static helper to quickly grab Colors, Themes and Fonts.
    /// </summary>
    internal static class VisualStylePack
    {
        public static void PickColors(Control cont)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = cont.ForeColor;
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                cont.ForeColor = colorDialog.Color;
            }
        }
        public static void PickFonts()
        {

        }
        public static void PickThemes()
        {

        }
    }
}
