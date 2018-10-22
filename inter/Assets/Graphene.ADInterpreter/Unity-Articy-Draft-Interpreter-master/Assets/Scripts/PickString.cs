using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Graphene.ADInterpreter.Assets.Scripts
{
    public class PickString: NevgoXmlImporter
    {
        public int DialogLenthg;

        public List<string> CurrentDialog;
        
        public Text CurrentText;

        public Button Next;
        public Button Exit;


        private void Start()
        {
            CurrentDialog = Frases;
           // SetFragments();
        }

        public void SetFragments()
        {
            for (int i = 0; i < DialogLenthg; i++)
            {
                CurrentDialog[i] = Frases[0];
                Frases.RemoveAt(0);
                i++;
            }
            ShowDialog();
        }

        public void ShowDialog()
        {
            CurrentText.text = CurrentDialog[0];
            CurrentDialog.RemoveAt(0);
            if (CurrentDialog != null)
            {
                Next.gameObject.SetActive(true);
            }
            else
            {
                Exit.gameObject.SetActive(true);
            }
        }
    }
}