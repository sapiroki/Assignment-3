namespace Assignment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(weightTextBox.Text, out double weightInPounds) && double.TryParse(heightTextBox.Text, out double heightInInches))
            {
                double bmi = (weightInPounds / (heightInInches * heightInInches)) * 703;

                bmiLabel.Text = $"BMI: {bmi:F2}";
                bmiLabel.Visible = true;

                if (bmi < 18.5)
                {
                    statusLabel.Text = "Status: Underweight";
                    statusLabel.Visible = true;
                }
                else if (bmi >= 18.5 && bmi <= 25)
                {
                    statusLabel.Text = "Status: Normal weight";
                    statusLabel.Visible = true;
                }
                else
                {
                    statusLabel.Text = "Status: Overweight";
                    statusLabel.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid weight and height.");
            }
        }
    }
}