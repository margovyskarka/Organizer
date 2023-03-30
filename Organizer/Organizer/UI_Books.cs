/// \file UI_Books.cs
/// \brief Books section's form

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
    /// \brief Form UI_Books for movies section
    public partial class UI_Books : Form
    {
        /// \brief Controller of type "Books"
        private Controller Controller = new Controller("Books");
        /// \brief Checking for an added to the list row
        private bool newRowAdding = false;
        /// \brief Checking for switching of search results
        private bool is_list = true;

        public UI_Books()
        {
            InitializeComponent();
        }

        /// \brief Handling the loading event of the form
        private void UI_Books_Load(object sender, EventArgs e)
        {
            LoadComponents();
            LoadLists();
        }

        /// \brief Handling the form closed event
        private void UI_Books_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Controller.homepageShow();
        }

        /// \brief Loading components of the form
        private void LoadComponents()
        {
            pictureBoxBookCover.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxBookCover.Image = Organizer.Properties.Resources.book_cover;

            dataGridViewSearch.Hide();
            buttonSwitch.Hide();
        }

        /// \brief Loading lists
        private void LoadLists()
        {
            LoadList();
            LoadRating();
            comboBoxLists.Text = comboBoxLists.Items[1].ToString();
            dGVBooklist.Hide();

        }

        /// \brief Loading a list
        private void LoadList()
        {
            dGVBooklist.DataSource = Controller.listLoad();

            for (int i = 0; i < dGVBooklist.Rows.Count; i++)
            {
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                dGVBooklist[3, i] = linkCell;
            }
        }

        /// \brief Loading rating
        private void LoadRating()
        {
            dGVRating.DataSource = Controller.ratingLoad();
        }

        /// \brief Handling the list cell content click event
        private void dGVBooklist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                string action = dGVBooklist.Rows[e.RowIndex].Cells[3].Value.ToString();

                if (action == "Delete")
                {
                    if (MessageBox.Show("Delete this row?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        int rowIndex = e.RowIndex;

                        dGVBooklist.Rows.RemoveAt(rowIndex);
                        Controller.listRemoveAt(rowIndex);
                    }

                }
                else if (action == "Insert")
                {
                    if (MessageBox.Show("Add this row?", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        int rowIndex = e.RowIndex;
                        bool check;
                        if (dGVBooklist.Rows[rowIndex].Cells[2].Value.ToString() == "")
                        {
                            check = false;
                        }
                        else
                        {
                            check = true;
                        }

                        try
                        {
                            //Checking the language
                            if (dGVBooklist.Rows[rowIndex].Cells[0].Value.ToString().Any(wordByte => wordByte > 127) ||
                               dGVBooklist.Rows[rowIndex].Cells[1].Value.ToString().Any(wordByte => wordByte > 127))
                            {
                                throw new Exception("ALL text must be in English!");
                            }

                            Controller.listAdd(dGVBooklist.Rows[rowIndex].Cells[0].Value.ToString(), dGVBooklist.Rows[rowIndex].Cells[1].Value.ToString(),
                           check); ;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"{ex.Message}", "Cation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }



                        newRowAdding = false;
                    }
                }
                else if (action == "Update")
                {
                    if (MessageBox.Show("Update this row?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        int rowIndex = e.RowIndex;

                        try
                        {
                            //Checking the language
                            if (dGVBooklist.Rows[rowIndex].Cells[0].Value.ToString().Any(wordByte => wordByte > 127) ||
                               dGVBooklist.Rows[rowIndex].Cells[1].Value.ToString().Any(wordByte => wordByte > 127))
                            {
                                throw new Exception("ALL text must be in English!");
                            }

                            Controller.listEdit(rowIndex, dGVBooklist.Rows[rowIndex].Cells[0].Value.ToString(), dGVBooklist.Rows[rowIndex].Cells[1].Value.ToString(),
                            bool.Parse(dGVBooklist.Rows[rowIndex].Cells[2].Value.ToString()));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"{ex.Message}", "Cation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }

                dGVBooklist.DataSource = Controller.listReload();
            }
        }

        /// \brief Handling the user added row event
        private void dGVBooklist_UserAddedRow1(object sender, DataGridViewRowEventArgs e)
        {
            if (newRowAdding == false)
            {
                newRowAdding = true;

                int lastRow = dGVBooklist.Rows.Count - 2;

                DataGridViewRow row = dGVBooklist.Rows[lastRow];

                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                dGVBooklist[3, lastRow] = linkCell;
                row.Cells[3].Value = "Insert";

            }
        }

        /// \brief Handling the cell value changed event
        private void dGVBooklist_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (newRowAdding == false)
            {
                int rowIndex = dGVBooklist.SelectedCells[0].RowIndex;

                DataGridViewRow editingRow = dGVBooklist.Rows[rowIndex];
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                dGVBooklist[3, rowIndex] = linkCell;
                editingRow.Cells[3].Value = "Update";
            }
        }

        /// \brief Handling the click on the button to add an element to the rating
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Controller.addForm();
            dGVRating.DataSource = Controller.ratingReload();
        }

        /// \brief Handling the click on the button to delete an element from the rating
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this row?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
            {
                int row;
                row = dGVRating.CurrentCell.RowIndex;
                dGVRating.Rows.RemoveAt(row);
                Controller.ratingRemoveAt(row);
            }
        }

        /// \brief Handling the click on the button to view an element from the rating
        private void buttonView_Click(object sender, EventArgs e)
        {
            int row;
            row = dGVRating.CurrentCell.RowIndex;
            this.Hide();
            Controller.viewForm(row);
            dGVRating.DataSource = Controller.ratingReload();
        }

        /// \brief Handling the change of list's type
        private void comboBoxLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLists.SelectedIndex == 0)
            {
                dGVBooklist.Show();
                dGVRating.Hide();

                buttonDelete.Hide();
                buttonView.Hide();
                buttonAdd.Hide();
            }
            else
            {
                dGVRating.Show();
                buttonDelete.Show();
                buttonView.Show();
                buttonAdd.Show();
                dGVBooklist.Hide();
            }
        }

        /// \brief Handling the click on the button to search in lists
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewSearch.Hide();
            buttonSwitch.Hide();

            //There is information to search
            if (textBoxSearch.Text.Length != 0)
            {
                Controller.searchRating(textBoxSearch.Text);
                Controller.searchList(textBoxSearch.Text);

                //There aren't any works
                if (Controller.getResultRating() == null && Controller.getResultList() == null)
                {
                    MessageBox.Show("Can't find one!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxSearch.Clear();
                }

                //There are works in both lists
                if (Controller.getResultRating() != null && Controller.getResultList() != null)
                {
                    dataGridViewSearch.DataSource = Controller.getResultRating();
                    dataGridViewSearch.Show();
                    buttonSwitch.Show();
                }
                else if (Controller.getResultRating() != null) //The work is in the rating
                {
                    dataGridViewSearch.DataSource = Controller.getResultRating();
                    dataGridViewSearch.Show();
                }
                else if (Controller.getResultList() != null) //The work is in the watchlist
                {
                    dataGridViewSearch.DataSource = Controller.getResultList();
                    dataGridViewSearch.Show();
                }
            }

        }

        /// \brief Handling the click on the button to change the search result
        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            if (is_list == true)
            {
                is_list = false;
                dataGridViewSearch.DataSource = Controller.getResultList();
                buttonSwitch.Text = "< Rating";
            }
            else
            {
                is_list = true;
                dataGridViewSearch.DataSource = Controller.getResultRating();
                buttonSwitch.Text = "List >";
            }
        }

    }
}
