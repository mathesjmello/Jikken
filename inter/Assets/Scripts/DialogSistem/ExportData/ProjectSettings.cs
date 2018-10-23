using System;
using System.Xml.Serialization;

namespace Graphene.ADInterpreter.ExportData
{
    [Serializable] [XmlRoot(ElementName="ProjectSettings", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
    public class ProjectSettings {
        [XmlElement(ElementName="FlowSettings", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public FlowSettings FlowSettings;
        [XmlElement(ElementName="JourneySettings", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public JourneySettings JourneySettings;
        [XmlElement(ElementName="LocationSettings", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public LocationSettings LocationSettings;
        [XmlElement(ElementName="ExternalApplications", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string ExternalApplications;
        [XmlAttribute(AttributeName="Id")]
        public string Id;
    }
}