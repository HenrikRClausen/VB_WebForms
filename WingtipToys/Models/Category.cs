﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WingtipToys.Models {
    public class Category {
        [ScaffoldColumn(false)]
        public int  CategoryID { get; set; }

        [Required, StringLength(100), Display(Name = "Navn")]
        public string CategoryName { get; set; }

        [Display(Name = "Produktbeskrivelse")]
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        }
    }