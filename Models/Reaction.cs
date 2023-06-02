using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Reaction
    {
        [Key]
        public int Id {get; set;}
        [Required]
        public string Value {get; set;}
        public string Comment {get; set;}
        public int BlogId {get; set;}
        public BlogModel Blog {get; set;}
        public string reactor {get; set;}
        [ForeignKey("UserName")]
        public ApplicationUser User {get; set;}
        public int song {get; set;}
        public string number {get; set;}
    }
}