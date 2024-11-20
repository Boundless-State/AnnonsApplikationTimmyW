namespace AnnonsApplikationTimmyW.Repository.Entities
{
    public class Users
    {
        public int UserID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public string Passwords { get; set; }

        public Users(int userID, string fullName, string address, string city, string region, string postalCode, string country, string phoneNumber, string username, string passwords)
        {
            UserID = userID;
            FullName = fullName;
            Address = address;
            City = city;
            Region = region;
            PostalCode = postalCode;
            Country = country;
            PhoneNumber = phoneNumber;
            Username = username;
            Passwords = passwords;
        }
    }
}
