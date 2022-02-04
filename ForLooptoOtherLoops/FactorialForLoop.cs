using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLooptoOtherLoops
{
    public partial class FactorialForLoop : Form
    {
        public FactorialForLoop()
        {
            InitializeComponent();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            Factorial(5);
        }
        void Factorial(int number)
        {
            int result = 1;

            //for (int i = 1; i <= number; i++)
            //{
            //    result *= i;
            //}
            for (int i = number; i > 0; i--)
            {
                result *= i;
            }
            if (number == 0)
                result = 1;

            MessageBox.Show(result.ToString());
        }
    }
}
