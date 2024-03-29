﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExploreCalifornia.Models
{
    public class Post
    {
        public long Id { get; set; }
        private string _key;

        public string Key
        {
            get
            {
                if(_key == null)
                {
                    _key = Regex.Replace(Title.ToLower(), "[^a-z0-9]", "-");
                }
                return _key;
            }
            set
            {
                _key = value;
            }
        }

        [Required]
        [StringLength(100, ErrorMessage ="Title should be from 5 to 100 characters long", MinimumLength = 5)]
        [Display(Name ="Post title")]
        [DataType(DataType.Text)]
        public string Title { get; set; }
        public DateTime Posted { get; set; }

        public string Author { get; set; }

        [Required]
        [MinLength(100, ErrorMessage ="Blog post should be atleast 100 characters long")]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
    }
}
