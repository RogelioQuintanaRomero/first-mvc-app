﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        [DisplayFormat(DataFormatString ="{0:yyy-MM-dd}",ApplyFormatInEditMode = true)]
        public DateTime ReleaseData { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}