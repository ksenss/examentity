using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examentity.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }//null --not null
        public string Surname { get; set; }//null--not null
        public DateTime Birthdate { get; set; }
        public ICollection<Book> Books { get; set; }
        public Country Country { get; set; }
        public int Countryid { get; set; }
    }
}
