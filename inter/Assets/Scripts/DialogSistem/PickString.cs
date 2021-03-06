﻿using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace DialogSistem
{
    public class PickString: MonoBehaviour
    {
        public GameObject Help;
        public int DialogId;
        public int DialogLenthg;
        public NevgoXmlImporter Decoder;
        public List<string> CurrentDialog;
        
        public Text CurrentText;
        public GameObject DialogPainel;
        public Button Next;
        public Button Exit;


        private void OnTriggerEnter(Collider other)
        {
            Help.SetActive(true);
        }

        private void OnTriggerExit(Collider other)
        {
            Help.SetActive(false);
        }

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
            DialogsManager.StopTime();
            DialogsManager.GetObj(gameObject);
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
                Next.gameObject.SetActive(false);
                Exit.gameObject.SetActive(true);
            }
        }

        private void OnDestroy()
        {
            Help.SetActive(false);
        }
    }
}