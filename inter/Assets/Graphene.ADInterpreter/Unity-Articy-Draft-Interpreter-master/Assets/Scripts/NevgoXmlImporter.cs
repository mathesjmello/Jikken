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
            var utf8 = Encoding.UTF8;
            var ascii = Encoding.ASCII;
            Debug.Log(Data.Content.DialogueFragment.Count);
            foreach (var text in Data.Content.DialogueFragment)
            {
                char[] array = new char[text.Text.LocalizedString.Text.Length];
                int arrayIndex = 0;
                bool inside = false;

                for (int i = 0; i < text.Text.LocalizedString.Text.Length; i++)
                {
                    char let = text.Text.LocalizedString.Text[i];
                    if (let == '<')
                    {
                        inside = true;
                        continue;
                    }
                    if (let == '>')
                    {
                        inside = false;
                        continue;
                    }
                    if (!inside)
                    {
                        array[arrayIndex] = let;
                        arrayIndex++;
                    }
                }
                Debug.Log(text.Text.LocalizedString.Text);
            }
                
        }
        
        
    }
}