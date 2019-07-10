using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieChefoesLifeControll : MonoBehaviour
{
    
    private  static float lifez1= 100f;
    private  static float lifez2= 100f;
    private bool ativarCarregamento;
    private float tempoCarregamento;
    public Texture textura;
    private Color cor = Color.black;
  
    
    void Start(){
        tempoCarregamento = 0.0f;
        ativarCarregamento=false;
        
        lifez1= 10f;
        lifez2= 10f;
        

    }
    void Update()
        {
     if (ativarCarregamento == true){

        	tempoCarregamento += Time.deltaTime;

        	if(tempoCarregamento>=5){
                    //som de vitoria
                    //canvas de vitoria
        		ativarCarregamento = false;
        		Application.LoadLevel(0);
        	}
        }

    
    }
    void OnGUI(){
    	cor.a =(int)(tempoCarregamento);
    	GUI.color = cor;
    	GUI.DrawTexture(new Rect (0,0,Screen.width,Screen.height),textura);
    }
    
    
    private void CheckAlive()
    {
        if(lifez1<= 0 && lifez2 <=0){
            //Você Venceu
            ativarCarregamento = true;
            Debug.Log("Player Venceu");
    
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
