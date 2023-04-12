
namespace WinFormsLetter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DateTime dt = DateTime.Now;

            Datetb.Text = dt.ToString();


            
        }

        private void Sendertb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Datetb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private async void SendBtn_Click(object sender, EventArgs e)
        {
            DataBaseLetterInfo info = new DataBaseLetterInfo(Subjecttb.Text, Totb.Text, Sendertb.Text, Bodytb.Text);
            
            await Program.RunAsync(info);
        }
    }
}