/// \file UI_HomePage.cs
/// \brief Menu form

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizer
{
    /// \brief Form UI_HomePage, Organizer's menu
    public partial class UI_HomePage : Form
    {
        /// \brief Controller for forms
        private Controller_Forms Controller = new Controller_Forms();

        public UI_HomePage()
        {
            InitializeComponent();
        }

        /// \brief Handling the loading event of the form
        private void UI_HomePage_Load(object sender, EventArgs e)
        {
            LoadImages();
        }

        /// \brief Handling the form closed event
        private void UI_HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Controller.greetingForm();
        }

        /// \brief Loading of menu icons
        private void LoadImages()
        {
            pictureBoxMovies.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxMovies.Image = Organizer.Properties.Resources.movies_icon;

            pictureBoxBooks.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxBooks.Image = Organizer.Properties.Resources.books_icon;

            pictureBoxShows.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxShows.Image = Organizer.Properties.Resources.shows_icon;
        }

        /// \brief Handling the click event on the books icon
        private void pictureBoxBooks_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            Controller.booksForm();
        }


        /// \brief Handling the click event on the movies icon
        private void pictureBoxMovies_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            Controller.moviesForm();
        }


        /// \brief Handling the click event on the shows icon
        private void pictureBoxShows_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            Controller.showsForm();
        }
    }
}
