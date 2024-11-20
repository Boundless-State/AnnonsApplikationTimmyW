using AnnonsApplikationTimmyW.Repository.Entities;
using AnnonsApplikationTimmyW.Repository.Repos;

namespace AnnonsApplikationTimmyW.Views
{
    public partial class FormUserPages : Form
    {
        private int _loggedInUser;
        private int _hiddenAdvertID;

        public FormUserPages(int userID)
        {
            InitializeComponent();
            LoadCategories();
            this._loggedInUser = userID;
            LoadUserAdverts(_loggedInUser);
            ClearFields();

        }
        private void buttonSaveAdvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNewTitle.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrice.Text) ||
                string.IsNullOrWhiteSpace(richTextBoxAdvertDescription.Text) ||
                comboBoxCategory.SelectedItem == null)
            {
                labelStatus.Text = "Alla fält måste fyllas i.";
                return;
            }
            if (!decimal.TryParse(textBoxPrice.Text, out decimal unitPrice) || unitPrice <= 0)
            {
                labelStatus.Text = "Lägsta pris är 1 KR.";
                return;
            }
            try
            {
                Categories selectedCategory = (Categories)comboBoxCategory.SelectedItem;
                
                AdvertRepo repo = new AdvertRepo();
                repo.CreateAdvert(
                    textBoxNewTitle.Text.Trim(),
                    unitPrice,
                    richTextBoxAdvertDescription.Text.Trim(),
                    DateTime.Now,
                    _loggedInUser,
                    selectedCategory.CategoryID
                );
                LoadUserAdverts(_loggedInUser);
                ClearFields();
                labelStatus.Text = "Annonsen skapad!";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel uppstod: {ex.Message}");
            }
        }
        private void buttonDeleteAdvert_Click(object sender, EventArgs e)
        {
            Adverts selectedAdvert = (Adverts)listBoxUserAdverts.SelectedItem;
            if (selectedAdvert == null)
            {
                labelStatus.Text = "Välj en annons att ta bort";
            }
            else
            {
                buttonDeleteAdvert.Enabled = true;
                buttonSaveAdvert.Enabled = true;
                AdvertRepo repo = new();
                repo.DeleteAdvert(selectedAdvert.AdvertID, _loggedInUser);
                LoadUserAdverts(_loggedInUser);
                labelStatus.Text = ("Annonsen borttagen");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadUserAdverts(int userID)
        {
            AdvertRepo repo = new AdvertRepo();
            var userAdverts = repo.GetUserAdverts(_loggedInUser);

            listBoxUserAdverts.DisplayMember = "AdvertTitle";
            listBoxUserAdverts.ValueMember = "AdvertID";
            listBoxUserAdverts.DataSource = userAdverts;
        }
        private void listBoxUserAdverts_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDeleteAdvert.Enabled = listBoxUserAdverts.SelectedIndex != -1;
        }
        private void LoadCategories()
        {
            CategoriesRepo repo = new CategoriesRepo();
            var result = repo.GetAllCategories();
            comboBoxCategory.DisplayMember = "CategoryName";
            comboBoxCategory.ValueMember = "CategoryID";
            comboBoxCategory.DataSource = repo.GetAllCategories();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            string newCategory = textBoxNewCategory.Text.Trim();
            if (string.IsNullOrEmpty(newCategory))
            {
                labelStatus.Text = "Kategorinamn måste fyllas i.";
                return;
            }
            try
            {
                CategoriesRepo categoriesRepo = new CategoriesRepo();
                categoriesRepo.AddCategory(newCategory);
                labelStatus.Text = $"Kategorin '{newCategory}' sparades!";
                textBoxNewCategory.Clear();
                LoadCategories();
            }
            catch (Exception ex)
            {
                labelStatus.Text = $"Ett fel inträffade: {ex.Message}";
            }
        }

        private void buttonEditAdvert_Click(object sender, EventArgs e)
        {
            if (listBoxUserAdverts.SelectedItem != null)
            {
                var selectedAdvert = (Adverts)listBoxUserAdverts.SelectedItem;
                textBoxNewTitle.Text = selectedAdvert.AdvertTitle;
                textBoxPrice.Text = selectedAdvert.UnitPrice.ToString();
                comboBoxCategory.SelectedValue = selectedAdvert.Category.CategoryID;
                richTextBoxAdvertDescription.Text = selectedAdvert.AdvertDescription;
                buttonEditAdvert.Enabled = true;
                buttonSaveAdvert.Enabled = false;
                buttonDeleteAdvert.Enabled = false;
                buttonSaveEditAdvert.Enabled = true;
                _hiddenAdvertID = selectedAdvert.AdvertID;
            }
            else
            {
                labelStatus.Text = "Vänligen välj en annons att redigera.";
            }
        }

        private void buttonSaveEditAdvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewTitle.Text) ||
                string.IsNullOrEmpty(textBoxPrice.Text) ||
                comboBoxCategory.SelectedItem == null ||
                string.IsNullOrEmpty(richTextBoxAdvertDescription.Text))
            {
                
                labelStatus.Text = "Fyll i alla fält";
                return;
            }
            var advertRepo = new AdvertRepo();
            advertRepo.UpdateAdvert(
                _hiddenAdvertID,
                textBoxNewTitle.Text,
                decimal.Parse(textBoxPrice.Text),
                richTextBoxAdvertDescription.Text,
                (int)comboBoxCategory.SelectedValue
            );
                labelStatus.Text = "Annonsen har uppdaterats!";
                buttonSaveEditAdvert.Enabled = false;
                buttonSaveAdvert.Enabled = true;
                listBoxUserAdverts.ClearSelected();
                ClearFields();
                comboBoxCategory.SelectedIndex = -1;
                LoadUserAdverts(_loggedInUser);
        }
        private void ClearFields()
        {
            textBoxNewTitle.Clear();
            textBoxPrice.Clear();
            richTextBoxAdvertDescription.Clear();
        }
    }
}