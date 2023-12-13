using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
   [SerializeField] private Transform teleportTarget;

   void OnTriggerEnter(Collider other)
   {
    if(other.tag == "Player"){
            Debug.Log("test Player");
            other.transform.position = teleportTarget.transform.position;
        }
    
   }
  
}
