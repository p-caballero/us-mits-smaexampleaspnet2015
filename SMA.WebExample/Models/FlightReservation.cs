//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMA.WebExample.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FlightReservation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FlightReservation()
        {
            this.Reservation = new HashSet<Reservation>();
            this.Retours = new HashSet<Departure>();
        }
    
        public int FlightReservationId { get; set; }
        public string From { get; set; }
        public string ReservedSeats { get; set; }
        public string To { get; set; }
        public System.DateTime DateOfFlight { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservation { get; set; }
        public virtual Departure Tour { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Departure> Retours { get; set; }
    }
}
