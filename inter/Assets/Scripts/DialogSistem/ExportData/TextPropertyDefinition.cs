using System;
using System.Xml.Serialization;

namespace Graphene.ADInterpreter.ExportData{
    [Serializable] [XmlRoot(ElementName="TextPropertyDefinition", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
    public class TextPropertyDefinition {
        [XmlElement(ElementName="IsMandatory", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string IsMandatory;
        [XmlElement(ElementName="IsLocalized", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string IsLocalized;
        [XmlElement(ElementName="AllowsLinebreaks", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string AllowsLinebreaks;
        [XmlAttribute(AttributeName="Id")]
        public string Id;
        [XmlElement(ElementName="DisplayName", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public DisplayName DisplayName;
        [XmlElement(ElementName="TechnicalName", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string TechnicalName;
        [XmlAttribute(AttributeName="BasedOn")]
        public string BasedOn;
    }
}