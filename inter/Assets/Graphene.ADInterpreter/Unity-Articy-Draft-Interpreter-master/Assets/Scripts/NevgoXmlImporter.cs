using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;
using Boo.Lang;
using Graphene.ADInterpreter.ExportData;
using UnityEngine;

namespace Graphene.ADInterpreter.Assets.Scripts
{
    [ExecuteInEditMode]
    public class NevgoXmlImporter : MonoBehaviour
    {
        public List<string> Frases;
        
        public ArticyDraftData Data;

        public string FilePath = "jikken.xml";
        
        private void Awake()
        {
            Deserialize();
           // RemoveTags();
            //  OrderDialogueFragments();
        }

        


        private void Deserialize()
        {
            if(!File.Exists(Application.dataPath+FilePath)) return;
            
            XmlSerializer serializer = new XmlSerializer(typeof(ArticyDraftData));
            Data = (ArticyDraftData) serializer.Deserialize(new XmlTextReader(Application.dataPath+FilePath));
            Debug.Log(Data.Content.DialogueFragment.Count);
            foreach (var text in Data.Content.DialogueFragment)
            {
                var str = text.Text.LocalizedString.Text.Replace("<html><head><style>#s0 {text-align:left;} #s1 {font-size:11pt;} </style></head><body><p id=\"s0\"><span id=\"s1\">", "");
                str = str.Replace("</span></p></body></html>", "");
                str = str.Replace("</span><span id=\"s1\">", "");
                
                Debug.Log(str);
            }
                
        }
        
        
    }
}