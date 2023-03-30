/// \file UI_Add.cs
/// \brief Form for adding a work to the rating

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizer
{
    /// \brief Form UI_Add for adding a work to the rating
    public partial class UI_Add : Form
    {
        /// \brief Controller
        private Controller Controller = new Controller();

        public UI_Add()
        {
            InitializeComponent();
        }

        /// \brief Handling the loading event of the form
        private void UI_Add_Load(object sender, EventArgs e)
        {
            fillComboBoxes();
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

        /// \brief Handling the click on the button to add an element to the rating
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                checkFilds();

                Controller.ratingAdd(textBoxTitle.Text, textBoxCreator.Text, comboBoxGenre.Text, int.Parse(comboBoxRate.Text),
                    richtextBoxReview.Text, textBoxFile.Text);
                this.Hide();
                Controller.showPrevForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Cation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// \brief Checking the content of fields 
        private void checkFilds()
        {
            if (textBoxTitle.Text == "Title" || textBoxTitle.Text.Length == 0)
            {
                throw new Exception("Put in the title!");
            }

            //Checking the language
            if (textBoxTitle.Text.Any(wordByte => wordByte > 127) || textBoxCreator.Text.Any(wordByte => wordByte > 127) ||
                richtextBoxReview.Text.Any(wordByte => wordByte > 127))
            {
                throw new Exception("ALL text must be in English!");
            }

            if (comboBoxRate.SelectedItem == null)
            {
                throw new Exception("Put in the rate from the list!");
            }

            if (textBoxFile.Text == "Click the image for path")
            {
                string path = Directory.GetCurrentDirectory() + @"\Covers\filler.jpg";
                if (File.Exists(path))
                {
                    textBoxFile.Text = path;
                }
                else
                {
                    textBoxFile.Text = null;
                }
            }

            if (comboBoxGenre.SelectedItem == null)
            {
                comboBoxGenre.Text = null;
            }

            if (textBoxCreator.Text == "Creator" || textBoxCreator.Text.Length == 0)
            {
                textBoxCreator.Text = null;
            }

            if (richtextBoxReview.Text == "Empty" || richtextBoxReview.Text.Length == 0)
            {
                richtextBoxReview.Text = null;
            }

        }

        /// \brief Handling the event of mouse entering the area of pictureBox
        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
        }

        /// \brief Handling the event of mouse leaving the area of pictureBox
        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
        }

        /// \brief Handling the event of text changing in the Title field
        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            textBoxTitle.ForeColor = Color.SeaShell;
        }

        /// \brief Handling the event of text changing in the Creator field
        private void textBoxCreator_TextChanged(object sender, EventArgs e)
        {
            textBoxCreator.ForeColor = Color.SeaShell;
        }

        /// \brief Handling the event of genre being selected
        private void comboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxGenre.ForeColor = Color.SeaShell;
        }

        /// \brief Handling the event of rating being selected
        private void comboBoxRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxRate.ForeColor = Color.SeaShell;
        }

        /// \brief Handling the event of text changing in the Review field
        private void richtextBoxReview_TextChanged(object sender, EventArgs e)
        {
            richtextBoxReview.ForeColor = Color.SeaShell;
        }

        /// \brief Handling the form closed event
        private void UI_Add_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Controller.showPrevForm();
        }

        /// \brief Handling the click event in the Creator field
        private void textBoxCreator_Click(object sender, EventArgs e)
        {
            if (textBoxCreator.Text == "Creator")
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

        /// \brief Handling the click event in the Title field
        private void textBoxTitle_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "Title")
            {
                textBoxTitle.SelectAll();
            }
        }

        /// \brief Handling the click event of the pictureBox
        private void pictureBox_MouseDoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog Ofd = new OpenFileDialog();
            if (Ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxFile.Text = Ofd.FileName;
                try
                {
                    var imageCover = Image.FromFile(Ofd.FileName);
                    pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                    pictureBox.Image = imageCover;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wrong file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }
    }
}