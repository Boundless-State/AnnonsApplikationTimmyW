using AnnonsApplikationTimmyW.Repository.Repos;

namespace AnnonsApplikationTimmyW.Views
{
    public partial class FormRegisterNewUser : Form
    {
        public FormRegisterNewUser()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSaveNewUser_Click(object sender, EventArgs e)
        {
            string fullName = textBoxFullName.Text;
            string address = textBoxStreetAdress.Text;
            string city = textBoxCity.Text;
            string region = textBoxRegion.Text;
            string postalCode = textBoxPostalCode.Text;
            string country = textBoxCountry.Text;
            string phoneNumber = textBoxMobilePhone.Text;
            string username = textBoxNewUsername.Text;
            string passwords = textBoxNewPassword.Text;

            UserRepo userRepo = new UserRepo();
            string savedUser = fullName + address + city + region + postalCode + country + phoneNumber + username + passwords;
            if (textBoxFullName.Text == "" || textBoxStreetAdress.Text == "" || textBoxCity.Text == "" || textBoxRegion.Text == "" || textBoxPostalCode.Text == "" || textBoxCountry.Text == "" || textBoxMobilePhone.Text == "" || textBoxNewUsername.Text == "" || textBoxNewPassword.Text == "")
            {
                labelStatus.Text = ("Fyll i samtliga fält.");
            }
            else
            {
                UserRepo repo = new UserRepo();
                repo.CreateUser(fullName, address, city, region, postalCode, country, phoneNumber, username, passwords);
                labelStatus.Text = ("Kontot har skapats!");
            }
        }
    }
}
