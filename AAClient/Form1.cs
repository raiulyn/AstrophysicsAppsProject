using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SetupMenus();

            ResultsGridView.ColumnCount = 5;
            ResultsGridView.Columns[0].Name = "Release Date";
            ResultsGridView.Columns[1].Name = "Track";
            ResultsGridView.Columns[2].Name = "Title";
            ResultsGridView.Columns[3].Name = "Artist";
            ResultsGridView.Columns[4].Name = "Album";
            PopulateDataGridView(ResultsGridView);

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
    }
}
