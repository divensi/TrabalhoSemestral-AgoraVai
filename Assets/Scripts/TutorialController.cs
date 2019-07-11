using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialController : MonoBehaviour
{
    public int paginaAtual = 0;

    public List<GameObject> paginas;

    public void ProximaPagina()
    {
        if (paginaAtual == paginas.Count - 1)
            RunGame();
        else
            paginaAtual++;

        for (int i = 0; i < paginas.Count; i++)
        {
            if (i == paginaAtual)
                paginas[i].SetActive(true);
            else
                paginas[i].SetActive(false);
        }
    }

    public void RunGame()
    {
        SceneManager.LoadScene("Scene1");

        Debug.Log("rungame");
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
        Time.timeScale = 1f;
    }

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;

        if (paginas.Count > 0)
        {
            paginas[0].SetActive(true);
        }

    }
}
