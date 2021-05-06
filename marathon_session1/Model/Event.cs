namespace marathon_session1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Event")]
    public partial class Event
    {
        [StringLength(6)]
        public string EventId { get; set; }

        [Required]
        [StringLength(50)]
        public string EventName { get; set; }

        [Required]
        [StringLength(2)]
        public string EventTypeId { get; set; }

        public byte MarathonId { get; set; }

        public DateTime? StartDateTime { get; set; }

        public decimal? Cost { get; set; }

        public short? MaxParticipants { get; set; }
    }
}
