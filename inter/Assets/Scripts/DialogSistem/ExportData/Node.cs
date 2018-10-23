using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Graphene.ADInterpreter.ExportData
{
    [Serializable] [XmlRoot(ElementName="Node", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
    public class Node {
        [XmlAttribute(AttributeName="IdRef")]
        public string IdRef;
        [XmlAttribute(AttributeName="Type")]
        public string Type;
        [XmlElement(ElementName="Node", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public List<Node> node;
    }
}