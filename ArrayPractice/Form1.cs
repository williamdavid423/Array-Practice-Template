using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ArrayPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            // Create 2 arrays to hold 10 values each
            int[] numbers = new int[10];
            int[] numbers2 = new int[10];

            // variables that can be used to determine outcomes of questions
            int samePosition;
            int max;
            double average;
            double sum;

            Random randGen = new Random();

            //1. Generate random values for both pre-created arrays
            int temp = 0;
         

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = randGen.Next(1, 10);
                array1Output.Text += $"{numbers[i]}";
            }

            //2. Display array 1
            for (int i = 0; i < numbers2.Length; i++)
            {
                numbers2[i] = randGen.Next(1, 10);
                array2Output.Text += $"{numbers2[i]}";
            }

            //3. Display array 2


            //4. Display array 1 in reverse order
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                reverseOutput.Text += $"{numbers[i]}";
            }

            //5. Determine and display the largest value in array 1          
            temp = numbers.Max();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (i > temp)
            //    {
            //        temp = i;
            //    }
            //}
            maxOutput.Text = $"{temp}";

            //6.Determine and display the average of all values in array 1


            //7. Determine and display the sum of all even values in array 1


            //8. Determine and display the number of 3s in array 1


            //9. Determine and display how many matching numbers in matching positions between the 2 arrays there are


            // ----------------------
            // ##### ENRICHMENT #####
            // ----------------------


            //1. Determine and display at what index is the first 0 in array 1, (show "null" if no 0 exists)


            //2. swap and display all values between array1 and array2

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
