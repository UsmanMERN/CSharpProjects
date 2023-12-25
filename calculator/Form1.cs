namespace calculator
{
    public partial class Form1 : Form
    {
        private string currentInput = "";
        private double currentResult = 0;
        private char currentOperator = ' ';
        private bool isOperatorClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void appendToTextBox(string value)
        {
            // Append the input value to the text box
            textBox1.Text += value;
        }

        private void getValue(object sender, EventArgs e)
        {
            // Handle number buttons (0-9)
            Button button = (Button)sender;
            appendToTextBox(button.Text);
        }

        private void getOperator(object sender, EventArgs e)
        {
            // Handle operator buttons (+, -, *, /)
            Button button = (Button)sender;

            if (!isOperatorClicked)
            {
                // If an operator is not already clicked, store the current input as the first operand
                currentResult = double.Parse(textBox1.Text);
                currentOperator = button.Text[0];
                textBox1.Text = "";
                isOperatorClicked = true;
            }
            else
            {
                // If an operator is already clicked, perform the previous operation
                double secondOperand = double.Parse(textBox1.Text);
                switch (currentOperator)
                {
                    case '+':
                        currentResult += secondOperand;
                        break;
                    case '-':
                        currentResult -= secondOperand;
                        break;
                    case '*':
                        currentResult *= secondOperand;
                        break;
                    case '/':
                        if (secondOperand != 0)
                            currentResult /= secondOperand;
                        else
                            MessageBox.Show("Cannot divide by zero");
                        break;
                }
                textBox1.Text = currentResult.ToString();
                currentOperator = button.Text[0];
            }
        }

        private void getEqualTo(object sender, EventArgs e)
        {
            // Handle equal button (=)
            double secondOperand = double.Parse(textBox1.Text);

            if (currentOperator != ' ')
            {
                switch (currentOperator)
                {
                    case '+':
                        currentResult += secondOperand;
                        break;
                    case '-':
                        currentResult -= secondOperand;
                        break;
                    case '*':
                        currentResult *= secondOperand;
                        break;
                    case '/':
                        if (secondOperand != 0)
                            currentResult /= secondOperand;
                        else
                            MessageBox.Show("Cannot divide by zero");
                        break;
                }
            }

            textBox1.Text = currentResult.ToString();
            currentOperator = ' ';
            isOperatorClicked = false;
        }
    }
}