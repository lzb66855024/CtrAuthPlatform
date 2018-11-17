namespace Ctr.AhphOcelot.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class AhphClientGroup
    {
        [Key]
        public int ClientGroupId { get; set; }

        public int? Id { get; set; }

        public int? GroupId { get; set; }
    }
}
