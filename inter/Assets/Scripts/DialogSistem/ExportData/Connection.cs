using System;
using System.Xml.Serialization;

namespace Graphene.ADInterpreter.ExportData{
    [Serializable] [XmlRoot(ElementName="Connection", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
    public class Connection {
        [XmlElement(ElementName="Color", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string Color;
        [XmlElement(ElementName="TechnicalName", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string TechnicalName;
        [XmlElement(ElementName="Url", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string Url;
        [XmlElement(ElementName="Label", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public Label Label;
        [XmlElement(ElementName="Source", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public Source Source;
        [XmlElement(ElementName="Target", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public Target Target;
        [XmlElement(ElementName="ShowLabel", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string ShowLabel;
        [XmlAttribute(AttributeName="Id")]
        public string Id;
    }
}