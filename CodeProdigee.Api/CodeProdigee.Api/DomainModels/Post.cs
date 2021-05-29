using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CodeProdigee.Api.Abstractions;
using HotChocolate;

namespace CodeProdigee.Api.DomainModels
{
    public class Post : BaseDomainModel
    {
        [StringLength(200)]
        [Required]
        public string Title { get; set; }

        [Required]
        [StringLength(3000)]
        public string Body { get; set; }

        public DateTimeOffset PublishDate { get; set; }

        public bool IsPublished { get; set; }

        public Author PostAuthor { get; set; }

        public Guid AuthorId { get; set; }

        public List<Comment> Comments { get; set; }

        public List<Resource> Resources { get; set; }
    }
}
