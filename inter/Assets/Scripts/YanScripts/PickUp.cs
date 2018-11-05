using System.Collections;
using DialogSistem;
using UnityEngine;
using Text = UnityEngine.UI.Text;

namespace YanScripts
{
    public class PickUp : MonoBehaviour
    {
        public GameObject InvetoryPanel;
        public GameObject[] InventoryIcons;
        public GameObject PickUpMinigameUi;

        public float[] UiSpawnVariation;

        ItenReferences ItenValues;
        GameObject ItemObject;

        int pickUpUiNumber;

        static public bool Interacting = false;

        static public int NReds, NBlues, NGreens ;


        private void Start()
        {
            LoadSavedvalues();
        }

        private void OnTriggerStay(Collider other)
        {
            if (other.GetComponent<ItenReferences>())
            {
                ItenValues = other.GetComponent<ItenReferences>();
                Debug.Log("Dificuldade: " + ItenValues.ItemDifficult);
            }
            if (other.GetComponent<ItenReferences>())
            {
                ItemObject = other.gameObject;
            }

            if (Input.GetButtonDown("Interact") && !Interacting)
            {
                pickUpUiNumber = 0;
                SpawnMiniGamePickUp();
                Interacting = true;
            }
            if (Input.GetButtonDown("Interact") && other.GetComponent<PickString>())
            {
                other.GetComponent<PickString>().SetDialogLenthg(other.GetComponent<PickString>().DialogLenthg,other.GetComponent<PickString>().DialogId);
            }

        }

        private void Update()
        {
            RaycastDetectionOnUiPickUp();
        }

        void SpawnMiniGamePickUp()
        {
            //Checa se o item ainda nao foi pego, se ainda nao foi, espawna outra UI, se foi atualiza o inventario e destroy o item.

            if (ItemObject != null)
            {
                float variaçao = Random.Range(UiSpawnVariation[0], UiSpawnVariation[1]);
                Vector3 SpawnPos = new Vector3(ItemObject.transform.position.x + variaçao, ItemObject.transform.position.y + variaçao, ItemObject.transform.position.z + variaçao);

                if (pickUpUiNumber < ItenValues.ItemDifficult)
                {
                    Debug.Log("Spawno");
                    Instantiate(PickUpMinigameUi, SpawnPos, Quaternion.identity);
                    pickUpUiNumber++;
                }
                else
                {
                    UpgradeSaveValues();
                    StartCoroutine(InventoryActualization());
                    Destroy(ItemObject);
                    Interacting = false;
                }
            }

        }

        void RaycastDetectionOnUiPickUp()
        {
            //Solta um Raycast do centro da tela que reconhece o Ui. Se apretar o 0 do mouse destroy a Ui e chama a funçao de spawnar outra 

            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100f, 1 << 9))
            {
                if (hit.collider.CompareTag("UiPickUp"))
                {
                    if (Input.GetMouseButton(0))
                    {
                        Debug.Log("Destruiu");
                        Destroy(hit.collider.gameObject);
                        Invoke("SpawnMiniGamePickUp", 0.3f);
                    }
                }
            }
        }

        void UpgradeSaveValues()
        {
            //Atualiza as variaveis que contam o numero de itens pegos 

            if (ItemObject.CompareTag("Red"))
            {
                NReds++;
            }
            else if (ItemObject.CompareTag("Blue"))
            {
                NBlues++;
            }
            else if (ItemObject.CompareTag("Green"))
            {
                NGreens++;
            }
        }

        void LoadSavedvalues()
        {
            //Pega o numero de itens que foi salvo, e ataliza o inventario com aqueles valores

            GameObject i;
            if (NReds > 0)
            {
                i = Instantiate(InventoryIcons[0]);
                i.transform.SetParent(InvetoryPanel.transform);
            }

            if (NBlues > 0)
            {
                i = Instantiate(InventoryIcons[1]);
                i.transform.SetParent(InvetoryPanel.transform);
            }

            if (NGreens > 0)
            {
                i = Instantiate(InventoryIcons[2]);
                i.transform.SetParent(InvetoryPanel.transform);
            }

            foreach (Transform Child in InvetoryPanel.transform)
            {
                if (Child.CompareTag("Red"))
                {
                    Child.Find("Text").GetComponent<Text>().text = NReds.ToString();
                }
                else
                if (Child.CompareTag("Blue"))
                {
                    Child.Find("Text").GetComponent<Text>().text = NBlues.ToString();
                }
                else
                if (Child.CompareTag("Green"))
                {
                    Child.Find("Text").GetComponent<Text>().text = NGreens.ToString();
                }
            }
        }


        IEnumerator InventoryActualization()
        {

            //Atualiza o inventario. Caso o item pego ja exista, aumenta o numero de exemplares no inventario. Caso nao tenha sido pego, adiciona o item ao inventario.
 
            foreach (Transform Child in InvetoryPanel.transform)
            {
                if (Child.gameObject.tag == ItemObject.gameObject.tag)
                {
                    string c = Child.Find("Text").GetComponent<Text>().text;
                    int tCount = System.Int32.Parse(c) + 1;
                    Child.Find("Text").GetComponent<Text>().text = "" + tCount;
                    yield return null;
                }
            }

            if (ItemObject != null)
            {
                GameObject i;
                if (ItemObject.CompareTag("Red"))
                {
                    i = Instantiate(InventoryIcons[0]);
                    i.transform.SetParent(InvetoryPanel.transform);
                }
                else if (ItemObject.CompareTag("Blue"))
                {
                    i = Instantiate(InventoryIcons[1]);
                    i.transform.SetParent(InvetoryPanel.transform);
                }
                else if (ItemObject.CompareTag("Green"))
                {
                    i = Instantiate(InventoryIcons[2]);
                    i.transform.SetParent(InvetoryPanel.transform);
                }
            }

            yield return null;
        
        }

    }
}
