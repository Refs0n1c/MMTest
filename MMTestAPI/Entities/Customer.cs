using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace MMTestAPI.DataLayer.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        [MaxLength(20)]
        public string Title { get; set; }
        
        [MaxLength(50)]
        public string ForeName { get; set; }
        [MaxLength(50)]
        public string SurName { get; set; }

        [MaxLength(75)]
        public string EmailAddress { get; set; }
        
        [MaxLength(15)]
        public string MobileNo { get; set; }
           
        public IEnumerable<Address> Addresses { get; set; }
        
        
    }
}
