using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum BodyIdentification
{
    Head,
    Chest,
    Hand
}


public class HitableBodyPart : MonoBehaviour {
    [SerializeField]private BodyIdentification bodyIdentification;
    private CharaterDamage charaterDamage;
    Animator animator;
    private ZombieChefoesLifeControll gameControl;
    void Start(){
        gameControl=  gameObject.GetComponentInParent(typeof(ZombieChefoesLifeControll)) as ZombieChefoesLifeControll;
        //Debug.Log(gameControl);
    }
    private void Awake()
    {
        charaterDamage = GetComponentInParent<CharaterDamage>();
        animator = GetComponentInParent<Animator>();
    }
    private void OnCollisionEnter(Collision collision)
    { 

        if(collision != null ){
        Debug.Log("collision "+gameObject.tag);
        if(gameObject.CompareTag("chefao")){
            var objectRB = collision.gameObject.GetComponent<Rigidbody>();
            gameControl.AddHit1(objectRB.mass);
            if(gameControl.GetLife1() <=0 ){
                animator.SetBool("Walk", false);
                animator.SetBool("Attack",  false);
                animator.SetBool("Die", true);
                //você venceu
                
            }
            Debug.Log(gameControl.GetLife1());
                
         }else if (gameObject.CompareTag("chefao2")){

            var objectRB = collision.gameObject.GetComponent<Rigidbody>();
            gameControl.AddHit2(objectRB.mass);
            if(gameControl.GetLife2() <=0 ){
                animator.SetBool("Walk", false);
                animator.SetBool("Attack",  false);
                animator.SetBool("Die", true);
                //você venceu
                
            }
            Debug.Log(gameControl.GetLife2());
          }   
            else{ //normal zombie kill 
            //charaterDamage.OnBeingHit(bodyIdentification);
            animator.SetBool("Walk", false);
            animator.SetBool("Attack",  false);
            animator.SetBool("Die", true);
        } 
        }
    }

    private void Die()
    {
        Destroy(gameObject,2.0f);
    }
}


