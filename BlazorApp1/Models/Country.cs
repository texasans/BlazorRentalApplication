﻿using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class Country
    {
        [Key]
        public int idCountry { get; set; }
        public string Name { get; set; }


        public virtual List<City> Cities { get; set; }

    }
}
