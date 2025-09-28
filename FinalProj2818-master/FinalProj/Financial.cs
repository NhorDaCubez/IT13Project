
namespace FinalProj
{

    public partial class Financial : Form
    {
        public Financial()
        {
            InitializeComponent();
        }

        private void ExitBtn(object sender, EventArgs e)
        {
            Mainform Exit = new Mainform();
            Exit.Show();
            this.Hide();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GetDailyPerformance(object sender, PaintEventArgs e)
       {
        }

    }
}
