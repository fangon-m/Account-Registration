using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Account_Registration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                StudentInfoClass.StudentNo = long.Parse(txtStudentNo.Text);
                StudentInfoClass.Program = txtProgram.Text;
                StudentInfoClass.LastName = txtLastName.Text;
                StudentInfoClass.FirstName = txtFirstName.Text;
                StudentInfoClass.MiddleName = txtMiddleName.Text;
                StudentInfoClass.Age = long.Parse(txtAge.Text);
                StudentInfoClass.ContactNo = long.Parse(txtContactNo.Text);
                StudentInfoClass.Address = txtAddress.Text;

                FrmConfirm confirmForm = new FrmConfirm();
                confirmForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            MessageBox.Show(
    $"StudentNo: {txtStudentNo.Text}\n" +
    $"Program: {txtProgram.Text}\n" +
    $"LastName: {txtLastName.Text}\n" +
    $"FirstName: {txtFirstName.Text}\n" +
    $"MiddleName: {txtMiddleName.Text}\n" +
    $"Age: {txtAge.Text}\n" +
    $"ContactNo: {txtContactNo.Text}\n" +
    $"Address: {txtAddress.Text}"
);
        }

    }
}
