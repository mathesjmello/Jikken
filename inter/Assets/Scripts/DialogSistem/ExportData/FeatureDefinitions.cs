using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Graphene.ADInterpreter.ExportData{
    [Serializable] [XmlRoot(ElementName="FeatureDefinitions", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
    public class FeatureDefinitions {
        [XmlElement(ElementName="FeatureDefinitionRef", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public List<FeatureDefinitionRef> FeatureDefinitionRef;
        [XmlAttribute(AttributeName="Count")]
        public string Count;
    }
}