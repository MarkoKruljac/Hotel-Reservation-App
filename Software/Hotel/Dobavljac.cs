
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
    
public partial class Dobavljac
{

    public int ID_dobavljac { get; set; }

    public string Naziv { get; set; }

    public string Adresa { get; set; }

    public System.DateTime Datum_pocetka_ugovora { get; set; }

    public System.DateTime Datum_isteka_ugovora { get; set; }

    public string Telefon { get; set; }

    public string Email { get; set; }

    public string Broj_ziro_racuna { get; set; }

    public int ID_hotela { get; set; }



    public virtual Hotel Hotel { get; set; }

}

}
