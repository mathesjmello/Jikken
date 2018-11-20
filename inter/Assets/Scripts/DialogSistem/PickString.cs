using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DialogSistem
{
    public class PickString: MonoBehaviour
    {
        public int DialogId;
        public int DialogLenthg;
        public NevgoXmlImporter Decoder;
        public List<string> CurrentDialog;
        
        public Text CurrentText;
        public GameObject DialogPainel;
        public Button Next;
        public Button Exit;


        private void Start()
        {
            Decoder = FindObjectOfType<NevgoXmlImporter>();
            CurrentDialog = Decoder.Frases;
        }
        

        public void SetDialogLenthg(int dl, int di)
        {
            DialogLenthg = dl;
            DialogId = di;
            ShowDialog();
        }
        public void ShowDialog()
        {
            StopTime();
            DialogPainel.SetActive(true);
            CurrentText.text = CurrentDialog[DialogId];
            if (DialogLenthg>0)
            {
                DialogId++;
                Next.gameObject.SetActive(true);
                DialogLenthg--;
            }
            else
            {
                DialogId++;
                Exit.gameObject.SetActive(true);
            }
        }

        private void StopTime()
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
        }

        public void Continue()
        {
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}