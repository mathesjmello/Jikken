using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Graphene.ADInterpreter.ExportData
{
    [Serializable] [XmlRoot(ElementName="Pins", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
    public class Pins {
        [XmlElement(ElementName="Pin", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public List<Pin> Pin;
        [XmlAttribute(AttributeName="Count")]
        public string Count;
    }
}