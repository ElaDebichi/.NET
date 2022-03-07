using Microsoft.EntityFrameworkCore;

namespace ED.domain
{
    [Owned]
    public class Adress
    {
        public string City { get; set; }
        public string StreetAdress { get; set; }
        
    }
}