using System.Data;

namespace calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            field.Text += button.Text;
            field.Refresh();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {

        }
    }
}