using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Graphene.ADInterpreter.ExportData;
using UnityEngine;

namespace DialogSistem
{
    
    //[ExecuteInEditMode]
    public class NevgoXmlImporter : MonoBehaviour
    {
        
        public List<string> Frases;
        
        public ArticyDraftData Data;

        public string FilePath = "/Jikken2.xml";
        
        private void Awake()
        {
            DontDestroyOnLoad(this);
            Frases=new List<string>();
            Deserialize();
            
        }

        


        private void Deserialize()
        {
            if(!File.Exists(Application.dataPath+FilePath)) return;
            
            XmlSerializer serializer = new XmlSerializer(typeof(ArticyDraftData));
            Data = (ArticyDraftData) serializer.Deserialize(new XmlTextReader(Application.dataPath+FilePath));
            foreach (var text in Data.Content.DialogueFragment)
            {
                var str = text.Text.LocalizedString.Text.Replace("<html><head><style>#s0 {text-align:left;} #s1 {font-size:11pt;} </style></head><body><p id=\"s0\"><span id=\"s1\">", "");
                str = str.Replace("</span></p></body></html>", "");
                str = str.Replace("</span><span id=\"s1\">", "");
                str = DecodeHtmlChars(str);
                Frases.Add(str);
            }
                
        }
        string DecodeHtmlChars(string aText)
        {
            string[] parts = aText.Split(new string[]{"&#"}, StringSplitOptions.None);
            for (int i = 1; i < parts.Length; i++)
            {
                int n = parts[i].IndexOf(';');
                string number = parts[i].Substring(0,n);
                
                switch (number)
                {
                     case "225" :
                         number = "á";
                         break;
                     case "243" : 
                         number = "ó";
                         break;
                     case "227" : 
                         number = "ã";
                         break;
                     case "237" : 
                         number = "í";
                         break;
                     case "233" :
                         number = "é";
                         break;
                     case "234" : 
                         number = "ê";
                         break;
                     case "231" : 
                         number = "ç";
                         break;
                     case "245" : 
                         number = "õ";
                         
                         break;
                     case "244" :
                         number = "ô";
                         break;
                }
                try
                {
                    
                    parts[i] = (number) + parts[i].Substring(n+1);
               } catch {}
            }
            return String.Join("",parts);
        }
        
       
        
        
    }
}