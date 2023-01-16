using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fernando_Caraballo_Assignment_2
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e) // Exit app.
        {
            Application.Exit();
        }

        private void BtnMainMenu_Click(object sender, EventArgs e) //Main Menu access
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void BtnRegistration_Click(object sender, EventArgs e) // Registration access
        {
            Form1 Registration = new Form1();
            Registration.Show();
            this.Hide();
        }

        private void BtnSearch_Click(object sender, EventArgs e) // Search access
        {
            Search search = new Search();
            search.Show();
            this.Hide();
        }

        private void BtnHelp_Click(object sender, EventArgs e) //Help access
        {
            Help help = new Help();
            help.Show();
            this.Hide();
        }

        private void Booking_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
