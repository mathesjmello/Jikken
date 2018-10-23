using System;
using System.Xml.Serialization;

namespace Graphene.ADInterpreter.ExportData
{
    [Serializable] [XmlRoot(ElementName="Export", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
    public class ArticyDraftData {
        [XmlElement(ElementName="Settings", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public Settings Settings;
        [XmlElement(ElementName="Content", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public Content Content;
        [XmlElement(ElementName="Hierarchy", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public Hierarchy Hierarchy;
        [XmlAttribute(AttributeName="xmlns")]
        public string Xmlns;
        [XmlAttribute(AttributeName="Version")]
        public string Version;
        [XmlAttribute(AttributeName="CreatorTool")]
        public string CreatorTool;
        [XmlAttribute(AttributeName="CreatorVersion")]
        public string CreatorVersion;
        [XmlAttribute(AttributeName="CreatedOn")]
        public string CreatedOn;
    }
}