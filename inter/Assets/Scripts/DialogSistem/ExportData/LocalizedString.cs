using System;
using System.Xml.Serialization;

namespace Graphene.ADInterpreter.ExportData{
    [Serializable] [XmlRoot(ElementName="LocalizedString", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
    public class LocalizedString {
        [XmlAttribute(AttributeName="Lang")]
        public string Lang;
        [XmlText]
        public string Text;
    }
}