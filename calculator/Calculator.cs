using System.Data;

namespace calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        public void SetFieldValue(string text)
        {
            field.Text = text;
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            field.Text += button.Text;
            field.Refresh();
        }
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string operatorText = button.Text;

            field.AppendText(operatorText);
            field.Refresh();
        }
        private void btnResult_Click(object sender, EventArgs e)
        {
            MathCalculator m = new MathCalculator(field.Text, this);
        }
        private void backSpace_Click(object sender, EventArgs e)
        {
            string text = field.Text;

            if (!string.IsNullOrEmpty(text))
            {
                text = text.Substring(0, text.Length - 1);

                field.Text = text;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            field.Clear();
        }
    }
}