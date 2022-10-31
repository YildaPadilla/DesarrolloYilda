using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TarjetaApi.Models;

namespace TarjetaApi.Controllers
{
    [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
    public class TarjetasController : ApiController
    {
        
        public IHttpActionResult GetTarjeta()
        {
            using (TarjetaDBEntities db = new TarjetaDBEntities())
            {
                var t = db.Tarjeta.Select(x => new
                {
                    id = x.idTarjeta,
                    x.nummeroTarjeta,
                    x.fechaVencimiento,
                    x.nombreTitular,
                    x.cvv
                }).ToList();                
                return Ok(t);
            }
        }

        [HttpPost]
        public IHttpActionResult PostTarjeta(CrearTarjeta c)
        {
            using (TarjetaDBEntities db = new TarjetaDBEntities())
            {
                var t = new Tarjeta()
                {
                    nummeroTarjeta = c.nummeroTarjeta,
                    fechaVencimiento = c.fechaVencimiento,
                    nombreTitular = c.nombreTitular,
                    cvv = c.cvv
                };
                var tarjetaRef = db.Tarjeta.Add(t);
                db.SaveChanges();
                return Ok(tarjetaRef);
            }
        }

        [HttpPost]
        public IHttpActionResult PutTarjeta(int? id, CrearTarjeta c)
        {
            using (TarjetaDBEntities db = new TarjetaDBEntities())
            {
                var t = new Tarjeta()
                {
                    nummeroTarjeta = c.nummeroTarjeta,
                    fechaVencimiento = c.fechaVencimiento,
                    nombreTitular = c.nombreTitular,
                    cvv = c.cvv
                };
                var tarjetaRef = db.Tarjeta.Add(t);
                db.SaveChanges();
                return Ok(tarjetaRef);
            }
        }
    }
}
