using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEnergyController : MonoBehaviour
{
    public Text indicadorPoder;
    public Text indicadorJeremias;

    private static int jeremiasMortos;

    private static float power;
    private static float scale = 1.0f;
    //Updatepower ();
    void Start()
    {
        Debug.Log("state");
        power = PlayerPrefs.GetFloat("energy");
        jeremiasMortos = PlayerPrefs.GetInt("jeremias");

        Debug.Log(power);
        Debug.Log(jeremiasMortos);

        if (power <= 0)
        {
            power = 2.0f;
        }


        scale = 1.0f;
    }

    public static void MataJeremias()
    {
        jeremiasMortos++;
        PlayerPrefs.SetFloat("jeremias", jeremiasMortos);
    }

    public void AddScale(float valor)
    {
        scale += valor;
        power = power * scale;

    }

    public void RemoveScale(float valor)
    {
        scale -= valor;
        power = power / scale;
    }

    public float GetScale()
    {
        return scale;

    }
    public void AddPower(float valor)
    {
        power += valor;
        PlayerPrefs.SetFloat("energy", power);
    }

    public void RemovePower(float valor)
    {
        Debug.Log("removeu :" + valor);
        power -= valor;
        PlayerPrefs.SetFloat("energy", power);
    }
    public float GetPower()
    {
        //*scale usado para permitir na fase final com o poder de aumento de scala poder pegar objetos com grande massa.
        return power;

    }

    void OnDisable()
    {
        PlayerPrefs.SetFloat("energy", power);
        Debug.Log("Energy no disable:");
        //Debug.Log(power);
    }
    void OnEnable()
    {
        power = PlayerPrefs.GetFloat("energy");
        Debug.Log("Energy no enable:");
        //Debug.Log(power);
    }

    void LateUpdate()
    {   
        if (indicadorPoder != null)
            indicadorPoder.text = "PWR: " + (power * scale);
        
        if (indicadorJeremias != null)
            indicadorJeremias.text = "JRM: " + jeremiasMortos;

    }
}
