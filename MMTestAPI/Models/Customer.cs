using System;

namespace MMTestAPI.Models
{
public class Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DOB { get; set; }
    public int Age { get {return CalculateAge(DOB);} }
    
    
    




    
    private int CalculateAge(DateTime DOB)
    {
        int age = DateTime.Now.Year - DOB.Year;

        if (DOB > DateTime.Now.AddYears(-age)) 
            age--;

        return age;
    }
    
    
}

}