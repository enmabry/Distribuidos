using System;
using System.Xml.Serialization;

namespace Libreria
{

    public enum Moneda
    {
        USD,
        EUR
    }

    // Lo que envía el cliente:

    [XmlRoot("SolicitudConversion")]
    public class Solicitud
    {
        [XmlElement("De")]
        public Moneda De { get; set; }

        [XmlElement("Hacia")]
        public Moneda Hacia { get; set; }

        [XmlElement("Unidades")]
        public decimal Unidades { get; set; }
    }

    // Lo que responde el servicio(servidor):

    [XmlRoot("RespuestaConversion")]
    public class Respuesta
    {
        [XmlElement("Hacia")]
        public Moneda Hacia { get; set; }
        
        [XmlElement("Unidades")]
        public decimal UnidadesConvertidas { get; set; }
        
        [XmlElement("Tasa")]
        public decimal Tasa { get; set; }
       
        [XmlElement("Timestamp")]
        public DateTime Timestamp { get; set; } = DateTime. UtcNow;
    }



}
