using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRental.Models
{
    public class PhysicalStore
    {
        [Key]
        public int Id { get; set; }
        public string logoURL { get; set; }
        public string name { get; set; }
        public string Address { get; set; }

        //Relationships
        public  List<Movie> Movies { get; set; }
    }
}
