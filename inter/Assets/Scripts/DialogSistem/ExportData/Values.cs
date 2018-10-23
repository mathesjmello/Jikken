using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Graphene.ADInterpreter.ExportData{
    [Serializable] [XmlRoot(ElementName="Values", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
    public class Values {
        [XmlElement(ElementName="EnumValue", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public List<EnumValue> EnumValue;
        [XmlAttribute(AttributeName="Count")]
        public string Count;
    }
}