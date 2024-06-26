﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Windows.Forms;

// RAYMOND LAI
// STUDENT ID: 30082866
// DATE: 23/04/2024

namespace AAClient
{
    public partial class MainWindow : Form
    {
        // Global Localization Setting
        private string _localization = "EnglishUK";

        //Constructor
        public MainWindow()
        {
            InitializeComponent();

            SetupMenus();
            SetupDataGridView();
            //GenerateXmlLocalization(); //Uncomment to generate a localization template file
        }

        #region SETUPS
        /// <summary>
        /// Sets up the Connection to the Server
        /// </summary>
        /// <returns></returns>
        private IAstroContract SetupConnection()
        {
            try
            {
                string address = "net.pipe://localhost/pipeme";
                NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
                EndpointAddress ep = new EndpointAddress(address);
                IAstroContract channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);
                return channel;
            }
            catch (Exception)
            {
                OutputMessage("No Server found!");
                return null;
            }
        }

        /// <summary>
        /// Sets up Menu Options
        /// </summary>
        private void SetupMenus()
        {
            this.Menu = new MainMenu();

            MenuItem item = new MenuItem(XmlLocalization.ReadXML(_localization + ".xml", "TEXT_File"));
            this.Menu.MenuItems.Add(item);
            item.MenuItems.Add(XmlLocalization.ReadXML(_localization + ".xml", "TEXT_Close"), new EventHandler(Close_Click));

            item = new MenuItem(XmlLocalization.ReadXML(_localization + ".xml", "TEXT_Languages"));
            this.Menu.MenuItems.Add(item);
            item.MenuItems.Add("English UK", new EventHandler(EnglishButton_Click));
            item.MenuItems.Add("French", new EventHandler(FrenchButton_Click));
            item.MenuItems.Add("German", new EventHandler(GermanButton_Click));

            item = new MenuItem(XmlLocalization.ReadXML(_localization + ".xml", "TEXT_Customization"));
            this.Menu.MenuItems.Add(item);
            item.MenuItems.Add(XmlLocalization.ReadXML(_localization + ".xml", "TEXT_Background"), new EventHandler(BackgroundPickerButton_Click));
            item.MenuItems.Add(XmlLocalization.ReadXML(_localization + ".xml", "TEXT_Colors"), new EventHandler(ColorPickerButton_Click));
            item.MenuItems.Add(XmlLocalization.ReadXML(_localization + ".xml", "TEXT_Fonts"), new EventHandler(FontPickerButton_Click));

            MenuItem subitem = new MenuItem(XmlLocalization.ReadXML(_localization + ".xml", "TEXT_Themes"));
            item.MenuItems.Add(subitem);
            subitem.MenuItems.Add(XmlLocalization.ReadXML(_localization + ".xml", "TEXT_Default"), new EventHandler(DefaultTheme_Button_Click));
            subitem.MenuItems.Add(XmlLocalization.ReadXML(_localization + ".xml", "TEXT_Black"), new EventHandler(BlackTheme_Button_Click));
            subitem.MenuItems.Add(XmlLocalization.ReadXML(_localization + ".xml", "TEXT_Red"), new EventHandler(RedTheme_Button_Click));
            subitem.MenuItems.Add(XmlLocalization.ReadXML(_localization + ".xml", "TEXT_Blue"), new EventHandler(BlueTheme_Button_Click));
            subitem.MenuItems.Add(XmlLocalization.ReadXML(_localization + ".xml", "TEXT_Yellow"), new EventHandler(YellowTheme_Button_Click));
        }

        #endregion

        #region GRIDVIEW
        /// <summary>
        /// Sets up the Data Grid View with the needed columns
        /// </summary>
        private void SetupDataGridView()
        {
            ResultsGridView.ColumnCount = 4;
            UpdateLocalizedDataGridView();
        }
        /// <summary>
        /// Localise Data Grid View's Column headers
        /// </summary>
        private void UpdateLocalizedDataGridView()
        {
            ResultsGridView.Columns[0].Name = XmlLocalization.ReadXML(_localization + ".xml", "TEXT_StarVelocity");
            ResultsGridView.Columns[1].Name = XmlLocalization.ReadXML(_localization + ".xml", "TEXT_StarDistance");
            ResultsGridView.Columns[2].Name = XmlLocalization.ReadXML(_localization + ".xml", "TEXT_Temperature");
            ResultsGridView.Columns[3].Name = XmlLocalization.ReadXML(_localization + ".xml", "TEXT_EventHorizon");
        }
        /// <summary>
        /// Test Data for Data Grid View. Not Important and can be safely removed.
        /// </summary>
        /// <param name="view"></param>
        private void PopulateDataGridView(DataGridView view)
        {
            string[] row0 = { "11/22/1968", "29", "Revolution 9",
            "Beatles", "The Beatles [White Album]" };
            string[] row1 = { "1960", "6", "Fools Rush In",
            "Frank Sinatra", "Nice 'N' Easy" };
            string[] row2 = { "11/11/1971", "1", "One of These Days",
            "Pink Floyd", "Meddle" };
            string[] row3 = { "1988", "7", "Where Is My Mind?",
            "Pixies", "Surfer Rosa" };
            string[] row4 = { "5/1981", "9", "Can't Find My Mind",
            "Cramps", "Psychedelic Jungle" };
            string[] row5 = { "6/10/2003", "13",
            "Scatterbrain. (As Dead As Leaves.)",
            "Radiohead", "Hail to the Thief" };
            string[] row6 = { "6/30/1992", "3", "Dress", "P J Harvey", "Dry" };

            view.Rows.Add(row0);
            view.Rows.Add(row1);
            view.Rows.Add(row2);
            view.Rows.Add(row3);
            view.Rows.Add(row4);
            view.Rows.Add(row5);
            view.Rows.Add(row6);
        }

        /// <summary>
        /// Takes in the Data Grid View and insert the values into it
        /// The values parameters are under the params keyword.
        /// Please input an array of strings according to the number of columns in th Data Grid View
        /// </summary>
        /// <param name="view"></param>
        /// <param name="vals"></param>
        private void AddDataGridViewEntry(DataGridView view, params string[] vals)
        {
            string[] row = vals;

            view.Rows.Add(row);
        }
        #endregion

        #region SERVER EVENTS
        private void CalculateAll_Button_Click(object sender, EventArgs e)
        {
            var channel = SetupConnection();

            //Checks if all input values are doubles
            //StarVelocity
            double observed;
            double rest;
            if (!double.TryParse(StarVelocityObserved_textbox.Text, out observed))
            {
                return;
            }
            if (!double.TryParse(StarVelocityRest_textbox.Text, out rest))
            {
                return;
            }
            //StarDistance
            double archseconds;
            if (!double.TryParse(StarDistanceArchseconds_textbox.Text, out archseconds))
            {
                return;
            }
            //Temperature
            double temp;
            if (!double.TryParse(TemperatureKelvin_textbox.Text, out temp))
            {
                return;
            }
            //EventHorizon
            double evn;
            if (!double.TryParse(EventHorizon_textbox.Text, out evn))
            {
                return;
            }

            //Execute
            try
            {
                var result1 = channel.StarVelocty(observed, rest).ToString() + " V";
                var result2 = channel.StarDistance(archseconds).ToString() + " m/s";
                var result3 = channel.TemperatureInKelvin(temp).ToString() + " K";
                var result4 = channel.EventHorizon(evn).ToString() + " Radius";
                AddDataGridViewEntry(ResultsGridView, result1, result2, result3, result4);
                OutputMessage("Result: " + result1 + " | " + result2 + " | " + result3 + " | " + result4);

                StarVelocityObserved_textbox.Text = string.Empty;
                StarVelocityRest_textbox.Text = string.Empty;
                StarDistanceArchseconds_textbox.Text = string.Empty;
                TemperatureKelvin_textbox.Text = string.Empty;
                EventHorizon_textbox.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                OutputMessage(XmlLocalization.ReadXML(_localization + ".xml", "TEXT_ServerIsNotConnected"));
            }
        }
        private void StarVelocity_btn_Click(object sender, EventArgs e)
        {
            var channel = SetupConnection();
            double observed;
            double rest;
            if (!double.TryParse(StarVelocityObserved_textbox.Text, out observed))
            {
                return;
            }
            if (!double.TryParse(StarVelocityRest_textbox.Text, out rest))
            {
                return;
            }

            try
            {
                var result = channel.StarVelocty(observed, rest).ToString() + " V";
                AddDataGridViewEntry(ResultsGridView, result);
                OutputMessage("Result: " + result);

                StarVelocityObserved_textbox.Text = string.Empty;
                StarVelocityRest_textbox.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                OutputMessage(XmlLocalization.ReadXML(_localization + ".xml", "TEXT_ServerIsNotConnected"));
            }
        }
        private void StarDistance_btn_Click(object sender, EventArgs e)
        {
            var channel = SetupConnection();
            double archseconds;
            if (!double.TryParse(StarDistanceArchseconds_textbox.Text, out archseconds))
            {
                return;
            }

            try
            {
                var result = channel.StarDistance(archseconds).ToString() + " m/s";
                AddDataGridViewEntry(ResultsGridView, string.Empty, result);
                OutputMessage("Result: " + result);

                StarDistanceArchseconds_textbox.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                OutputMessage(XmlLocalization.ReadXML(_localization + ".xml", "TEXT_ServerIsNotConnected"));
            }
        }
        private void TemperatureKelvin_btn_Click(object sender, EventArgs e)
        {
            var channel = SetupConnection();
            double temp;
            if (!double.TryParse(TemperatureKelvin_textbox.Text, out temp))
            {
                return;
            }

            try
            {
                var result = channel.TemperatureInKelvin(temp).ToString() + " K";
                AddDataGridViewEntry(ResultsGridView, string.Empty, string.Empty, result);
                OutputMessage("Result: " + result);

                TemperatureKelvin_textbox.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                OutputMessage(XmlLocalization.ReadXML(_localization + ".xml", "TEXT_ServerIsNotConnected"));
            }
        }
        private void EventHorizon_btn_Click(object sender, EventArgs e)
        {
            var channel = SetupConnection();
            double temp;
            if (!double.TryParse(EventHorizon_textbox.Text, out temp))
            {
                return;
            }

            try
            {
                var result = channel.EventHorizon(temp).ToString() + " Radius";
                AddDataGridViewEntry(ResultsGridView, string.Empty, string.Empty, string.Empty, result);
                OutputMessage("Result: " + result);

                EventHorizon_textbox.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                OutputMessage(XmlLocalization.ReadXML(_localization + ".xml", "TEXT_ServerIsNotConnected"));
            }
        }

        #endregion

        #region BUTTONS
        /// <summary>
        /// Closes the Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void EnglishButton_Click(object sender, EventArgs e)
        {
            ChangeLanguage(LangOptions.EnglishUK);
        }

        private void FrenchButton_Click(object sender, EventArgs e)
        {
            ChangeLanguage(LangOptions.French);
        }

        private void GermanButton_Click(object sender, EventArgs e)
        {
            ChangeLanguage(LangOptions.German);
        }

        private void BackgroundPickerButton_Click(object sender, EventArgs e)
        {
            var arr = Controls.OfType<Control>().ToArray();
            VisualStylePack.PickThemes(BackgroundPicker_Button, arr);
        }
        private void ColorPickerButton_Click(object sender, EventArgs e)
        {
            var arr = Controls.OfType<Control>().ToArray();
            VisualStylePack.PickColors(ColorPicker_Button, arr);
        }
        private void FontPickerButton_Click(object sender, EventArgs e)
        {
            var arr = Controls.OfType<Control>().ToArray();
            VisualStylePack.PickFonts(FontPicker_Button, arr);
        }
        private void DefaultTheme_Button_Click(object sender, EventArgs e)
        {
            var arr = Controls.OfType<Control>().ToArray();
            VisualStylePack.ChangeToPresetTheme(0, arr);
        }

        private void BlackTheme_Button_Click(object sender, EventArgs e)
        {
            var arr = Controls.OfType<Control>().ToArray();
            VisualStylePack.ChangeToPresetTheme(1, arr);
        }

        private void RedTheme_Button_Click(object sender, EventArgs e)
        {
            var arr = Controls.OfType<Control>().ToArray();
            VisualStylePack.ChangeToPresetTheme(2, arr);
        }
        private void BlueTheme_Button_Click(object sender, EventArgs e)
        {
            var arr = Controls.OfType<Control>().ToArray();
            VisualStylePack.ChangeToPresetTheme(3, arr);
        }
        private void YellowTheme_Button_Click(object sender, EventArgs e)
        {
            var arr = Controls.OfType<Control>().ToArray();
            VisualStylePack.ChangeToPresetTheme(4, arr);
        }
        #endregion

        #region MISC
        /// <summary>
        /// Change Application Language.
        /// </summary>
        /// <param name="options">Choice of Language</param>
        public void ChangeLanguage(LangOptions options)
        {
            string calc_text = "";

            switch (options)
            {
                case LangOptions.EnglishUK:
                    _localization = "EnglishUK";

                    break;
                case LangOptions.French:
                    _localization = "French";
                    break;
                case LangOptions.German:
                    _localization = "German";
                    break;
                default:
                    break;
            }
            UpdateLocalizedDataGridView();
            SetupMenus();

            calc_text = XmlLocalization.ReadXML(_localization + ".xml", "TEXT_Calculate");
            StarVelocity_btn.Text = calc_text;
            StarDistance_btn.Text = calc_text;
            TemperatureKelvin_btn.Text = calc_text;
            EventHorizon_btn.Text = calc_text;

            CalculateAll_Button.Text = XmlLocalization.ReadXML(_localization + ".xml", "TEXT_CalculateAll");

            StarVelocity_label.Text = XmlLocalization.ReadXML(_localization + ".xml", "TEXT_StarVelocity");
            StarDistance_label.Text = XmlLocalization.ReadXML(_localization + ".xml", "TEXT_StarDistance");
            Temperature_label.Text = XmlLocalization.ReadXML(_localization + ".xml", "TEXT_Temperature");
            EventHorizen_label.Text = XmlLocalization.ReadXML(_localization + ".xml", "TEXT_EventHorizon");

            DefaultTheme_Button.Text = XmlLocalization.ReadXML(_localization + ".xml", "TEXT_Default");
            BlackTheme_Button.Text = XmlLocalization.ReadXML(_localization + ".xml", "TEXT_Black");
            RedTheme_Button.Text = XmlLocalization.ReadXML(_localization + ".xml", "TEXT_Red");

            BackgroundPicker_Button.Text = XmlLocalization.ReadXML(_localization + ".xml", "TEXT_PickBackground");
            ColorPicker_Button.Text = XmlLocalization.ReadXML(_localization + ".xml", "TEXT_PickColors");
            FontPicker_Button.Text = XmlLocalization.ReadXML(_localization + ".xml", "TEXT_PickFonts");
        }

        /// <summary>
        /// Generate a template XML for localization. Once translations are finished, rename the XML file to the appriorate language.
        /// </summary>
        private void GenerateXmlLocalization()
        {
            var xml = new XmlLocalization();

            List<string> tags = new List<string>();
            tags.Add("TEXT_Calculate");
            tags.Add("TEXT_StarVelocity");
            tags.Add("TEXT_StarDistance");
            tags.Add("TEXT_Temperature");
            tags.Add("TEXT_EventHorizon");

            tags.Add("TEXT_PickThemes");
            tags.Add("TEXT_PickColors");
            tags.Add("TEXT_PickFonts");

            tags.Add("TEXT_Connected");
            tags.Add("TEXT_Disconnected");
            tags.Add("TEXT_CheckServer");

            xml.tags = tags.ToArray();
            xml.CreateXML();
        }

        /// <summary>
        /// Outputs a message in the Message Textbox.
        /// </summary>
        private void OutputMessage(string msg)
        {
            MessageBox.Text = msg;
        }

        /// <summary>
        /// Keypress Event to check and allow numeric only inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnKeyInput(object sender, KeyPressEventArgs e)
        {
            
            // Check for the flag being set in the KeyDown event.
            bool isNumber = Char.IsNumber(e.KeyChar);
            if (Char.IsControl(e.KeyChar))
            {
                isNumber = true;
            }
            if (e.KeyChar == '.')
            {
                isNumber = !(sender as TextBox).Text.Contains(".");
            }

            if (!isNumber)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }

        }
        #endregion

    }
}
