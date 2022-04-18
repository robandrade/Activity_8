using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Create method for calculating the grams of fat into calories method
        private int FatCalories(int fat) 
        {
            return fat * 9;
        }

        // main method button that will then call the FatCalories method to recieve the data to print out calculation
        private void fatButton_Click_1(object sender, EventArgs e)
        {
            int fatGrams;
            int caloriesFat;

            if (int.TryParse(fatConsumed.Text, out fatGrams))
            {
                caloriesFat = FatCalories(fatGrams);
                fatCalories.Text = "Calories from grams of fat consumed: " + caloriesFat + "g";
            }
        }

        // Create method for calculating the grams of carbs into calories method 
        private int CarbCalories(int carbs)
        {
            return carbs * 4;
        }

        // main method button that will then call the CarbCalories method to recieve the data to print out calculation
        private void carbsButton_Click(object sender, EventArgs e)
        {
            int carbsGrams;
            int caloriesCarbs;

            if (int.TryParse(carbsConsumed.Text, out carbsGrams))
            {
                caloriesCarbs = CarbCalories(carbsGrams);
                carbsCalories.Text = "Calories from grams of carbohydrates consumed: " + caloriesCarbs + "g";
            }
        }
    }
}
