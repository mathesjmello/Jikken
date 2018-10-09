using System.IO;
using System.Text;
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
          //  OrderDialogueFragments();
        }

        

        private void Deserialize()
        {
            if(!File.Exists(Application.dataPath+FilePath)) return;
            
            XmlSerializer serializer = new XmlSerializer(typeof(ArticyDraftData));
            Data = (ArticyDraftData) serializer.Deserialize(new XmlTextReader(Application.dataPath+FilePath));
            var utf8 = Encoding.UTF8;
            var ascii = Encoding.ASCII;
            Debug.Log(Data.Content.DialogueFragment.Count);
            foreach (var text in Data.Content.DialogueFragment)
            {
                var bt = ascii.GetBytes(text.Text.LocalizedString.Text);
                Debug.Log(utf8.GetString(bt, 0 , bt.Length));
                bt = ascii.GetBytes(text.Text.LocalizedString.Text);
                Debug.Log(ascii.GetString(bt));
                
            }
        }
        
        private void OrderDialogueFragments()
        {
            
        }
    }
}