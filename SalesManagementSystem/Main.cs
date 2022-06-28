namespace SalesManagementSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncollapse_Click(object sender, EventArgs e)
        {
            if(pnlnavbar.Width==250)
            {
                pnlcollapse.Location=new Point(2,5);
                pnlnavbar.Width = 50;
                pnltitlenav.Visible = false;
                pnltitlenavbar.Height = 200;

            }
            else
            {
                {
                    pnlcollapse.Location = new Point(202, 5);
                    pnlnavbar.Width = 250;
                    pnltitlenav.Visible = true;
                    pnltitlenavbar.Height = 250;

                }
            }
        }

        //btn Close
        private void btnclose_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //btn maximize

        private void btnmaximize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;

            }
            else
            {
                WindowState = FormWindowState.Normal;

            }
        }

        //btn minimize
        private void btnminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }
    }
}