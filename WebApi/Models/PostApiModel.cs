﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class PostApiModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field must detected")]
        public string Title { get; set; }

        [Required(ErrorMessage = "This field must detected")]
        [StringLength(5000, MinimumLength = 3, ErrorMessage = "Lenth 3-5000 characters")]
        public string Text { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        public int AuthorId { get; set; }
        public virtual AuthorApiModel AuthorApiModel { get; set; }

    }
}