using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_FinalExam
{
    public partial class SplashForm : Form
    {
        //***** CONSTRUCTOR *****//
        public SplashForm()
        {
            InitializeComponent();
        }

        //***** EVENT HANDLERS *****//
        private void timer1_Tick(object sender, EventArgs e) // hides splash screen after 3 seconds
        {
            GenerateNameForm generateNameForm = new GenerateNameForm();
            this.Hide();
            generateNameForm.Show();
            timer1.Enabled = false;
        }
    }
}
