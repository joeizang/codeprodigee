using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate;

namespace CodeProdigee.Api.Abstractions
{
    public abstract class BaseDomainModel : IBaseDomainModel
    {
        public BaseDomainModel()
        {
            if (Id == Guid.Empty) Id = Guid.NewGuid();
            if (CreatedOn == DateTimeOffset.MinValue) CreatedOn = DateTimeOffset.UtcNow;
            if (UpdatedOn == DateTimeOffset.MinValue) UpdatedOn = DateTimeOffset.UtcNow;
            if (string.IsNullOrEmpty(CreatedBy)) CreatedBy = "Anonymous";
            if (string.IsNullOrEmpty(UpdatedBy)) UpdatedBy = "Anonymous";

        }
        public Guid Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        [GraphQLIgnore]
        public DateTimeOffset UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        [GraphQLIgnore]
        public string UpdatedBy { get; set; }
        [GraphQLIgnore]
        public bool IsDeleted { get; set; }
    }
}
