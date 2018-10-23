using System;
using System.Xml.Serialization;

namespace Graphene.ADInterpreter.ExportData
{
    [Serializable] [XmlRoot(ElementName="Pin", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
    public class Pin {
        [XmlElement(ElementName="Expression", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string Expression;
        [XmlAttribute(AttributeName="Id")]
        public string Id;
        [XmlAttribute(AttributeName="Index")]
        public string Index;
        [XmlAttribute(AttributeName="Semantic")]
        public string Semantic;
    }
}