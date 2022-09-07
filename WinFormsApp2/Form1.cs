namespace WinFormsApp2
{

    public partial class Form1 : Form
    {
        //The numbered words papir with an integer to be used later on in the code
        Dictionary<string, int> dictDay = new Dictionary<string, int>()
            {
                {"one", 2},
                {"two", 5},
                {"three", 3},
                {"four", 8},
            };
        //Month dates are differentiated in the code with a capitalised first letter
        //the function of this dictionary is mostly identical to the one above
        Dictionary<string, int> dictMonth = new Dictionary<string, int>()
            {
                {"One", 1},
                {"Two", 8},
                {"Three", 3},
                {"Four", 8},
            };
        public Form1()
        {
            InitializeComponent();
            int count = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));

            //Setting the dates that will be bolded to the units specified in the dictionary above
            monthCalendar1.MaxSelectionCount = 1;
            DateTime SetDate1 = new (2022, dictMonth["Two"], dictDay["one"]);
            DateTime SetDate2 = DateTime.MinValue;
            
            //Setting the dates specified above to bold
            DateTime[] SetBoldDates = { SetDate1, SetDate2, };
            monthCalendar1.BoldedDates = SetBoldDates;
            monthCalendar1.FirstDayOfWeek = Day.Monday;

            //Caps the maximum values you can input
            numericUpDown1.Maximum = 31;
            numericUpDown2.Maximum = 12;
        }

        private void MonthCalendar1_Click(object sender, DateRangeEventArgs e)
        {
            //didnt mean to create this section but i don't want to delete it in case it messes up my code
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            //I clear all of the bolded dates by setting them to nothing and updating them
            DateTime[] SetBoldDates = Array.Empty<DateTime>();
            monthCalendar1.BoldedDates = SetBoldDates;
            monthCalendar1.UpdateBoldedDates();

        }

        private void BtnAddDate_Click(object sender, EventArgs e)
        {
            //adds "five" and assigns it to the currently selected value from both
            //numericalupdown1 and 2, then it sets it to bold and refreshes all of the dates
            dictDay["five"] = (int)numericUpDown1.Value;
            dictMonth["Five"] = (int)numericUpDown2.Value;
            DateTime SetDate1 = new(2022, dictMonth["Five"], dictDay["five"]);
            DateTime[] SetBoldDates = { SetDate1, };
            monthCalendar1.BoldedDates = SetBoldDates;
            monthCalendar1.UpdateBoldedDates();
        }
        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}