﻿// bu class database bağlantısı yapabilmek için buraya konuldu

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;  // key 
namespace WebApplication1.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]  
        public string? Name { get; set; }

        [DisplayName("Display Order")]
        //[Range(1,100,ErrorMessage ="display order must be between 1 to 100")]
        public int DisplayOrder { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}
