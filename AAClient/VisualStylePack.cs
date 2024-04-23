using System;
using System.Drawing;
using System.Windows.Forms;

// RAYMOND LAI
// STUDENT ID: 30082866
// DATE: 23/04/2024

namespace AAClient
{
    /// <summary>
    /// A static helper to quickly grab Colors, Themes and Fonts.
    /// </summary>
    internal static class VisualStylePack
    {
        // Picks color and apply complementary colors to other controls
        public static void PickColors(Control cont, Control[] conts)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = cont.ForeColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                ChangeColors(colorDialog.Color, conts);
                ChangeBackground(ColorFromHSL(PickComplementaryColor(colorDialog.Color)), conts);
                //cont.Parent.BackColor = ColorFromHSL(PickComplementaryColor(colorDialog.Color));
            }
        }
        public static void PickFonts(Control cont, Control[] conts)
        {
            var fontDialog1 = new FontDialog();
            fontDialog1.ShowColor = true;
            fontDialog1.Font = cont.Font;
            fontDialog1.Color = cont.ForeColor;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                ChangeFont(fontDialog1.Color, fontDialog1.Font, conts);
            }
            
        }
        public static void PickThemes(Control cont, Control[] conts)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = cont.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                ChangeBackground(colorDialog.Color, conts);
                ChangeColors(ColorFromHSL(PickComplementaryColor(colorDialog.Color)), conts);
                //cont.Parent.BackColor = ColorFromHSL(PickComplementaryColor(colorDialog.Color));
            }
        }
        
        /// <summary>
        /// Picks the complementary color based on the passed color parameter
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private static HSV PickComplementaryColor(Color c)
        {
            Color color = Color.FromArgb(c.ToArgb());
            float h = color.GetHue();
            float s = color.GetSaturation();
            float v = color.GetBrightness();

            float delta = 120f; // Arbitrary value in the range 0.0f through 360.0f
            h = (h + delta) % 360f;

            return new HSV() { h = h, s = s, v = v };
        }
        
        // Change colors on all passed Control parameters
        private static void ChangeColors(Color color, Control[] conts)
        {
            foreach (var item in conts)
            {
                if (item.Name == "Company_Label") { continue; }
                if (item.Name == "ResultsGridView") { continue; }
                item.ForeColor = color;
            }
        }
        private static void ChangeFont(Color color, Font font, Control[] conts)
        {
            foreach (var item in conts)
            {
                if (item.Name == "Company_Label") { continue; }
                item.Font = font;
                item.ForeColor = color;
            }
        }
        private static void ChangeBackground(Color color, Control[] conts)
        {
            foreach (var item in conts)
            {
                if (item.Name == "Company_Label") { continue; }
                if (item.Name == "ResultsGridView") { continue; }
                item.BackColor = color;
            }
            conts[0].Parent.BackColor = color;
        }

        /// <summary>
        /// A static function that changes all passed controls to a corresponding preset theme
        /// </summary>
        /// <param name="theme"></param>
        /// <param name="conts"></param>
        public static void ChangeToPresetTheme(int theme, Control[] conts)
        {
            switch (theme)
            {
                case 0: //DEFAULT
                    ChangeColors(Color.Black, conts);
                    ChangeBackground(default(Color), conts);
                    break;
                case 1: //DARK
                    ChangeColors(ColorTranslator.FromHtml("#B7B7B7"), conts);
                    ChangeBackground(ColorTranslator.FromHtml("#363636"), conts);
                    break;
                case 2: //RED
                    ChangeColors(ColorTranslator.FromHtml("#CA4428"), conts);
                    ChangeBackground(ColorTranslator.FromHtml("#E8AEA2"), conts);
                    break;
                case 3: //BLUE
                    ChangeColors(ColorTranslator.FromHtml("#27858A"), conts);
                    ChangeBackground(ColorTranslator.FromHtml("#8EEBF0"), conts);
                    break;
                case 4: //YELLOW
                    ChangeColors(ColorTranslator.FromHtml("#676419"), conts);
                    ChangeBackground(ColorTranslator.FromHtml("#F1EE9A"), conts);
                    break;
                default:
                    break;
            }
        }



        // Referenced from https://stackoverflow.com/questions/28759764/c-sharp-sethue-or-alternatively-convert-hsl-to-rgb-and-set-rgb
        public struct HSV { public float h; public float s; public float v; }
        public static Color ColorFromHSL(HSV hsl)
        {
            if (hsl.s == 0)
            { int L = (int)hsl.v; return Color.FromArgb(255, L, L, L); }

            double min, max, h;
            h = hsl.h / 360d;

            max = hsl.v < 0.5d ? hsl.v * (1 + hsl.s) : (hsl.v + hsl.s) - (hsl.v * hsl.s);
            min = (hsl.v * 2d) - max;

            Color c = Color.FromArgb(255, (int)(255 * RGBChannelFromHue(min, max, h + 1 / 3d)),
                                          (int)(255 * RGBChannelFromHue(min, max, h)),
                                          (int)(255 * RGBChannelFromHue(min, max, h - 1 / 3d)));
            return c;
        }
        public static double RGBChannelFromHue(double m1, double m2, double h)
        {
            h = (h + 1d) % 1d;
            if (h < 0) h += 1;
            if (h * 6 < 1) return m1 + (m2 - m1) * 6 * h;
            else if (h * 2 < 1) return m2;
            else if (h * 3 < 2) return m1 + (m2 - m1) * 6 * (2d / 3d - h);
            else return m1;

        }
    }
}
