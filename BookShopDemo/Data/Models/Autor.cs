﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookShopDemo.Data.Models
{
    public class Author
    {

        public Author()
        {
            this.AuthorsBooks = new HashSet<AuthorBook>();
        }

        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [MinLength(3)]

        public string FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        [MinLength(3)]

        public string LastName { get; set; }
        [Required]

        public string Phone { get; set; }
        [Required]

        public string Email { get; set; }

        public ICollection<AuthorBook> AuthorsBooks { get; set; }
    }
}