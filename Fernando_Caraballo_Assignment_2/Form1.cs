using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Fernando_Caraballo_Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Variables

        //****************************************************************************************************
       
        int membershipIDTable;
        string membershipTypeTable;
        int membershipCostTable;


        int[] membershipID = { 0, 0, 0 };
        string [] membershipType = { "", "", "" };
        int[] planCost = { 0, 0, 0 };
        int[] planDuration = { 13, 52, 104 };
        int[] extras = { 1, 20, 20, 2 };
        int flag = 0;


        //****************************************************************************************************


        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.membershipTableAdapter.Fill(this.database1DataSet.Membership);
            
            this.memberTableAdapter.Fill(this.database1DataSet.Member);


           membershipRetrieval();

        }

        private void membershipRetrieval() // Obtaining data from membership table
        {
            int i = 0;
            foreach(DataRow r in database1DataSet.Membership.Rows)
            {
                membershipID[i] = Int32.Parse(r["MembershipID"].ToString());
                planCost[i] = Int32.Parse(r["Cost"].ToString());
                membershipType[i] = r["Description"].ToString();
                i++;
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            // Error checking**********************************************************************************

            bool errorA = ErrorCheck();


            if (errorA)
            {
                MessageBox.Show("Please complete all fields and select Plan, Duration and Periodicity");
            }
            else
            {
                //Calculations*********************************************************************************

                int selectedPlan = PlanSelection();
                int[] selectedExtras = ExtrasSelection();
                int selectedDuration = DurationSelection();



                double A = PlanCostTotal(selectedPlan);
                double B = ExtrasCostTotal(selectedExtras);
                double C = Duration(selectedDuration);
                double D = DiscountPlan();
                double D1 = DiscountDebit();
                double P = PeriodicitySelection2();


                // Maths for display

                double totalMembership = (A + B) * C;                       // Plan selected + extras * the lenght of the plan       
                double extracharges = B * C;                                // Extra charges * lenght
                double debitdiscount = A * C * D1;                          // Discount included in plan only (1%)
                double totaldiscount = debitdiscount + D;                   // total discount of plan and debit
                double netmembership = totalMembership - totaldiscount;     // Total cost of membership including all extras and all discount
                double regpayment = netmembership / P;                      // Regular payment to be done base on the netcost and the weekly or monthly selection


                // Display

                TBExtracharges.Text = extracharges.ToString("n2");
                TBTotalMemCost.Text = totalMembership.ToString("n2");
                TBTotalDiscount.Text = totaldiscount.ToString("n2");
                TBNetMemCost.Text = netmembership.ToString("n2");
                TBRegPaymentAmount.Text = regpayment.ToString("n2");

                flag = 1;



                //********************************************************************************************** 

            }



        }

        private bool ErrorCheck() //Error check method
        {
            bool a = false;

            if (TBFirstName.TextLength == 0 || TBLastName.Text.Length == 0 || TBAddress.Text.Length == 0 || TBMobile.Text.Length == 0 || PeriodicitySelection2() == 0 || DurationSelection() == 3 || PlanSelection() == 3)
            {
                a = true;
            }

            return a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RBBasic.Checked = false;
            RBRegular.Checked = false;
            RBPremium.Checked = false;
            RB3Months.Checked = false;
            RB12Months.Checked = false;
            RB24Months.Checked = false;
            RBWeekly.Checked = false;
            RBMonthly.Checked = false;
            CBAccess.Checked = false;
            CBAccessOnline.Checked = false;
            CBDietPlan.Checked = false;
            CBDirectDebit.Checked = false;
            CBPersonalTrainer.Checked = false;


            TBRegPaymentAmount.Text = "";
            TBNetMemCost.Text = "";
            TBTotalDiscount.Text = "";
            TBExtracharges.Text = "";
            TBTotalMemCost.Text = "";
            TBFirstName.Text = "";
            TBLastName.Text = "";
            TBAddress.Text = "";
            TBMobile.Text = "";
        }

        private int Duration(int durationSelection) //Assigning value to duration selection
        {
            return (planDuration[durationSelection]);
        }

        private double PeriodicitySelection2() //Method to determine periodicity selection
        {
            double per = NewMethod();

            if (RBWeekly.Checked && RB3Months.Checked)
            {
                per = 13;
            }
            else if (RBWeekly.Checked && RB12Months.Checked)
            {
                per = 52;
            }
            else if (RBWeekly.Checked && RB24Months.Checked)
            {
                per = 104;
            }
            else if (RBMonthly.Checked && RB3Months.Checked)
            {
                per = 3;
            }
            else if (RBMonthly.Checked && RB12Months.Checked)
            {
                per = 12;
            }
            else if (RBMonthly.Checked && RB24Months.Checked)
            {
                per = 24;
            }

            return per;

        }

        private static double NewMethod() // Return 0 for no selection of Periodicity Method
        {
            return 0;
        }

        private double DiscountDebit()  // Discount debit method
        {
            double discD = 0;

            if (CBDirectDebit.Checked)
            {
                discD = 0.01;
            }

            return discD;

        }

        private string Frequency() //Frequency method to load in Database
        {
            string freq = "";

            if (RBWeekly.Checked)
            {
                freq = "weekly";
            }
            else
            {
                freq = "Monthly";
            }

            return freq;
        }


        private int DiscountPlan()  // Discount plan selection method
        {
            int discP = 0;

            if (RB3Months.Checked)
            {
                discP = 0;
            }
            else if (RB12Months.Checked)
            {
                discP = 104;
            }
            else if (RB24Months.Checked)
            {
                discP = 520;
            }

            return discP;

        }

        private int DurationSelection() // Duration selection method 
        {

            int d = 3;

            if (RB3Months.Checked)
            {
                d = 0;
            }
            else if (RB12Months.Checked)
            {
                d = 1;
            }
            else if (RB24Months.Checked)
            {
                d = 2;
            }

            return d;

        }

        private int PlanCostTotal(int selectedPlan) //Method to assign value to plan selected
        {
            return (planCost[selectedPlan]);
        }


        private int ExtrasCostTotal(int[] selectedExtras) //Method to assign total value of extras
        {
            int selections = 0;

            for (int i = 0; i < selectedExtras.Length; i++)
            {
                if (selectedExtras[i] == 1)
                {
                    selections += extras[i];
                }

            }

            return selections;
        }

        private int PlanSelection() // Plan selection method
        {         
            int index = 10;

            if (RBBasic.Checked)
            {
                index = 0;
            }
            else if (RBRegular.Checked)
            {
                index = 1;
            }
            else if (RBPremium.Checked)
            {
                index = 2;
            }

            membershipCostTable = planCost[index];
            membershipIDTable = membershipID[index];
            membershipTypeTable = membershipType[index];

            return index;

        }

        private int[] ExtrasSelection() // Extras selection method

        {
            bool[] selections = { CBAccess.Checked, CBPersonalTrainer.Checked, CBDietPlan.Checked, CBAccessOnline.Checked };
            int[] a = { 0, 0, 0, 0 };

            for (int i = 0; i < a.Length; i++)
            {
                if (selections[i])
                {
                    a[i] = 1;
                }
            }
            return a;
        }

        private string DiscountDebitSelection() // Method to determine if direct debit was selected
        {
            string answer;

            if (CBDirectDebit.Checked)

            {

                answer = "Yes";
            }
            else
            {
                answer = "No";
            }

            return answer;

        }

        private void BPSavetoFile_Click(object sender, EventArgs e)  //Save to database
        {
            if (flag == 1)
            {

                Database1DataSet.MemberRow newRow = database1DataSet.Member.NewMemberRow();

                newRow.MemberID = database1DataSet.Member.Count + 1;
                newRow.FNAme = TBFirstName.Text;
                newRow.LName = TBLastName.Text;
                newRow.Address = TBAddress.Text;
                newRow.Mobile = TBMobile.Text;
                newRow.DiscountAmount = double.Parse(TBTotalDiscount.Text);
                newRow.ExtraAmount = double.Parse(TBExtracharges.Text);
                newRow.PaymentFrecuency = Frequency();
                newRow.TotalAmount = double.Parse(TBNetMemCost.Text);
                newRow.MembershipID = membershipIDTable;
                database1DataSet.Member.Rows.Add(newRow);
                memberTableAdapter.Update(database1DataSet.Member);


            }
            else
            {
                MessageBox.Show("Complete calculation first");
            }

        }

        private void TBFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {

        }

        private void BtnMainMenu_Click(object sender, EventArgs e) //Main Menu access
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();

        }

        private void BtnExit_Click_1(object sender, EventArgs e) // Exit app.
        {

            Application.Exit(); 
            
        }

        private void BtnBookingClass_Click(object sender, EventArgs e) //Booking access
        {
            Booking booking = new Booking();
            booking.Show();
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

        private void memberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void membershipDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
