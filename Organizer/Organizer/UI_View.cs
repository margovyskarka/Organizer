/// \file UI_View.cs
/// \brief Form for viewing a work in the rating

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizer
{
    /// \brief Form UI_View for viewing a work in the rating
    public partial class UI_View : Form
    {
        /// \brief Controller
        private Controller Controller = new Controller();

        public UI_View()
        {
            InitializeComponent();
        }

        /// \brief Handling the loading event of the form
        private void UI_View_Load(object sender, EventArgs e)
        {
            fillBoxes();
        }

        /// \brief Filling out the fields
        private void fillBoxes()
        {
            pictureBoxBook.SizeMode = PictureBoxSizeMode.CenterImage;
            try
            {
                pictureBoxBook.Image = Image.FromFile(@Controller.ratingGetParam("Image"));
                textBoxFile.Text = Controller.ratingGetParam("Image");
            }
            catch (Exception e)
            {
                pictureBoxBook.Image = null;
                textBoxFile.Text = null;
            }

            textBoxTitle.Text = Controller.ratingGetParam("Title");
            textBoxCreator.Text = Controller.ratingGetParam("Creator");
            textBoxGenre.Text = Controller.ratingGetParam("Genre");
            textBoxRate.Text = Controller.ratingGetParam("Rate");
            richtextBoxReview.Text = Controller.ratingGetParam("Review");
            buttonEdit.Text = "Edit";

            //If there is no information, fill with "---"

            if (textBoxCreator.Text.Length == 0)
            {
                textBoxCreator.Text = "---------";
                textBoxCreator.ForeColor = SystemColors.ActiveBorder;
            }

            if (textBoxGenre.Text.Length == 0)
            {
                textBoxGenre.Text = "---------";
                textBoxGenre.ForeColor = SystemColors.ActiveBorder;
            }

            if (richtextBoxReview.Text.Length == 0)
            {
                richtextBoxReview.Text = "---------";
                richtextBoxReview.ForeColor = SystemColors.ActiveBorder;
            }
        }

        /// \brief Handling the form closed event
        private void UI_View_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Controller.showPrevForm();
        }

        /// \brief Handling the click on the button to edit an element in the rating
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Controller.editForm();
        }
    }
}
