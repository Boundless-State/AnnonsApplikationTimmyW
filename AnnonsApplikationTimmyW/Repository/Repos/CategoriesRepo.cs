using AnnonsApplikationTimmyW.Repository.Entities;
using Microsoft.Data.SqlClient;

namespace AnnonsApplikationTimmyW.Repository.Repos
{
    public class CategoriesRepo
    {
        private readonly string _connString;
        public CategoriesRepo()
        {
            DataContext dataContext = new DataContext();
            _connString = dataContext.GetConnectionString();
        }
        public List<Categories> GetAllCategories()
        {
            List<Categories> categories = new List<Categories>();
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                conn.Open();
                string query = "SELECT CategoryID, CategoryName FROM dbo.Categories";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    categories.Add(new Categories(
                        (int)reader["CategoryID"],
                        reader["CategoryName"].ToString()
                    ));
                }
            }
            return categories;
        }
        public void AddCategory(string categoryName)
        {
            string sql = @"INSERT INTO Categories (CategoryName) VALUES (@CategoryName)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@CategoryName", categoryName)
            };
            DataContext.ExecuteNonQuery(sql, parameters);
        }
    }
}

