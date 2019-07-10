using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEnergyController : MonoBehaviour
{
    public Text indicadorPoder;
    private  static float power;
    private  static float scale= 1.0f;
    //Updatepower ();
    void Start(){
        
        if(power <= 0){ 
            power= 2.0f;
            
        }
        scale= 1.0f;

    }
    public void AddScale (float valor)
    {
        scale += valor;
    }

    public  void RemoveScale (float valor)
    {
        scale -= valor;
    }

    public  float GetScale ()
    {
        return scale;
     
    }
    public  void AddPower (float valor)
    {
        power += valor*scale;
    }

    public  void RemovePower (float valor)
    {
        power -= valor;
    }
  	public  float GetPower ()
    {
        //*scale usado para permitir na fase final com o poder de aumento de scala poder pegar objetos com grande massa.
        return power*scale;
     
    }

    void OnDisable()
        {
            PlayerPrefs.SetFloat("energy", power);
            //Debug.Log("Energy no disable:");
            //Debug.Log(power);
        }
    void OnEnable()
    {
        power  =  PlayerPrefs.GetFloat("energy");
        //Debug.Log("Energy no enable:");
        //Debug.Log(power);
    }

    void LateUpdate()
    {
        if (indicadorPoder != null)
            indicadorPoder.text = "" + power*scale;
    }
}
