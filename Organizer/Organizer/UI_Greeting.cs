/// \file UI_Greeting.cs
/// \brief Greeting form

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
    /// \brief Form UI_Greeting is meant for greeting a user
    public partial class UI_Greeting : Form
    {
        /// \brief Controller for forms
        private Controller_Forms Controller = new Controller_Forms();

        public UI_Greeting()
        {
            InitializeComponent();
        }

        /// \brief Handling the form closed event
        private void UI_Greeting_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// \brief Handling the click event on the button
        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Controller.homepageForm();
        }
    }
}
