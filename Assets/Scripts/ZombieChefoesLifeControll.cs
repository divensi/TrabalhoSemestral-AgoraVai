using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ZombieChefoesLifeControll : MonoBehaviour
{
    
    private  static float lifez1= 100f;
    private  static float lifez2= 100f;
    private bool ativarCarregamento;
    private float tempoCarregamento;
    public Texture textura;
    private Color cor = Color.black;
    private AudioSource audioSourceFim;
    public Canvas CanvasObject;
    
    void Start(){
        var audioSources = GetComponents<AudioSource>();
        //nao mudar localização do som unity bugou e tava tocando do nada
        audioSourceFim = audioSources[3]; // som de vitoria
        audioSourceFim.Stop(); //  som de vitoria
        
        tempoCarregamento = 0.0f;
        ativarCarregamento=false;
        CanvasObject.GetComponent<Canvas>().enabled = false;
        
        
        lifez1= 100f;
        lifez2= 100f;

        
        

    }
    void Update()
        {
     if (ativarCarregamento == true){

        	tempoCarregamento += Time.deltaTime;

        	if(tempoCarregamento>= 10){
                    
                    
        		ativarCarregamento = false;
                        CanvasObject.GetComponent<Canvas>().enabled = false;
        		SceneManager.LoadScene(0);
        	}
        }

    
    }
    /*void OnGUI(){
    	cor.a =(int)(tempoCarregamento);
    	GUI.color = cor;
    	GUI.DrawTexture(new Rect (0,0,Screen.width,Screen.height),textura);
    }*/
    
    
    private void CheckAlive()
    {
        if(lifez1<= 0 && lifez2 <=0){
            //Você Venceu
            audioSourceFim.Play();
            ativarCarregamento = true;
            //Time.timeScale = 0.0f;
            Debug.Log("Player Venceu");
            CanvasObject.GetComponent<Canvas>().enabled = true;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            //som de vitoria
            //canvas de vitoria
            
    
        } 
        
    }
    public void AddHit1 (float valor)
    {
        lifez1 -= valor;
        CheckAlive();
    }

    public  void AddHit2 (float valor)
    {
        lifez2 -= valor;
        CheckAlive();
    }

    public  float GetLife1 ()
    {
        return lifez1;
     
    }
    public  float GetLife2 ()
    {
        return lifez2;
     
    }
}
