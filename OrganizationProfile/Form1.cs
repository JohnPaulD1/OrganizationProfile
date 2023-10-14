using System.Text.RegularExpressions;

namespace OrganizationProfile
{


    public partial class frmRegistration : Form
    {


        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;

        
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]
            {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };
            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }

            string[] ListOfGender = new string[]
            {
                "Male",
                "Female"
            };
            for (int i = 0; i < 2; i++)
            {
                cbGender.Items.Add(ListOfGender[i].ToString());
            }
        }
         

        private void btnRegister_Click(object sender, EventArgs e)
        {
            StudentInformationClass.SetFullName = FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);
            StudentInformationClass.SetStudentNo = StudentNumber(txtStudentNo.Text);
            StudentInformationClass.SetProgram = cbPrograms.Text;
            StudentInformationClass.SetGender = cbGender.Text;
            StudentInformationClass.SetContactNo = ContactNo(txtContactNo.Text);
            StudentInformationClass.SetAge = Age(txtAge.Text);
            StudentInformationClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");

            frmConfirmation frm = new frmConfirmation();
            frm.ShowDialog();
        }

        public long StudentNumber(string studNum)
        {
            try
            {
                if (string.IsNullOrEmpty(studNum))
                {
                    throw new ArgumentNullException("Fill up 'Student Number' ");
                }
                else
                {
                    _StudentNo = long.Parse(studNum);
                }
            }
            catch (ArgumentNullException ae)
            {
                MessageBox.Show(ae.Message);
                txtStudentNo.Text = (" '02000XXXXXX' ");
            }
            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            try
            {
                if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
                {
                    _ContactNo = long.Parse(Contact);
                }
                else
                {
                    throw new IndexOutOfRangeException("Exceeded 'Contact Number' ");
                }
            }
            catch (IndexOutOfRangeException ie)
            {
                MessageBox.Show(ie.Message);
                txtContactNo.Text = " ";
            }
            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            try
            {
                if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
                {
                    _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
                }
                else
                {
                    throw new FormatException("Invalid Format 'Name' ");
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
            return _FullName;
        }

        public int Age(string age)
        {
            try
            {
                if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
                {
                    _Age = Int32.Parse(age);
                }
                else
                {
                    throw new OverflowException("Try Again! 'Age' ");
                }
            }
            catch (OverflowException oe)
            {
                MessageBox.Show(oe.Message);
                txtAge.Text = " ";
            }
            return _Age;
        }
    }
}