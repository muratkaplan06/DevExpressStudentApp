namespace StudentApp
{
    public partial class XtraHome : DevExpress.XtraEditors.XtraForm
    {
        public XtraHome()
        {
            InitializeComponent();
        }





        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
        }
    }
}