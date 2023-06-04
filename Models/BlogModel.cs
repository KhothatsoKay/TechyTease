using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class BlogModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Enter Title")]
        [Required(ErrorMessage = "{0} is Required")]
        public string Title { get; set; }
        [Display(Name = "Write Content")]
        public string Content { get; set; }
        public DateTime Created { get; set; }
        [Display(Name = "Upload Image")]
        public string ImagePath  { get; set; }
        public string AuthorName { get; set; }
        public byte[] AuthorProfilePicture { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<Reaction> Reactions { get; set; }

    }


}
