using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Razor_2_1.Model
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
