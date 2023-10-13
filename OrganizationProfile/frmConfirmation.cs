using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizationProfile
{
    public partial class frmConfirmation : Form
    {
        StudentInformationClass studentInformationClass = new StudentInformationClass();

        public frmConfirmation()
        {
            InitializeComponent();
        }

        private void frmConfirmation_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            studentInformationClass.SetFullName = FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);
            studentInformationClass.SetStudentNo = StudentNumber(txtStudentNo.Text);
            studentInformationClass.SetProgram = cbPrograms.Text;
            studentInformationClass.SetGender = cbGender.Text;
            studentInformationClass.SetContactNo = ContactNo(txtContactNo.Text);
            studentInformationClass.SetAge = Age(txtAge.Text);
            studentInformationClass.SetBirthday = datePickerBirthday.Value.ToString("yyyyMM-dd");

            frmConfirmation frm = new frmConfirmation();
            frm.ShowDialog();



        }
    }
}
