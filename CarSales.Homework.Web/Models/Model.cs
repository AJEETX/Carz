using System.ComponentModel.DataAnnotations;

namespace CarSales.Homework.Web.Models
{
    public partial class Car
    {
        public int CarID { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string PriceType { get; set; } //: { POA, DAP, EGC }

        public string EgcPrice { get; set; } //(only displayed if private the PriceType is EGC )

        public string DapPrice { get; set; }//(only displayed if private the PriceType is DAP )

        public string Email { get; set; }
        public string ContactName { get; set; } //(privately sold cars only)

        public string Phone { get; set; } // (privately sold cars only)
        public string DealerABN { get; set; }
        public string Comments { get; set; } //(dealer cars only)
        public enum dealer { TRUE, FALSE }
        public dealer Dealer { get; set; }

    }

    public partial class Feedback
    {
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        public string Message { get; set; }
    }
    public class CarViewModel
    {
        public Car Car { get; set; }
        public Feedback Feedback { get; set; }
    }
}