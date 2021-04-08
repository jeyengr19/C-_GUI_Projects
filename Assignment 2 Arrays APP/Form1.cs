using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2_Arrays_APP
{
    public partial class Form1 : Form
    {
        private const int MAX_SIZE = 5;
        private int[] firstArray = new int[MAX_SIZE];
        private int[] secondArray = new int[MAX_SIZE];
        private int[] thirdArray = new int[MAX_SIZE];
        private int i = 0;
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            // Tests whether both textboxes have values
            if (txtBxFstArr.Text == "" || txtBxSecArr.Text == "")
            {
                MessageBox.Show("Please Enter Values Into Both Arrays", "Warning!");
            }
            else
            {
                // Tests whether the entered values are numeric
                if (!double.TryParse(txtBxFstArr.Text, out _) || !double.TryParse(txtBxSecArr.Text, out _))
                {
                    txtBxFstArr.Clear();
                    txtBxSecArr.Clear();

                    txtBxFstArr.Focus();

                    MessageBox.Show("Please Enter Numeric Values for Both Arrays", "Warning!");
                }
                else
                {
                    // Adds the user input values to the arrays
                    if (count <= 4)
                    {
                        int numOne = Convert.ToInt32(txtBxFstArr.Text);
                        int numTwo = Convert.ToInt32(txtBxSecArr.Text);

                        firstArray[i] = numOne;
                        secondArray[i] = numTwo;

                        lstFrsArr.Items.Add(txtBxFstArr.Text);
                        lstSecArr.Items.Add(txtBxSecArr.Text);

                        ++count; 
                        i++;

                        txtBxFstArr.Clear();
                        txtBxSecArr.Clear();

                        int numMult = firstArray[i] * secondArray[i];
                        thirdArray[i] = numMult;
                    }
                    else
                    {
                        // Warns user that the array is full
                        MessageBox.Show("You have reached the 5 number Limit for the Arrays", "Warning!");
                        txtBxFstArr.Clear();
                        txtBxSecArr.Clear();
                    }
                    
                }
            }
        }

        private void btnDisp_Click(object sender, EventArgs e)
        {
            string firstArr = "";
            string secondArr = "";
            string thirdArr = "";
            for (i = 0; i <= 4; i++)
            {
                 firstArr = Convert.ToString(firstArray[i]);
                 secondArr = Convert.ToString(secondArray[i]);
                 thirdArr = Convert.ToString(thirdArray[i]);

            }
            MessageBox.Show("First Array Values: " + firstArr+ "/n" +)
        }
    }
}
