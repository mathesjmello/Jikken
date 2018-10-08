using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Graphene.ADInterpreter.ExportData
{
    [Serializable] [XmlRoot(ElementName="PropertyDefinitions", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
    public class PropertyDefinitions {
        [XmlElement(ElementName="PropertyDefinitionRef", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public List<PropertyDefinitionRef> PropertyDefinitionRef;
        [XmlAttribute(AttributeName="Count")]
        public string Count;
    }
}