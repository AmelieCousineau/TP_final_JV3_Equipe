using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
   public Transform teleportTarget;
   public GameObject thePlayer;

   [SerializeField] Transform portail_1;
   [SerializeField] Transform portail_2;
   [SerializeField] GameObject portail_3;
   [SerializeField] GameObject portail_4;
    [SerializeField] GameObject portail_back_1;
    [SerializeField] GameObject portail_back_2;
    [SerializeField] GameObject portail_back_3;
    [SerializeField] GameObject portail_back_4;

   /// <summary>
   /// OnTriggerEnter is called when the Collider other enters the trigger.
   /// </summary>
   /// <param name="other">The other Collider involved in this collision.</param>
   void OnTriggerEnter(Collider other)
   {
    if(other.tag == "Player"){
            Debug.Log("test Player");
            thePlayer.transform.position = teleportTarget.transform.position;
            if(other == portail_1){
                Debug.Log("test portail_1");
                
            }
        }
    
   }
  
}
