
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace CuoiKi
{

using System;
    using System.Collections.Generic;
    
public partial class Order
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Order()
    {

        this.Lineitems = new HashSet<Lineitem>();

    }


    public int order_id { get; set; }

    public Nullable<System.DateTime> order_date { get; set; }

    public Nullable<int> customer_id { get; set; }

    public Nullable<int> employee_id { get; set; }

    public Nullable<double> total { get; set; }



    public virtual Customer Customer { get; set; }

    public virtual Employee Employee { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Lineitem> Lineitems { get; set; }

}

}
