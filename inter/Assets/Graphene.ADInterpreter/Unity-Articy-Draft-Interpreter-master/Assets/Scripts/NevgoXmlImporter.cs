using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Graphene.ADInterpreter.ExportData;
using UnityEngine;

namespace Graphene.ADInterpreter.Assets.Scripts
{
    [ExecuteInEditMode]
    public class NevgoXmlImporter : MonoBehaviour
    {
        public ArticyDraftData Data;

        public string FilePath = "/Assets/Graphene.ADInterpreter/Unity-Articy-Draft-Interpreter-master/jikken.xml";
        
        private void Awake()
        {
            Deserialize();
        }

        private void Deserialize()
        {
            if(!File.Exists(Application.dataPath+FilePath)) return;
            
            XmlSerializer serializer = new XmlSerializer(typeof(ArticyDraftData));
            Data = (ArticyDraftData) serializer.Deserialize(new XmlTextReader(Application.dataPath+FilePath));
            Debug.Log(Data.Content.DialogueFragment.Count);
        }
    }
}