﻿using System.ComponentModel.DataAnnotations;
using static HC.Foundation.Common.Constants.Constants;

namespace HC.Foundation.Data.Base.IBase
{
    public interface IBaseEntity
    {
        [Key]
        public int Id { get; set; }

        public Status Status { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public string? CreatedBy { get; set; }

        public string? UpdatedBy { get; set; }
    }
}