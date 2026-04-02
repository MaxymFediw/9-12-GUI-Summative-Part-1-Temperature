using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_12_GUI_Summative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void imgBox_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            string celsius, farenheit; //spelt "fahrenheit" differently so the code wouldn't spaz
            int celcius, fahrenheit;

            celsius = txtCelsius.Text;
            farenheit = txtFahrenheit.Text;

            Int32.TryParse(txtCelsius.Text, out celcius);
            Int32.TryParse(txtFahrenheit.Text, out  fahrenheit);

            imgBox.Visible = true;
            

            if (radC.Checked && celcius < 0 || radF.Checked && fahrenheit < 32)
            {
                
                imgBox.Image = Properties.Resources.sub0;
            }

            

            else if (celcius >= 0 && celcius < 25 || fahrenheit >= 32 && fahrenheit < 77)
            {
                
                imgBox.Image = Properties.Resources.zeroTo25;
            }

            

            else if (celcius >= 25 && celcius < 40 || fahrenheit >= 32 && fahrenheit < 104)
            {
                
                imgBox.Image = Properties.Resources.twentyFiveTo40;
            }

            

            else if (celcius >= 40 && celcius < 100 || fahrenheit >= 104 && fahrenheit < 212)
            {
                
                imgBox.Image = Properties.Resources.fortyTo100;
            }

           

            else if (celcius <= 100 || fahrenheit <= 212)
            {
                
                imgBox.Image = Properties.Resources.over100;
            }

            
        }
    }
}
