using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Behaviour : MonoBehaviour
{

   public int damageAmount = 20;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Walls")
         {
            Debug.Log("got hit");
            CharacterHealth characterHealth = GetComponent<CharacterHealth>();
            if (characterHealth != null)
               {   Debug.Log("Take Damage");
                  characterHealth.TakeDamage(damageAmount);
               }
            
         }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Walls")
         {
            Debug.Log("STAY");
         }
    }

    void OnTriggerExit(Collider other)
    {
         if (other.gameObject.tag == "Walls")
         {
            Debug.Log("EXIT");
         }
    }
}
