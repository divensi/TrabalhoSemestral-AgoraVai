using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    void Start () {
        PlayerPrefs.SetFloat("energy", 0.0f);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None; 
        //Time.timeScale = 1.0f; 
     }
    public void Sair() 
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    public void Iniciar(string cena)
    {
        SceneManager.LoadScene(cena);

    }
}
