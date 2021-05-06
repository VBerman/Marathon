namespace marathon_session1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EventType")]
    public partial class EventType
    {
        [StringLength(2)]
        public string EventTypeId { get; set; }

        [Required]
        [StringLength(50)]
        public string EventTypeName { get; set; }
    }
}
