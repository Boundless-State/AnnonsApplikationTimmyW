using AnnonsApplikationTimmyW.Repository.Entities;
using Microsoft.Data.SqlClient;
using System.Data;
using Users = AnnonsApplikationTimmyW.Repository.Entities.Users;

namespace AnnonsApplikationTimmyW.Repository.Repos
{
    public class AdvertRepo
    {
        public List<Adverts> GetAllAdverts()
        {
            string sql = @"SELECT Adverts.AdvertID, Adverts.UserID, FullName, Address, City, Region, PostalCode, Country, 
                          PhoneNumber, Username, Passwords, Adverts.CategoryID, CategoryName, AdvertTitle, 
                          AdvertDescription, UnitPrice, AdvertDate
                            FROM Adverts 
                            INNER JOIN Users ON Adverts.UserID = Users.UserID 
                            INNER JOIN Categories ON Adverts.CategoryID = Categories.CategoryID;";
            DataTable data = DataContext.ExecuteQueryReturnTable(sql, new List<SqlParameter>());
            List<Adverts> adverts = new List<Adverts>();
            foreach (DataRow row in data.Rows)
            {
                var user = new Users
                (
                    (int)row["UserID"],
                    row["FullName"].ToString(),
                    row["Address"].ToString(),
                    row["City"].ToString(),
                    row["Region"].ToString(),
                    row["PostalCode"].ToString(),
                    row["Country"].ToString(),
                    row["PhoneNumber"].ToString(),
                    row["Username"].ToString(),
                    row["Passwords"].ToString()
                );
                var category = new Categories
                (
                    (int)row["CategoryID"],
                    row["CategoryName"].ToString()
                );
                var advert = new Adverts
                (
                    (int)row["AdvertID"],
                    row["AdvertTitle"].ToString(),
                    row["AdvertDescription"].ToString(),
                    (decimal)row["UnitPrice"],
                    (DateTime)row["AdvertDate"],
                    user,
                    category
                );
                adverts.Add(advert);
            }
            return adverts;
        }

        public List<Adverts> GetUserAdverts(int userID)
        {
            string sql = @"SELECT Adverts.AdvertID, AdvertTitle, AdvertDescription, UnitPrice, AdvertDate,
                          Users.UserID, FullName, Address, City, Region, PostalCode, Country, 
                          PhoneNumber, Username, Passwords,
                          Categories.CategoryID, CategoryName
                            FROM Adverts
                            INNER JOIN Users ON Adverts.UserID = Users.UserID
                            INNER JOIN Categories ON Adverts.CategoryID = Categories.CategoryID
                            WHERE Adverts.UserID = @UserID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@UserID", userID)
            };
            DataTable data = DataContext.ExecuteQueryReturnTable(sql, parameters);
            List<Adverts> adverts = new List<Adverts>();
            foreach (DataRow row in data.Rows)
            {
                Users user = new Users(
                    (int)row["UserID"],
                    row["FullName"].ToString(),
                    row["Address"].ToString(),
                    row["City"].ToString(),
                    row["Region"].ToString(),
                    row["PostalCode"].ToString(),
                    row["Country"].ToString(),
                    row["PhoneNumber"].ToString(),
                    row["Username"].ToString(),
                    row["Passwords"].ToString()
                );
                Categories category = new Categories(
                    (int)row["CategoryID"],
                    row["CategoryName"].ToString()
                );
                adverts.Add(new Adverts(
                    (int)row["AdvertID"],
                    row["AdvertTitle"].ToString(),
                    row["AdvertDescription"].ToString(),
                    (decimal)row["UnitPrice"],
                    (DateTime)row["AdvertDate"],
                    user,
                    category
                ));
            }

            return adverts;
        }

        public void CreateAdvert(string advertTitle, decimal unitPrice, string advertDescription, DateTime advertDate, int userID, int categoryID)
        {
            string sql = @"INSERT INTO Adverts (AdvertTitle, UnitPrice, AdvertDescription, AdvertDate, UserID, CategoryID)
                            VALUES (@AdvertTitle, @UnitPrice, @AdvertDescription, @AdvertDate, @UserID, @CategoryID)";
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@AdvertTitle", advertTitle),
                new SqlParameter("@UnitPrice", unitPrice),
                new SqlParameter("@AdvertDescription", advertDescription),
                new SqlParameter("@AdvertDate", advertDate),
                new SqlParameter("@UserID", userID),
                new SqlParameter("@CategoryID", categoryID)
            };
            DataContext.ExecuteNonQuery(sql, parameters);
        }

        public void UpdateAdvert(int advertID, string advertTitle, decimal unitPrice, string advertDescription, int categoryID)
        {
            string sql = @"UPDATE Adverts 
                           SET AdvertTitle = @AdvertTitle, UnitPrice = @UnitPrice, 
                                AdvertDescription = @AdvertDescription, CategoryID = @CategoryID
                           WHERE AdvertID = @AdvertID";
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@AdvertID", advertID),
                new SqlParameter("@AdvertTitle", advertTitle),
                new SqlParameter("@UnitPrice", unitPrice),
                new SqlParameter("@AdvertDescription", advertDescription),
                new SqlParameter("@CategoryID", categoryID)
            };
            DataContext.ExecuteNonQuery(sql, parameters);
        }

        public void DeleteAdvert(int advertID, int userID)
        {
            string sql = @"DELETE FROM Adverts 
                            WHERE AdvertID = @AdvertID AND UserID = @UserID";
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@AdvertID", advertID),
                new SqlParameter("@UserID", userID)
            };
            DataContext.ExecuteNonQuery(sql, parameters);
        }

        public List<Adverts> SearchAdverts(string searchCondition, string categoryName, string sort)
        {
            string sql = @"SELECT Adverts.AdvertID, AdvertTitle, AdvertDescription, UnitPrice, AdvertDate,
                          Users.UserID, FullName, Address, City, Region, PostalCode, Country, 
                          PhoneNumber, Username, Passwords,
                          Categories.CategoryID, CategoryName
                            FROM Adverts
                            INNER JOIN Users ON Adverts.UserID = Users.UserID
                            INNER JOIN Categories ON Adverts.CategoryID = Categories.CategoryID";
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (!string.IsNullOrEmpty(searchCondition))
            {
                sql += " AND AdvertTitle LIKE @AdvertTitle";
                parameters.Add(new SqlParameter("@AdvertTitle", "%" + searchCondition + "%"));
            }
            if (!string.IsNullOrEmpty(categoryName))
            {
                sql += " AND CategoryName = @CategoryName";
                parameters.Add(new SqlParameter("@CategoryName", categoryName));
            }
            switch (sort)
            {
                case "Lägst Pris Först":
                    sql += " ORDER BY UnitPrice ASC";
                    break;
                case "Högst Pris Först":
                    sql += " ORDER BY UnitPrice DESC";
                    break;
                case "Nyast Först":
                    sql += " ORDER BY AdvertDate DESC";
                    break;
                case "Äldst Först":
                    sql += " ORDER BY AdvertDate ASC";
                    break;
                default:
                    sql += " ORDER BY AdvertTitle ASC";
                    break;
            }
            DataTable data = DataContext.ExecuteQueryReturnTable(sql, parameters);
            List<Adverts> adverts = new List<Adverts>();

            foreach (DataRow row in data.Rows)
            {
                Users user = new Users(
                    (int)row["UserID"],
                    row["FullName"].ToString(),
                    row["Address"].ToString(),
                    row["City"].ToString(),
                    row["Region"].ToString(),
                    row["PostalCode"].ToString(),
                    row["Country"].ToString(),
                    row["PhoneNumber"].ToString(),
                    row["Username"].ToString(),
                    row["Passwords"].ToString()
                );
                Categories category = new Categories(
                    (int)row["CategoryID"],
                    row["CategoryName"].ToString()
                );
                adverts.Add(new Adverts(
                    (int)row["AdvertID"],
                    row["AdvertTitle"].ToString(),
                    row["AdvertDescription"].ToString(),
                    (decimal)row["UnitPrice"],
                    (DateTime)row["AdvertDate"],
                    user,
                    category
                ));
            }
            return adverts;
        }
    }
}