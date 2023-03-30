/// \file UI_Edit.cs
/// \brief Form for editing a work in the rating

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
    /// \brief Form UI_Edit for editing a work in the rating
    public partial class UI_Edit : Form
    {
        /// \brief Controller
        private Controller Controller = new Controller();
        int index;

        public UI_Edit(int index_)
        {
            index = index_;
            InitializeComponent();
        }

        /// \brief Handling the loading event of the form
        private void UI_Edit_Load(object sender, EventArgs e)
        {
            fillComboBoxes();
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
            comboBoxGenre.Text = Controller.ratingGetParam("Genre");
            comboBoxRate.Text = Controller.ratingGetParam("Rate");
            richtextBoxReview.Text = Controller.ratingGetParam("Review");

            //If there is no information, inform that fields are empty
            if (textBoxCreator.Text.Length == 0)
            {
                textBoxCreator.Text = "Empty";
                textBoxCreator.ForeColor = SystemColors.ActiveBorder;
            }

            if (comboBoxGenre.Text.Length == 0)
            {
                comboBoxGenre.Text = "Empty";
                comboBoxGenre.ForeColor = SystemColors.ActiveBorder;
            }

            if (richtextBoxReview.Text.Length == 0)
            {
                richtextBoxReview.Text = "Empty";
                richtextBoxReview.ForeColor = SystemColors.ActiveBorder;
            }

        }

        /// \brief Filling out comboBox to choose genre and rating
        private void fillComboBoxes()
        {

            for (int i = 0; i < Controller.genresSize(); i++)
            {
                comboBoxGenre.Items.Add(Controller.getGenres(i));
            }

            for (int i = 0; i < 11; i++)
            {
                comboBoxRate.Items.Add(i);
            }
        }

        /// \brief Handling the click event to save edited work
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                checkFilds();

                Controller.ratingEdit(textBoxTitle.Text, textBoxCreator.Text, comboBoxGenre.Text, int.Parse(comboBoxRate.Text), richtextBoxReview.Text, textBoxFile.Text);
                this.Hide();
                Controller.viewForm(index);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Cation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// \brief Checking the content of fields 
        private void checkFilds()
        {
            if (textBoxTitle.Text.Length == 0)
            {
                throw new Exception("Put in the title!");
            }

            if (comboBoxRate.Text.Length == 0)
            {
                throw new Exception("Put in the rate!");
            }

            //Checking the language
            if (textBoxTitle.Text.Any(wordByte => wordByte > 127) || textBoxCreator.Text.Any(wordByte => wordByte > 127) ||
                richtextBoxReview.Text.Any(wordByte => wordByte > 127))
            {
                throw new Exception("ALL text must be in English!");
            }

            if (textBoxFile.Text == "Click the image for path")
            {
                textBoxFile.Text = null;
            }

            if (comboBoxGenre.SelectedItem == null)
            {
                comboBoxGenre.Text = null;
            }

            if (textBoxCreator.Text == "Empty" || textBoxCreator.Text.Length == 0)
            {
                textBoxCreator.Text = null;
            }

            if (richtextBoxReview.Text == "Empty" || richtextBoxReview.Text.Length == 0)
            {
                richtextBoxReview.Text = null;
            }

        }

        /// \brief Handling the click event of the pictureBox
        private void pictureBoxBook_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog Ofd = new OpenFileDialog();
            if (Ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    textBoxFile.Text = Ofd.FileName;
                    var imageCover = Image.FromFile(Ofd.FileName);
                    pictureBoxBook.SizeMode = PictureBoxSizeMode.CenterImage;
                    pictureBoxBook.Image = imageCover;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wrong file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        /// \brief Handling the event of mouse entering the area of pictureBox
        private void pictureBoxBook_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxBook.BorderStyle = BorderStyle.Fixed3D;
        }

        /// \brief Handling the event of mouse leaving the area of pictureBox
        private void pictureBoxBook_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxBook.BorderStyle = BorderStyle.FixedSingle;
        }

        /// \brief Handling the form closed event
        private void UI_Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Controller.viewForm(index);
        }

        /// \brief Handling the click event in the Creator field
        private void textBoxCreator_Click(object sender, EventArgs e)
        {
            if (textBoxCreator.Text == "Empty")
            {
                textBoxCreator.SelectAll();
            }
        }

        /// \brief Handling the click event in the Review field
        private void richtextBoxReview_Click(object sender, EventArgs e)
        {
            if (richtextBoxReview.Text == "Empty")
            {
                richtextBoxReview.SelectAll();
            }
        }
    }
}
