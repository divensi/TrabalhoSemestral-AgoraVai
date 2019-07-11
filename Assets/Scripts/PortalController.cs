using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class PortalController : MonoBehaviour
{
    public AudioSource barulho;
    public VideoPlayer video;
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
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            barulho.Play();
            video.Play();
            CanvasObject.GetComponent<Canvas>().enabled = true;
            Invoke("LoadScene", 7);
        }
    }

    void LoadScene() {
        SceneManager.LoadScene("Scene-Final");
    }
}
