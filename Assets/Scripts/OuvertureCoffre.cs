using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuvertureCoffre : MonoBehaviour
{
    [SerializeField] private Animator animateur;

    //Permet d'ouvrir la porte
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            animateur.SetBool("Trigger", true);
        }
    }

    //Permet de fermer la porte
    private void OnTriggerExit(Collider other){
        if(other.tag == "Player"){
            animateur.SetBool("Trigger", false);
        }
    }
}
