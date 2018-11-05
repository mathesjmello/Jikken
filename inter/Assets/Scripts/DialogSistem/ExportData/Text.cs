using System;
using System.Xml.Serialization;

namespace Graphene.ADInterpreter.ExportData{
    [Serializable] [XmlRoot(ElementName="Text", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
    public class Text {
        [XmlElement(ElementName="LocalizedString", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public LocalizedString LocalizedString;
        [XmlAttribute(AttributeName="Count")]
        public string Count;
        [XmlAttribute(AttributeName="HasMarkup")]
        public string HasMarkup;
    }
}