//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cuenta
    {
        public int ID { get; set; }
        public Nullable<int> IDCliente { get; set; }
        public string Tipo { get; set; }
        public Nullable<double> Saldo { get; set; }
        public Nullable<double> TasaInteres { get; set; }
        public Nullable<int> NumeroCuenta { get; set; }
    }
}