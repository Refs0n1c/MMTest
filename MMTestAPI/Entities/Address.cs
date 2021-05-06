using System.ComponentModel.DataAnnotations;
namespace MMTestAPI.DataLayer.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string AddressLine1 { get; set; }
        
        public string AddressLine2 { get; set; }

        public string Town { get; set; }
        
        public string PostCode { get; set; }

        public string County { get; set; }

        public string Country { get; set; } = "UK";

        public bool isPrimary { get; set; }
        
        
        
        
        
        
        
        
        
        
    }



}