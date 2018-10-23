using System;
using System.Xml.Serialization;

namespace Graphene.ADInterpreter.ExportData
{
    [Serializable] [XmlRoot(ElementName="PropertyDefinitionRef", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
    public class PropertyDefinitionRef {
        [XmlAttribute(AttributeName="IdRef")]
        public string IdRef;
    }
}