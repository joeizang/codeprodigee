using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CodeProdigee.Api.Abstractions;

namespace CodeProdigee.Api.DomainModels
{
    public class Author : BaseDomainModel
    {
        [StringLength(150)]
        [Required]
        public string AuthorName { get; set; }

        [StringLength(50)]
        [Required]
        public string Firstname { get; set; }

        [StringLength(50)]
        [Required]
        public string Lastname { get; set; }

        [StringLength(50)]
        public string Othernames { get; set; }

        [StringLength(50)]
        [Required]
        public string Email { get; set; }

        [StringLength(150)]
        [Required]
        public string Avatar { get; set; }

        [StringLength(200)]
        [Required]
        public string Picture { get; set; }

        [StringLength(50)]
        public string TwitterHandle { get; set; }

        [StringLength(50)]
        [Required]
        public string StackOverflowHanlde { get; set; }

        [StringLength(50)]
        [Required]
        public string GithubHandle { get; set; }

        [StringLength(50)]
        [Required]
        public string FacebookHandle { get; set; }

        [StringLength(50)]
        [Required]
        public string GoogleID { get; set; }

        [StringLength(50)]
        [Required]
        public string AppleID { get; set; }

        public List<Post> AuthorPosts { get; set; }
    }
}
