namespace Quiz01_IO_Variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void q2SExampleButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Go Jays!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("6");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("To output two decimal places use F2");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("4 items at 2.25 each with tax will be $10.17");
        }

        private void q01Button_Click(object sender, EventArgs e)
        {
            q1OutputLabel.Text = "Go Bears!"; //Displays the text
        }

        private void q02Button_Click(object sender, EventArgs e)
        {
            q2OutputLabel.Text = "Go " + q2TextBox.Text + "!"; //Displays GO and whatever the user put in the textbox
        }

        private void q03Button_Click(object sender, EventArgs e)
        {
            try
            {
                //Converts the inputs into Integers
                int num1 = Convert.ToInt16(num1Box.Text);
                int num2 = Convert.ToInt16(num2Box.Text);

                //Multiplies the integers together and converts it to a string
                q3OutputLabel.Text = (num1 * num2).ToString();
            }
            catch
            {
                //These outputs if the user doesn't put a valid input in
                q3OutputLabel.Text = "Invalid Input";

            }
        }

        private void q04Button_Click(object sender, EventArgs e)
        {
            try
            {

                double numOfItems = Convert.ToInt16(noItemsBox.Text);
                double costOfItems = Convert.ToInt16(costBox.Text);
                
                double beforePrice = numOfItems * costOfItems;
                double tax = beforePrice * 0.13;
                double afterTax = beforePrice + tax;


                q4OutputLabel.Text = numOfItems + " items at " + costOfItems + " each would cost " + beforePrice + " before tax and " + afterTax + " after tax!";
            }
            catch
            {
                q4OutputLabel.Text = "Invalid Input";
            }
        }
    }
}
