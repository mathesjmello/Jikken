using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Graphene.ADInterpreter.ExportData
{
    [Serializable] [XmlRoot(ElementName="Content", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
    public class Content {
        [XmlElement(ElementName="Project", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public Project Project;
        [XmlElement(ElementName="ProjectSettings", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public ProjectSettings ProjectSettings;
        [XmlElement(ElementName="Assets", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public Assets Assets;
        [XmlElement(ElementName="AssetsUserFolder", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public List<AssetsUserFolder> AssetsUserFolder;
        [XmlElement(ElementName="Documents", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public Documents Documents;
        [XmlElement(ElementName="Entities", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public Entities Entities;
        [XmlElement(ElementName="EntitiesUserFolder", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public List<EntitiesUserFolder> EntitiesUserFolder;
        [XmlElement(ElementName="Features", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public Features Features;
        [XmlElement(ElementName="Flow", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public Flow Flow;
        [XmlElement(ElementName="GlobalVariables", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public GlobalVariables GlobalVariables;
        [XmlElement(ElementName="Journeys", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public Journeys Journeys;
        [XmlElement(ElementName="Locations", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public Locations Locations;
        [XmlElement(ElementName="ObjectCustomization", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public ObjectCustomization ObjectCustomization;
        [XmlElement(ElementName="ObjectTemplates", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public ObjectTemplates ObjectTemplates;
        [XmlElement(ElementName="PropertyTemplates", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public PropertyTemplates PropertyTemplates;
        [XmlElement(ElementName="TypedObjectTemplates", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public List<TypedObjectTemplates> TypedObjectTemplates;
        [XmlElement(ElementName="TypedPropertyTemplates", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public List<TypedPropertyTemplates> TypedPropertyTemplates;
        [XmlElement(ElementName="Connection", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public List<Connection> Connection;
        [XmlElement(ElementName="Dialogue", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public List<Dialogue> Dialogue;
        [XmlElement(ElementName="DialogueFragment", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public List<DialogueFragment> DialogueFragment;
        [XmlElement(ElementName="Entity", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public List<Entity> Entity;
        [XmlElement(ElementName="FeatureDefinition", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public List<FeatureDefinition> FeatureDefinition;
        [XmlElement(ElementName="FlowFragment", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public FlowFragment FlowFragment;
        [XmlElement(ElementName="ObjectTemplateDefinition", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public List<ObjectTemplateDefinition> ObjectTemplateDefinition;
        [XmlElement(ElementName="NumberPropertyDefinition", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public List<NumberPropertyDefinition> NumberPropertyDefinition;
        [XmlElement(ElementName="TextPropertyDefinition", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public List<TextPropertyDefinition> TextPropertyDefinition;
        [XmlElement(ElementName="EnumerationPropertyDefinition", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public List<EnumerationPropertyDefinition> EnumerationPropertyDefinition;
        [XmlElement(ElementName="VariableSet", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public VariableSet VariableSet;
    }
}