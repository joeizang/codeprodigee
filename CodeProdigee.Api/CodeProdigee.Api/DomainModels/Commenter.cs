using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeProdigee.Api.Abstractions;

namespace CodeProdigee.Api.DomainModels
{
    public class Commentator : BaseDomainModel
    {
        public string Email { get; set; }

        public string Name { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
