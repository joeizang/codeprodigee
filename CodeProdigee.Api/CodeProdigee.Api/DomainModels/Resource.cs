using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CodeProdigee.Api.Abstractions;

namespace CodeProdigee.Api.DomainModels
{
    public class Resource : BaseDomainModel
    {
        public ResourceType TypeOfResource { get; set; }

        [StringLength(300)]
        [Required]
        public string Description { get; set; }

        [StringLength(300)]
        public string ResourceUrl { get; set; }
    }
}
