using lab1;
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

namespace lab1
{
    public partial class Form1 : Form
    {
        private Animal fish;
        private Wolf arcticWolf;

        public Form1()
        {
            InitializeComponent();
            fish = new Animal("риба", 2, 5, 20);
            arcticWolf = new Wolf("вовк", 40, 3, 15, "лісовий", "ліс");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayAnimalInfo(fish);
        }

        private void DisplayAnimalInfo(Animal animal)
        {
            textBox1.Text = animal.Name;
            textBox2.Text = animal.Weight.ToString();
            textBox3.Text = animal.Age.ToString();
            textBox4.Text = animal.DailyMaintenanceCost.ToString();

            if (animal is Wolf wolf)
            {
                textBox5.Text = wolf.Breed;
                textBox6.Text = wolf.NaturalLocation;
            }
            else
            {
                textBox5.Text = "";
                textBox6.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayAnimalInfo(arcticWolf);
        }


    }
}

