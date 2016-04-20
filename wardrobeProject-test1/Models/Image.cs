using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace wardrobeProject_test1.Models
{
    public class Image
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Type { get; set; }

        public string AltText { get; set; }

        [DataType(DataType.Html)]
        public string Caption { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }

        

    }
}