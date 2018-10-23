using System;
using System.Xml.Serialization;

namespace Graphene.ADInterpreter.ExportData    {
    [Serializable] [XmlRoot(ElementName="JourneySettings", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
    public class JourneySettings {
        [XmlElement(ElementName="BackgroundImageMode", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string BackgroundImageMode;
        [XmlElement(ElementName="BackgroundImagePositioningMode", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string BackgroundImagePositioningMode;
        [XmlElement(ElementName="BackgroundColorMode", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string BackgroundColorMode;
        [XmlElement(ElementName="BackgroundColor", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string BackgroundColor;
        [XmlElement(ElementName="BackgroundColorGradientMode", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string BackgroundColorGradientMode;
        [XmlElement(ElementName="Duration", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string Duration;
        [XmlElement(ElementName="TransitionMode", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string TransitionMode;
    }
}