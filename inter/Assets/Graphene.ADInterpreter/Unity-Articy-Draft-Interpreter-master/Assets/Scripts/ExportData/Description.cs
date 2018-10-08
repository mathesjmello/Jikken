using System;
using System.Xml.Serialization;

namespace Graphene.ADInterpreter.ExportData{
    [Serializable] [XmlRoot(ElementName="Description", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
    public class Description {
        [XmlElement(ElementName="LocalizedString", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public LocalizedString LocalizedString;
        [XmlAttribute(AttributeName="Count")]
        public string Count;
    }
}