using System;
using System.Xml.Serialization;

namespace Graphene.ADInterpreter.ExportData{
    [Serializable] [XmlRoot(ElementName="Size", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
    public class Size {
        [XmlAttribute(AttributeName="Width")]
        public string Width;
        [XmlAttribute(AttributeName="Height")]
        public string Height;
    }
}