using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Behaviour : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Walls")
         {
            Debug.Log("ENTER");
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
