using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.ImageEffects;
using UnityEngine.SceneManagement;

namespace ExamineSystem
{
    public class DocumentsListDisappear : MonoBehaviour
    {
        public GameObject bgi;
        public GameObject mainCam;//your other object
        public GameObject documentsList;
        public string examineRay;// your secound script name
        RectTransform rectTransform;
        public GameObject blurOut;
        [SerializeField] public Image crosshair = null;
        [SerializeField] public FirstPersonController player = null;
        [SerializeField] public BlurOptimized blur = null;
        public bool isListAlreadyOn;
        public DisplayInventory displayInventory;
        public InventoryDisappear inventoryDisappear;
        public GameObject violinUi;
        public BoxCollider violinBdCollider;
        public GameObject video;
        public GameObject[] documentsUI;
        // Update is called once per frame
        private void Awake()
        {
            
        }
        void Update()
        {
            if (video)
            {
                if (isListAlreadyOn == false && video.activeInHierarchy == false && inventoryDisappear.isInventoryAlreadyOn == false && CheckBool.isBuffering == false)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Debug.Log("haha");
                        documentsList.SetActive(true); 
                        Cursor.lockState = CursorLockMode.None;
                        Cursor.visible = true;
                        blur.enabled = true;
                        bgi.SetActive(true);
                        crosshair.enabled = false;
                        player.enabled = false;
                        Time.timeScale = 0f;
                        blurOut.SetActive(true);
                        (mainCam.GetComponent(examineRay) as MonoBehaviour).enabled = false;
                        isListAlreadyOn = true;
                    }

                }
                else if (isListAlreadyOn == true)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Debug.Log("hoho");
                        Cursor.lockState = CursorLockMode.Locked;
                        Cursor.visible = false;
                        documentsList.SetActive(false);
                        for(int i = 0; i < documentsUI.Length; i++)
                        {
                            documentsUI[i].SetActive(false);
                        }
                        blur.enabled = false;
                        bgi.SetActive(false);
                        crosshair.enabled = true;
                        player.enabled = true;
                        Time.timeScale = 1f;
                        blurOut.SetActive(false);
                        (mainCam.GetComponent(examineRay) as MonoBehaviour).enabled = true;
                        isListAlreadyOn = false;
                    }

                }
            }

            if (!video)
            {
                if (isListAlreadyOn == false && inventoryDisappear.isInventoryAlreadyOn == false && CheckBool.isBuffering == false)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Debug.Log("haha");
                        Cursor.lockState = CursorLockMode.None;
                        Cursor.visible = true;
                        documentsList.SetActive(true);
                        blur.enabled = true;
                        bgi.SetActive(true);
                        crosshair.enabled = false;
                        player.enabled = false;
                        Time.timeScale = 0f;
                        blurOut.SetActive(true);
                        (mainCam.GetComponent(examineRay) as MonoBehaviour).enabled = false;
                        isListAlreadyOn = true;
                    }

                }
                else if (isListAlreadyOn == true)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Debug.Log("hoho");
                        Cursor.lockState = CursorLockMode.Locked;
                        Cursor.visible = false;
                        documentsList.SetActive(false);
                        for (int i = 0; i < documentsUI.Length; i++)
                        {
                            documentsUI[i].SetActive(false);
                        }
                        blur.enabled = false;
                        bgi.SetActive(false);
                        crosshair.enabled = true;
                        player.enabled = true;
                        Time.timeScale = 1f;
                        blurOut.SetActive(false);
                        (mainCam.GetComponent(examineRay) as MonoBehaviour).enabled = true;
                        isListAlreadyOn = false; 
                    }

                }
            }



        }
    }
}
