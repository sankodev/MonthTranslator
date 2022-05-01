using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IC8_KS_MonthTranslator
{
    public partial class MonthTranslatorForm : Form
    {
        public MonthTranslatorForm()
        {
            InitializeComponent();
        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            //prep
            string month = monthTextBox.Text;
            
            //if the radiobuttons are both unchecked
            if (swedishRadioButton.Checked == false && deutschRadioButton.Checked == false)
            {
                translateLabel.Text = "Select Language";
                translateLabel.ForeColor = Color.Red;
                return;
            }
            //big if stat
            if (month == "January")
            {
                if (swedishRadioButton.Checked)
                {
                    translateLabel.Text = "Januari";
                }
                else
                {
                    translateLabel.Text = "Januar";
                }
            }
            if (month == "Febraury")
            {
                if (swedishRadioButton.Checked)
                {
                    translateLabel.Text = "Februari";
                }
                else
                {
                    translateLabel.Text = "Februar"; 
                }
            }
            if (month == "March")
            {
                
            }
        }
    }
}
