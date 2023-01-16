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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void BtnRegistration_Click(object sender, EventArgs e) // Registration access
        {
            Form1 Registration = new Form1();
            Registration.Show();
            this.Hide();
        }

        private void BtnMainMenu_Click(object sender, EventArgs e) //Main Menu access
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e) // Exit app.
        {
            Application.Exit();
        }

        private void BtnBooking_Click(object sender, EventArgs e) //Booking access
        {
            Booking booking = new Booking();
            booking.Show();
            this.Hide();
        }

        private void Search_Load(object sender, EventArgs e)
        { 
            this.membershipTableAdapter.Fill(this.database1DataSet.Membership);
            
            this.memberTableAdapter.Fill(this.database1DataSet.Member);
        }

        private void BtnHelp_Click(object sender, EventArgs e) //Help access
        {
            Help help = new Help();
            help.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void memberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void btnClear_Click(object sender, EventArgs e) //Clear button filter
        {
            txtMemberIDSearch.Clear();

            memberDataGridView1.DataSource = database1DataSet.Member;
        }

        private void btnRetrieve_Click(object sender, EventArgs e) //Search on gridview
        {

            DataView memberDataView = new DataView(database1DataSet.Member);

            string filter = "";

            filter = "[FNAme] LIKE '" + txtMemberIDSearch.Text + "*'";
            filter += " OR[LName] LIKE '" + txtMemberIDSearch.Text + "*'";
            filter += " OR[FNAme] + ' ' + [LName] LIKE '" + txtMemberIDSearch.Text + "*'";

            memberDataView.RowFilter = filter;

            memberDataGridView.DataSource = memberDataView;

        }

        private void button1_Click(object sender, EventArgs e) //Clear button search
        {
            txtMemberIDSearch.Clear();

            memberDataGridView.DataSource = database1DataSet.Member;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e) //Filter on gridview
        {
            DataView memberDataView = new DataView(database1DataSet.Member);

            string filter = "";

            if (RbBasicFilter.Checked) 
                {
                    filter = "[MembershipID] = " +1;
                }
            else if(RbRegularFilter.Checked)
            {
                filter = "[MembershipID] = " + 2;
            }
            else if (RbPremiumFilter.Checked)
            {
                filter = "[MembershipID] = " + 3;
            }

            memberDataView.RowFilter = filter;

            memberDataGridView1.DataSource = memberDataView;


        }
    }
    }

