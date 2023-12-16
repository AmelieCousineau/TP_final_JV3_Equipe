using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    [SerializeField] private InfoJoueur infoJoueur;

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Main"){
            Invoke("DetruireObjet", 2.0f);
        }
    }

    private void DetruireObjet(){
        Destroy(gameObject);
        infoJoueur.nbPoints ++;
    }
}
