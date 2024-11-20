using AnnonsApplikationTimmyW.Repository.Entities;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AnnonsApplikationTimmyW.Repository.Repos
{
    public class UserRepo
    {
        public List<Users> LoginUser(string username, string passwords)
        {
            string sql = "SELECT *" +
                        "FROM Users where Username = @Username AND Passwords = @Passwords";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Username", username));
            parameters.Add(new SqlParameter("@Passwords", passwords));
            DataTable data = DataContext.ExecuteQueryReturnTable(sql, parameters);

            List<Users> user = new();
            foreach (DataRow row in data.Rows)
            {
                user.Add(new Users((int)row.ItemArray[0], row.ItemArray[1].ToString(), row.ItemArray[2].ToString(), row.ItemArray[3].ToString(),
                                       row.ItemArray[4].ToString(), row.ItemArray[5].ToString(), row.ItemArray[6].ToString(), row.ItemArray[7].ToString(),
                                       row.ItemArray[8].ToString(), row.ItemArray[9].ToString()));
            }

            return user;
        }
        public void CreateUser(string fullName, string address, string city, string region, string postalCode, string country, string phoneNumber, string username, string passwords)
        {
            string sql = "insert into Users(FullName, Address, City, Region, PostalCode, Country, PhoneNumber, UserName, Passwords) " +
                         "values (@FullName, @Address, @City, @Region, @PostalCode, @Country, @PhoneNumber, @UserName, @Passwords)";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@FullName", fullName));
            parameters.Add(new SqlParameter("@Address", address));
            parameters.Add(new SqlParameter("@City", city));
            parameters.Add(new SqlParameter("@Region", region));
            parameters.Add(new SqlParameter("@PostalCode", postalCode));
            parameters.Add(new SqlParameter("@Country", country));
            parameters.Add(new SqlParameter("@PhoneNumber", phoneNumber));
            parameters.Add(new SqlParameter("@UserName", username));
            parameters.Add(new SqlParameter("@Passwords", passwords));

            DataContext.ExecuteNonQuery(sql, parameters);
        }
        public int GetUserID(string username)
        {
            int userID = 0;
            string sql = "SELECT UserID FROM Users WHERE Username = @Username";

            DataContext dataContext = new DataContext();
            string connString = dataContext.GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Username", username);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        userID = Convert.ToInt32(reader["UserID"]);
                    }
                }
            }
            if (userID == 0)
            {
                throw new Exception("Användaren hittades inte.");
            }
            return userID;
        }
        public string GetUsernameByID(int userID)
        {
            string username = string.Empty;
            string sql = @"SELECT Username FROM Users WHERE UserID = @UserID";

            DataContext dataContext = new DataContext();
            string connString = dataContext.GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@UserID", userID);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        username = reader["Username"].ToString();
                    }
                }
            }
            return username;
        }
    }
}