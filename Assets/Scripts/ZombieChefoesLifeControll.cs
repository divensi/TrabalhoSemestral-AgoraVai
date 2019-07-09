using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieChefoesLifeControll : MonoBehaviour
{
    
    private  static float lifez1= 100f;
    private  static float lifez2= 100f;
    void Start(){
        lifez1= 1f;
        lifez2= 1f;
        

    }

    private void CheckAlive()
    {
        if(lifez1<= 0 && lifez2 <=0){
            //Você Venceu
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
