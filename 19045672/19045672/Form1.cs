using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19045672
{
    public partial class Form1 : Form
    {
        private Student _student1;
        private Student _student2;
        private Student _student3;
        private Student _student4;
        private Massey _massey;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            _massey = Massey.GetInstance("Massey");
            lblName.Text = _massey.PriPrintDetail();

            _student1 = new InternalStudent();
            _student2 = new InternalStudent2();
            _student3 = new DistanceStudent();
            _student4 = new DistanceStudent2();
            //lblStudent.Text = _student.StudentName();
            //lblStudent.Text = _student.Attendance();
            //lblStudent.Text = _student.StudentID().ToString();

            //lblStudent.Text = "11" + " John"_student.StudentID().ToString();


            DataGridViewRow dr = new DataGridViewRow();
            dr.CreateCells(dgvStudent);

            dgvStudent.Rows.Insert(0, _student1.StudentID().ToString(), _student1.StudentName(), _student1.Attendance(),
                _student1.Lab());
            dgvStudent.Rows.Insert(1, _student2.StudentID().ToString(), _student2.StudentName(), _student2.Attendance(),
                _student2.Lab());
            dgvStudent.Rows.Insert(2, _student3.StudentID().ToString(), _student3.StudentName(), _student3.Attendance(),
                _student3.Lab());
            dgvStudent.Rows.Insert(3, _student4.StudentID().ToString(), _student4.StudentName(), _student4.Attendance(),
                _student4.Lab());






        }
    }
}
