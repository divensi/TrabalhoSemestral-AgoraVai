using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PortalController : MonoBehaviour
{
    private bool ativarCarregamento;
    private float tempoCarregamento;
    private GameObject CanvasObject;
    void Start()
    {
        tempoCarregamento = 0.0f;
        ativarCarregamento = false;
        CanvasObject = GameObject.Find("Canvas-PassFase");
        CanvasObject.GetComponent<Canvas>().enabled = false;
    }
    void OnTriggerEnter(Collider other){
    	if(other.CompareTag("Player")){
            CanvasObject.GetComponent<Canvas>().enabled = true;
            SceneManager.LoadScene("Scene-Final");
    	}
    }
    void Update()
    {
    if (ativarCarregamento == true)
        {

            tempoCarregamento += Time.deltaTime;

            if (tempoCarregamento >= 6)
            {
                ativarCarregamento = false;
                PlayerPrefs.SetFloat("energy", 0.0f);
                Application.LoadLevel(0);
                //CanvasObject.GetComponent<Canvas>().enabled = false;
            }
        }
    }
}
