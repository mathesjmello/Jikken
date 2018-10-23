using System;
using System.Xml.Serialization;

namespace Graphene.ADInterpreter.ExportData{
    [Serializable] [XmlRoot(ElementName="References", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
    public class References {
        [XmlAttribute(AttributeName="Count")]
        public string Count;
    }
}