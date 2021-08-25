//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirportApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class Route
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Route()
        {
            this.Airlines = new HashSet<Airline>();
        }
    
        public int Route_Id { get; set; }
        public int Route_Operator_Id { get; set; }
        public int Route_Owner_Id { get; set; }
        public string Route_Destination_IATA { get; set; }
        public string Route_Home_IATA { get; set; }
    
        public virtual Airline Airline { get; set; }
        public virtual Airline Airline1 { get; set; }
        public virtual Airport Airport { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Airline> Airlines { get; set; }

        public override string ToString()
        {
            return
                "Route goes from : " +Airport.Airport_Name + "\n" +
                "in the city : " + Airport.Airport_City + "\n" +
                "to :" + Route_Destination_IATA + "\n" +
                "with airline company : " + Airline.Airline_Name + "\n" +
                "and the operator is :" + Airline1.Airline_Name + "\n";
        }
    }
}
