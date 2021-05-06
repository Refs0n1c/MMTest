using System.Collections.Generic;
using MMTestAPI.DataLayer.Entities;

namespace MMTestAPI.DataLayer.Helpers
{
    public static class Seeder
    {
        public static void SeedData(MMTestContext context)
        {
                var customer1 = new Customer
                {
                    Id = 1,
                    Title = "Dr",
                    ForeName = "Mantis",
                    SurName = "Toboggan",
                    EmailAddress = "mantis@gmail.com",
                    MobileNo = "078457774666",
                    Addresses = new List<Address>(){
                        new Address 
                        {
                            Id = 1,
                            AddressLine1 = "123 Fake Street",
                            AddressLine2 = "Shropshire",
                            County = "Lancs",
                            PostCode ="m44 777",
                            isPrimary = true,
                            Country = "Romania",
                            Town = "SomeTown" //i cant think of a SINGLE town.
                        },
                         new Address 
                        {
                            Id = 2,
                            AddressLine1 = "193 Definitley Real Street",
                            AddressLine2 = "Stretford",
                            PostCode ="m44 777",
                            isPrimary = false,
                            Town = "SomeTown" 
                            //  address will set country if none is supplied as per criteria
                        }
                    }
                    
                };

                var customer2 = new Customer
                {
                    Id = 1,
                    Title = "Mr",
                    ForeName = "Brian",
                    SurName = "Grumpston",
                    EmailAddress = "brian@gmail.com",
                    MobileNo = "078457774866",
                     Addresses = new List<Address>(){
                        new Address 
                        {
                            Id = 3,
                            AddressLine1 = "1 Grumble Street",
                            AddressLine2 = "Shropshire",
                            County = "County",
                            PostCode ="m44 777",
                            isPrimary = true,
                            Country = "Denmark",
                            Town = "SomeTown" //i cant think of a SINGLE town.
                        },
                         new Address 
                        {
                            Id = 4,
                            AddressLine1 = "13 Maybe Real Street",
                            AddressLine2 = "Stretford",
                            PostCode ="m48 777",
                            isPrimary = false,
                            Town = "SomeTown" 
                            //  address will set country if none is supplied as per criteria
                        }
                    }
                    
                };


                   var customer3 = new Customer
                {
                    Id = 1,
                    Title = "Mrs",
                    ForeName = "Jenny",
                    SurName = "Johson",
                    EmailAddress = "Jenny@gmail.com",
                    MobileNo = "078457774166",
                     Addresses = new List<Address>(){
                        new Address 
                        {
                            Id = 5,
                            AddressLine1 = "123 Fake Street",
                            AddressLine2 = "Shropshire",
                            County = "Lancs",
                            PostCode ="m44 777",
                            isPrimary = true,
                            Country = "Romania",
                            Town = "SomeTown" //i cant think of a SINGLE town.
                        },
                         new Address 
                        {
                            Id = 6,
                            AddressLine1 = "193 Definitley Real Street",
                            AddressLine2 = "Stretford",
                            PostCode ="m44 777",
                            isPrimary = false,
                            Town = "SomeTown" 
                            //  address will set country if none is supplied as per criteria
                        }
                    }
                    
                };

                var customers = new Customer[] {customer1,customer2,customer3};


                context.Customer.AddRange(customers);

                context.SaveChanges();

        }
    }
}