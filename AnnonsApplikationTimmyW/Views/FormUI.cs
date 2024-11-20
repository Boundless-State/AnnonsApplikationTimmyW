using AnnonsApplikationTimmyW.Repository.Entities;
using AnnonsApplikationTimmyW.Repository.Repos;
using AnnonsApplikationTimmyW.Views;

namespace AnnonsApplikationTimmyW
{
    public partial class FormUI : Form
    {
        public FormUI()
        {
            InitializeComponent();
            SortListBox();
            DisplayAdverts();
            LoadSortOptions();
            LoadCategories();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            UserRepo repo = new UserRepo();
            List<Users> users = repo.LoginUser(username, password);
            if (users.Count == 1)
            {
                labelLoginStatus.Text = "Inloggning lyckades!";
                int userID = repo.GetUserID(username);
                FormUserPages userPagesForm = new FormUserPages(userID);
                userPagesForm.Show();
                textBoxUsername.Clear();
                textBoxPassword.Clear();
            }
            else
            {
                labelLoginStatus.Text = "Felaktigt användarnamn eller lösenord.";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxResult.SelectedItem != null)
            {
                var selectedAdvert = (Adverts)listBoxResult.SelectedItem;
                richTextBoxAdvertDescription.Text = selectedAdvert.AdvertDescription;
                textBoxPrice.Text = selectedAdvert.UnitPrice.ToString("C");
                textBoxAdvertDateAdded.Text = selectedAdvert.AdvertDate.ToString("dd-MM-yyyy");

                UserRepo userRepo = new UserRepo();
                int userID = selectedAdvert.User.UserID;
                string username = userRepo.GetUsernameByID(userID);
                textBoxSeller.Text = username;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            AdvertRepo repo = new AdvertRepo();
            listBoxResult.DisplayMember = "Titel";
            listBoxResult.ValueMember = "AdvertID";
            listBoxResult.DataSource = repo.SearchAdverts(textBoxSearch.Text, comboBoxCategory.Text, comboBoxSort.Text);
        }
        private void DisplayAdverts()
        {
            AdvertRepo advertRepo = new AdvertRepo();
            var advertResult = advertRepo.GetAllAdverts();
            listBoxResult.DisplayMember = "AdvertTitle";
            listBoxResult.DataSource = advertResult;
        }

        private void linkLabelCreateNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegisterNewUser form = new FormRegisterNewUser();
            form.ShowDialog();
        }

        private void SortListBox()
        {
            if (listBoxResult.DataSource == null) return;

            var adverts = (List<Adverts>)listBoxResult.DataSource;
            string sortOption = comboBoxSort.SelectedItem?.ToString() ?? "Nyast Först";

            switch (sortOption)
            {
                case "Lägst Pris Först":
                    adverts = adverts.OrderBy(a => a.UnitPrice).ToList();
                    break;

                case "Högst Pris Först":
                    adverts = adverts.OrderByDescending(a => a.UnitPrice).ToList();
                    break;

                case "Nyast Först":
                    adverts = adverts.OrderBy(a => a.AdvertDate).ToList();
                    break;

                case "Äldst Först":
                    adverts = adverts.OrderByDescending(a => a.AdvertDate).ToList();
                    break;
            }
            listBoxResult.DataSource = adverts;
        }
        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortListBox();
        }
        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedItem != null)
            {
                Categories selectedCategory = (Categories)comboBoxCategory.SelectedItem;
                int categoryID = selectedCategory.CategoryID;
            }
        }
        private void LoadCategories()
        {
            CategoriesRepo categoriesRepo = new CategoriesRepo();
            List<Categories> categories = categoriesRepo.GetAllCategories();
            comboBoxCategory.DataSource = categories;
            comboBoxCategory.DisplayMember = "CategoryName";
            comboBoxCategory.ValueMember = "CategoryID";
        }
        private void LoadSortOptions()
        {
            comboBoxSort.Items.Clear();
            comboBoxSort.Items.Add("Nyast Först");
            comboBoxSort.Items.Add("Äldst Först");
            comboBoxSort.Items.Add("Lägst Pris Först");
            comboBoxSort.Items.Add("Högst Pris Först");
            comboBoxSort.SelectedIndex = 0;
        }
    }
}