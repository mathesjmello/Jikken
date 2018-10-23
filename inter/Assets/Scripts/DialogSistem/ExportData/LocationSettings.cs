using System;
using System.Xml.Serialization;

namespace Graphene.ADInterpreter.ExportData
{
    [Serializable] [XmlRoot(ElementName="LocationSettings", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
    public class LocationSettings {
        [XmlElement(ElementName="ShowDisplayNameForZone", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string ShowDisplayNameForZone;
        [XmlElement(ElementName="DropShadowForZone", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string DropShadowForZone;
        [XmlElement(ElementName="DisplayNameSizeForZone", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string DisplayNameSizeForZone;
        [XmlElement(ElementName="DisplayNameColorForZone", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string DisplayNameColorForZone;
        [XmlElement(ElementName="ShowDisplayNameForPath", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string ShowDisplayNameForPath;
        [XmlElement(ElementName="DropShadowForPath", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string DropShadowForPath;
        [XmlElement(ElementName="DisplayNameSizeForPath", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string DisplayNameSizeForPath;
        [XmlElement(ElementName="DisplayNameColorForPath", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string DisplayNameColorForPath;
        [XmlElement(ElementName="ShowDisplayNameForImage", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string ShowDisplayNameForImage;
        [XmlElement(ElementName="DropShadowForImage", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string DropShadowForImage;
        [XmlElement(ElementName="DisplayNameSizeForImage", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string DisplayNameSizeForImage;
        [XmlElement(ElementName="DisplayNameColorForImage", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string DisplayNameColorForImage;
        [XmlElement(ElementName="ShowDisplayNameForSpot", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string ShowDisplayNameForSpot;
        [XmlElement(ElementName="DropShadowForSpot", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string DropShadowForSpot;
        [XmlElement(ElementName="DisplayNameColorForSpot", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string DisplayNameColorForSpot;
        [XmlElement(ElementName="SpotStyleKind", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string SpotStyleKind;
        [XmlElement(ElementName="SpotStyleSize", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string SpotStyleSize;
        [XmlElement(ElementName="ShowDisplayNameForLink", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string ShowDisplayNameForLink;
        [XmlElement(ElementName="DropShadowForLink", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string DropShadowForLink;
        [XmlElement(ElementName="DisplayNameColorForLink", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string DisplayNameColorForLink;
        [XmlElement(ElementName="LinkStyleKind", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string LinkStyleKind;
        [XmlElement(ElementName="LinkStyleSize", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string LinkStyleSize;
        [XmlElement(ElementName="DropShadowForText", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string DropShadowForText;
    }
}