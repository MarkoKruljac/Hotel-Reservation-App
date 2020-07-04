
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Hotel
{

using System;
    using System.Collections.Generic;
    
public partial class Rezervacija
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Rezervacija()
    {

        this.Racun = new HashSet<Racun>();

    }


    public int ID_rezervacija { get; set; }

    public System.DateTime Datum_pocetka { get; set; }

    public System.DateTime Datum_zavrsetka { get; set; }

    public double Cijena_rezervacije { get; set; }

    public int ID_sobe { get; set; }

    public int ID_gosta { get; set; }

    public int ID_usluge { get; set; }

    public int ID_vrste_rezervacije { get; set; }

    public Nullable<bool> PoslanEmail { get; set; }

    public int ID_hotela { get; set; }



    public virtual Gost Gost { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Racun> Racun { get; set; }

    public virtual Soba Soba { get; set; }

    public virtual Usluga Usluga { get; set; }

    public virtual VrstaRezervacije VrstaRezervacije { get; set; }

    public virtual Hotel Hotel { get; set; }

}

}
