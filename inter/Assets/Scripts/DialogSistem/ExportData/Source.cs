using System;
using System.Xml.Serialization;

namespace Graphene.ADInterpreter.ExportData
{
    [Serializable] [XmlRoot(ElementName="Source", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
    public class Source {
        [XmlAttribute(AttributeName="IdRef")]
        public string IdRef;
        [XmlAttribute(AttributeName="PinRef")]
        public string PinRef;
    }
}