using System;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class FrmConfirm : Form
    {
        public FrmConfirm()
        {
            InitializeComponent();
        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text = StudentInfoClass.StudentNo.ToString();
            label9.Text = StudentInfoClass.Program;
            label10.Text = StudentInfoClass.LastName;
            label11.Text = StudentInfoClass.FirstName;
            label13.Text = StudentInfoClass.MiddleName;
            label12.Text = StudentInfoClass.Age.ToString();
            label14.Text = StudentInfoClass.ContactNo.ToString();
            label15.Text = StudentInfoClass.Address;
        }
    }
}
