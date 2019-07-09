using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieChefoesLifeControll : MonoBehaviour
{
    
    private  static float lifez1= 100f;
    private  static float lifez2= 100f;
    void Start(){
        lifez1= 100f;
        lifez2= 100f;
        

    }
    public void AddHit1 (float valor)
    {
        lifez1 -= valor;
    }

    public  void AddHit2 (float valor)
    {
        lifez2 -= valor;
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
