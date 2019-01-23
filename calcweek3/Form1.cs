using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcweek3
{
    public partial class Form1 : Form
    {
        Single sngNum1, sngNum2, sngAnswer;

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            sngNum1 = Convert.ToSingle(txtNum1.Text);
            sngNum2 = Convert.ToSingle(txtNum2.Text);
            sngAnswer = sngNum1 * sngNum2; //Pass the answer to the label and the listbox 
            lblAnswer.Text = Convert.ToString(sngAnswer);
            lbxAnswer.Items.Add(sngNum1 + " X " + sngNum2 + " = " + sngAnswer);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            sngNum1 = Convert.ToSingle(txtNum1.Text);
            sngNum2 = Convert.ToSingle(txtNum2.Text);
            sngAnswer = sngNum1 / sngNum2; //Pass the answer to the label and the listbox 
            lblAnswer.Text = Convert.ToString(sngAnswer);
            lbxAnswer.Items.Add(sngNum1 + " / " + sngNum2 + " = " + sngAnswer);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            sngNum1 = Convert.ToSingle(txtNum1.Text);
            sngNum2 = Convert.ToSingle(txtNum2.Text);
            sngAnswer = sngNum1 - sngNum2; //Pass the answer to the label and the listbox 
            lblAnswer.Text = Convert.ToString(sngAnswer);
            lbxAnswer.Items.Add(sngNum1 + " - " + sngNum2 + " = " + sngAnswer);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
           sngNum1 = Convert.ToSingle(txtNum1.Text);
            sngNum2 = Convert.ToSingle(txtNum2.Text);
            sngAnswer = sngNum1 + sngNum2; //Pass the answer to the label and the listbox 
            lblAnswer.Text = Convert.ToString(sngAnswer);
            lbxAnswer.Items.Add(sngNum1 + " + " + sngNum2 + " = " + sngAnswer);
    
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
