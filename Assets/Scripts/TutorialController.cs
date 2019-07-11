using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialController : MonoBehaviour
{
    public int paginaAtual = 0;

    public List<GameObject> paginas;

    public void ProximaPagina()
    {
        if (paginaAtual == paginas.Count - 1)
            Debug.Log("Ultima Pagina");
        else
            paginaAtual++;

        for (int i = 0; i < paginas.Count; i++) {
            if (i == paginaAtual) 
                paginas[paginaAtual].SetActive(true);
            else
                paginas[paginaAtual].SetActive(false);
        }
    }

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;
    }
}
