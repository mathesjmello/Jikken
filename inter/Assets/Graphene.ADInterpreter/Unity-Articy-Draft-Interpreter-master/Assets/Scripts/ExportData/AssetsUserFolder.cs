using System;
using System.Xml.Serialization;
using Graphene.ADInterpreter.ExportData;

namespace Graphene.ADInterpreter.ExportData    
{
    [Serializable] [XmlRoot(ElementName="AssetsUserFolder", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
    public class AssetsUserFolder {
        [XmlElement(ElementName="DisplayName", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public DisplayName DisplayName;
        [XmlElement(ElementName="Color", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string Color;
        [XmlElement(ElementName="TechnicalName", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string TechnicalName;
        [XmlElement(ElementName="ExternalId", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string ExternalId;
        [XmlElement(ElementName="ShortId", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string ShortId;
        [XmlElement(ElementName="Url", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string Url;
        [XmlAttribute(AttributeName="Id")]
        public string Id;
    }
}