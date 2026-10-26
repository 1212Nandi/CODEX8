namespace CODEX8
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }


        private void btnGet_Started_Click(object sender, EventArgs e)
        {
            // Open the Registration page.
            frmRegistration RegistrationPage = new frmRegistration();
            RegistrationPage.Show();

            // Hide the Home page while Registration is open.
            this.Hide();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Open the Registration page.
            frmRegistration RegistrationPage = new frmRegistration();
            RegistrationPage.Show();

            // Hide the Home page while Registration is open.
            this.Hide();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // Open the Login page.
            frmLogin LoginPage = new frmLogin();
            LoginPage.Show();

            // Hide the Home page while Login Page is open.
            this.Hide();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            // Open the Contact page.
            frmContact ContactPage = new frmContact();
            ContactPage.Show();

            // Hide the Home page while Contact Page is open.
            this.Hide();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            // Open the About Us page.
            frmAbout AboutPage = new frmAbout();
            AboutPage.Show();

            // Hide the Home page while About Us page is open.
            this.Hide();
        }

        private void btnHow_Click(object sender, EventArgs e)
        {
            // Open the How it works page.
            frmHowItWorks HowItWorksPage = new frmHowItWorks();
            HowItWorksPage.Show();

            // Hide the Home page while How it works is open.
            this.Hide();
        }

    }   
}
