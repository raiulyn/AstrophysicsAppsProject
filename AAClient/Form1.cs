using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAClient
{
    public partial class Form1 : Form
    {
        IAstroContract channel;
        enum ConnectionStatus
        {
            Waiting,
            Connected,
            Disconnected
        }

        public Form1()
        {
            InitializeComponent();

            CheckConnection();
            SetupMenus();
            SetupDataGridView();
        }

        #region SETUPS
        private IAstroContract SetupConnection()
        {
            string address = "net.pipe://localhost/pipeme";
            NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            EndpointAddress ep = new EndpointAddress(address);
            IAstroContract channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);
            return channel;
        }
        private void UpdateConnectionStatus(ConnectionStatus status)
        {
            switch (status)
            {
                case ConnectionStatus.Waiting:
                    Connection_label.Font = new Font("Arial", 12, FontStyle.Bold);
                    Connection_label.Text = "Waiting for Server Response";
                    Connection_label.ForeColor = Color.Black;
                    break;
                case ConnectionStatus.Connected:
                    Connection_label.Font = new Font("Arial", 18, FontStyle.Bold);
                    Connection_label.Text = "Connected";
                    Connection_label.ForeColor = Color.Green;
                    break;
                case ConnectionStatus.Disconnected:
                    Connection_label.Font = new Font("Arial", 18, FontStyle.Bold);
                    Connection_label.Text = "Disconnected";
                    Connection_label.ForeColor = Color.Red;
                    break;
                default:
                    break;
            }
        }
        private void CheckConnection()
        {
            channel = SetupConnection();
            UpdateConnectionStatus(ConnectionStatus.Waiting);
        }

        private void SetupMenus()
        {
            this.Menu = new MainMenu();
            MenuItem item = new MenuItem("File");
            this.Menu.MenuItems.Add(item);
            item.MenuItems.Add("Save", new EventHandler(Save_Click));
            item.MenuItems.Add("Open", new EventHandler(Open_Click));
            item = new MenuItem("Edit");
            this.Menu.MenuItems.Add(item);
            item.MenuItems.Add("Copy", new EventHandler(Copy_Click));
            item.MenuItems.Add("Paste", new EventHandler(Paste_Click));
        }
        #endregion

        #region MENU_BUTTONS
        private void Paste_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region GRIDVIEW
        private void SetupDataGridView()
        {
            // TEST DATA
            //ResultsGridView.ColumnCount = 5;
            //ResultsGridView.Columns[0].Name = "Release Date";
            //ResultsGridView.Columns[1].Name = "Track";
            //ResultsGridView.Columns[2].Name = "Title";
            //ResultsGridView.Columns[3].Name = "Artist";
            //ResultsGridView.Columns[4].Name = "Album";
            //PopulateDataGridView(ResultsGridView);

            ResultsGridView.ColumnCount = 2;
            ResultsGridView.Columns[0].Name = "Name";
            ResultsGridView.Columns[1].Name = "Value";
        }
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
        private void AddDataGridViewEntry(DataGridView view, params string[] vals)
        {
            string[] row = vals;

            view.Rows.Add(row);
        }
        #endregion

        #region BUTTONS
        private void StarVelocity_btn_Click(object sender, EventArgs e)
        {
            double observed;
            double rest;
            if(!double.TryParse(StarVelocityObserved_textbox.Text, out observed))
            {
                return;
            }
            if (!double.TryParse(StarVelocityRest_textbox.Text, out rest))
            {
                return;
            }
            
            try
            {
                var result = channel.StarVelocty(observed, rest).ToString();
                AddDataGridViewEntry(ResultsGridView, "Star Velocity", result);
                UpdateConnectionStatus(ConnectionStatus.Connected);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                UpdateConnectionStatus(ConnectionStatus.Disconnected);
            }
        }

        private void StarDistance_btn_Click(object sender, EventArgs e)
        {
            double archseconds;
            if(!double.TryParse(StarDistanceArchseconds_textbox.Text, out archseconds))
            {
                return;
            }
            
            try
            {
                var result = channel.StarDistance(archseconds).ToString();
                AddDataGridViewEntry(ResultsGridView, "Star Distance", result);
                UpdateConnectionStatus(ConnectionStatus.Connected);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                UpdateConnectionStatus(ConnectionStatus.Disconnected);
            }
        }

        private void TemperatureKelvin_btn_Click(object sender, EventArgs e)
        {
            double temp;
            if (!double.TryParse(TemperatureKelvin_textbox.Text, out temp))
            {
                return;
            }
            
            try
            {
                var result = channel.TemperatureInKelvin(temp).ToString();
                AddDataGridViewEntry(ResultsGridView, "Temperature", result);
                UpdateConnectionStatus(ConnectionStatus.Connected);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                UpdateConnectionStatus(ConnectionStatus.Disconnected);
            }
        }

        private void Connection_btn_Click(object sender, EventArgs e)
        {
            CheckConnection();
        }

        #endregion

        public void ChangeLanguage(LangOptions options)
        {
            switch (options)
            {
                case LangOptions.EnglishUK:
                    StarVelocity_btn.Text = LanguagePack.TEXT_Calculate.EnglishUK;
                    StarDistance_btn.Text = LanguagePack.TEXT_Calculate.EnglishUK;
                    TemperatureKelvin_btn.Text = LanguagePack.TEXT_Calculate.EnglishUK;
                    EventHorizon_btn.Text = LanguagePack.TEXT_Calculate.EnglishUK;
                    break;
                case LangOptions.French:
                    StarVelocity_btn.Text = LanguagePack.TEXT_Calculate.French;
                    StarDistance_btn.Text = LanguagePack.TEXT_Calculate.French;
                    TemperatureKelvin_btn.Text = LanguagePack.TEXT_Calculate.French;
                    EventHorizon_btn.Text = LanguagePack.TEXT_Calculate.French;
                    break;
                case LangOptions.German:
                    StarVelocity_btn.Text = LanguagePack.TEXT_Calculate.German;
                    StarDistance_btn.Text = LanguagePack.TEXT_Calculate.German;
                    TemperatureKelvin_btn.Text = LanguagePack.TEXT_Calculate.German;
                    EventHorizon_btn.Text = LanguagePack.TEXT_Calculate.German;
                    break;
                default:
                    break;
            }
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

        private void ColorPickerButton_Click(object sender, EventArgs e)
        {
            VisualStylePack.PickColors(ColorPickerButton);
        }
    }
}
