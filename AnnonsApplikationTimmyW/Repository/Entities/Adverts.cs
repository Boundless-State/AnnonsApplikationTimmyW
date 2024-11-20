using Microsoft.VisualBasic.ApplicationServices;

namespace AnnonsApplikationTimmyW.Repository.Entities
{
    public class Adverts
    {
        public int AdvertID { get; set; }
        public string AdvertTitle { get; set; }
        public string AdvertDescription { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime AdvertDate { get; set; }
        public Users User { get; set; }
        public Categories Category { get; set; }

        public Adverts(int advertID, string advertTitle, string advertDescription, decimal unitPrice, DateTime advertDate, Users userID, Categories categoryID)
        {
            AdvertID = advertID;
            AdvertTitle = advertTitle;
            AdvertDescription = advertDescription;
            UnitPrice = unitPrice;
            AdvertDate = advertDate;
            User = userID;
            Category = categoryID;
        }
    }
}