//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TarjetaApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tarjeta
    {
        public int idTarjeta { get; set; }
        public string nummeroTarjeta { get; set; }
        public string fechaVencimiento { get; set; }
        public string nombreTitular { get; set; }
        public string cvv { get; set; }
    }
}
