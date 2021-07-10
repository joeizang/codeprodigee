using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeProdigee.Api.Abstractions;

namespace CodeProdigee.Api.DomainModels
{
    public class Comment : BaseDomainModel
    {
        public string CommentBody { get; set; }

        public DateTimeOffset CommentDate { get; set; }

        public Guid CommentatorId { get; set; }

        public Commentator Commentator { get; set; }

        public Post CommentedPost { get; set; }

        public Guid CommentedPostId { get; set; }

        public List<Comment> Replies { get; set; }

        public Comment OriginalComment { get; set; }
    }
}
