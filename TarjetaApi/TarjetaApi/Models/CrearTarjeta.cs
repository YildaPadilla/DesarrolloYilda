using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TarjetaApi.Models
{
    public class CrearTarjeta
    {
        public string nummeroTarjeta { get; set; }
        public string fechaVencimiento { get; set; }
        public string nombreTitular { get; set; }
        public string cvv { get; set; }
    }
}