using System.Collections.Generic;
using UnityEngine.UI;

namespace DialogSistem
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
        }

        public void SetDialogLenthg(int dl)
        {
            DialogLenthg = dl;
            ShowDialog();
        }
        public void ShowDialog()
        {
            
            CurrentText.text = CurrentDialog[0];
            if (DialogLenthg>0)
            {
                CurrentDialog.RemoveAt(0);
                Next.gameObject.SetActive(true);
                DialogLenthg--;
            }
            else
            {
                CurrentDialog.RemoveAt(0);
                Exit.gameObject.SetActive(true);
            }
        }
    }
}