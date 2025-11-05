using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    // Con ver que es una interfaz podemos deducir que es un contrato compartido.
    public interface  IConversor
    {
        /// <summary>
        /// El xmlSolicitud: XML con {de donde, hacia donde, unidades}
        /// Retorna: XML con {hacia donde, unidadesconvertidas, Tasa, Timestamp}
        /// </summary>
        /// <param name="xmlSolicitud"></param>
        /// <returns></returns>
        string Convertir(string xmlSolicitud);

    }
}
