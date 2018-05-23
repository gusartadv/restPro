using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

      
        

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{xp}")]
        public async Task<string> Ss(string xp) 
        {

            string mensaje = string.Empty;
            string factura = string.Empty;

            string[] x;
            string des = string.Empty;
            x = xp.Split("-");

            des = x[2];
            ServiceReference1.PagosInerfaceClient pago = new ServiceReference1.PagosInerfaceClient();


            switch (des)
                {
                case "1":

                    ServiceReference1.Pago servPag = new ServiceReference1.Pago();


                    servPag.totalPagar = Convert.ToDouble(x[0]);


                    ServiceReference1.ResultadoConsulta Resu = new ServiceReference1.ResultadoConsulta();
                    ServiceReference1.ReferenciaFactura ObjResul = new ServiceReference1.ReferenciaFactura();

                    ObjResul.referenciaFactura = x[1];
                    servPag.referenciaFactura = ObjResul;
                    var xx = await pago.PagarAsync(servPag);

                     mensaje = xx.Resultado.mensaje;
                     factura = xx.Resultado.referenciaFactura.referenciaFactura;
                    break;

                case "2":

                    ServiceReference1.Pago servPag2 = new ServiceReference1.Pago();


                    servPag2.totalPagar = Convert.ToDouble(x[0]);


                    ServiceReference1.ResultadoConsulta Resu2 = new ServiceReference1.ResultadoConsulta();
                    ServiceReference1.ReferenciaFactura ObjResul2 = new ServiceReference1.ReferenciaFactura();

                    ObjResul2.referenciaFactura = x[1];
                    servPag2.referenciaFactura = ObjResul2;
                    var xx2 = await pago.CompensarAsync(servPag2);

                     mensaje = xx2.Resultado.mensaje;
                     factura = xx2.Resultado.referenciaFactura.referenciaFactura;
                    break;

            }

            return mensaje + "-" + factura;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
