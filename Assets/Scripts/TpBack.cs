using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpBack : MonoBehaviour
{

    [SerializeField] private InfoJoueur infoJoueur;

    [SerializeField] private Transform backTemple;
    [SerializeField] private Transform backViking;
    [SerializeField] private GameObject player;

    // Update is called once per frame
    void Update()
    {
        if(infoJoueur.inTempleGrec){
            player.transform.position = backTemple.transform.position;
            infoJoueur.inTempleGrec = false;
        }

        if(infoJoueur.inMaisonViking){
            player.transform.position = backViking.transform.position;
            infoJoueur.inMaisonViking = false;
        }
    }
}
