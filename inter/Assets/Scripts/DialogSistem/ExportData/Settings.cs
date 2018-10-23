using System;
using System.Xml.Serialization;

namespace Graphene.ADInterpreter.ExportData{
    [Serializable] [XmlRoot(ElementName="Settings", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
    public class Settings {
        [XmlElement(ElementName="ExportMarkup", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string ExportMarkup;
        [XmlElement(ElementName="ExportQueries", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string ExportQueries;
        [XmlElement(ElementName="WriteNamespace", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string WriteNamespace;
        [XmlElement(ElementName="WriteAllVariables", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string WriteAllVariables;
    }
}