using System;
using System.Xml.Serialization;

namespace Graphene.ADInterpreter.ExportData{
    [Serializable] [XmlRoot(ElementName="FlowSettings", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
    public class FlowSettings {
        [XmlElement(ElementName="BuiltInScriptSupport", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string BuiltInScriptSupport;
        [XmlElement(ElementName="GridSize", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string GridSize;
        [XmlElement(ElementName="GridSizeEnforced", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string GridSizeEnforced;
        [XmlElement(ElementName="SpacingHorizontal", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string SpacingHorizontal;
        [XmlElement(ElementName="SpacingVertical", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string SpacingVertical;
        [XmlElement(ElementName="SpacingEnforced", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string SpacingEnforced;
    }
}