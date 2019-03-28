using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void result_Click(object sender, EventArgs e)
        {
            int points = 0;


            if (points >= 9)
            {
                labelResult.Text = "Итоговая оценка: 5";
            }
            if(points >= 7)
            {
                labelResult.Text = "Итоговая оценка: 4";
            }
            if(points >= 5)
            {
                labelResult.Text = "Итоговая оценка: 3";
            }
            if(points < 5)
            {
                labelResult.Text = "Итоговая оценка: 2";
            }

        }
    }
}
