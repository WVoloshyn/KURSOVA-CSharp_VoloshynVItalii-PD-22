using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kulck_IMT_Voloshyn_Vitalii_Kursova_Pd_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double height, weight;
            height = Convert.ToDouble(heightInput.Text);
            weight = Convert.ToDouble(weightInput.Text);

            switch (sexChoice.Text)
            {
                case "Male":
                    resultOutput.Text = Convert.ToString(weight / (height/100 * height/100));
                    this.malePicture.Visible = true;
                    malePicture.Refresh();
                    break;

                case "Female":
                    resultOutput.Text = Convert.ToString(weight / (height/100 * height/100));
                    this.femalePicture.Visible = true;
                    femalePicture.Refresh();
                    break;
            }
           
        }  
      
        private void button2_Click(object sender, EventArgs e)
        {
            heightInput.Text = "";

            weightInput.Text = "";

            resultOutput.Text = "";

            sexChoice.Text = "";

            this.femalePicture.Visible = false;
            femalePicture.Refresh();

            this.malePicture.Visible = false;
            malePicture.Refresh();
        }

        private void malePicture_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
