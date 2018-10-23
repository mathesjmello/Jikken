using System;
using System.Xml.Serialization;

namespace Graphene.ADInterpreter.ExportData{
    [Serializable] [XmlRoot(ElementName="Position", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
    public class Position {
        [XmlAttribute(AttributeName="X")]
        public string X;
        [XmlAttribute(AttributeName="Y")]
        public string Y;
    }
}