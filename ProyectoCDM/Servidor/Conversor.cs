using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;

namespace Servidor
{
    public class Conversor : MarshalByRefObject, IConversor
    { 
        public string Convertir(String xmlSolicitud)
        {
            // Deserializamos la solicitud:
            var solicitud = XmlHelper.Deserialize<Solicitud>(xmlSolicitud);

            // Calculamos la conversión:
            decimal tasa = ObtenerTasa(solicitud.De, solicitud.Hacia);
            decimal resultado = solicitud.Unidades * tasa;

            // Preparamos la respuesta:
            var respuesta = new Respuesta
            {
                Hacia = solicitud.Hacia,
                UnidadesConvertidas = resultado,
                Tasa = tasa


            };

            // Serializamos la respuesta:
            return XmlHelper.SerializeToXml(respuesta);
        }

        private decimal ObtenerTasa(Moneda from, Moneda to)
        {
            // Tasas ficticias para ejemplo (puedes personalizarlas)
            if (from == Moneda.USD && to == Moneda.EUR) return 0.93M;
            if (from == Moneda.EUR && to == Moneda.USD) return 1.07M;

            // Misma moneda
            return 1.0M;
        }

    }
}
