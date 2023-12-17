using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class AfficherDecompte : MonoBehaviour
{
    [SerializeField] private InfoJoueur infoJoueur;

    [SerializeField] private TMP_Text champTexteTemps;

    public void AfficherTemps(){
        float temps = infoJoueur.nbTemps;

        if(temps < 0) temps = 0;

        //Convertir le temps en secondes
        TimeSpan ts = TimeSpan.FromSeconds(temps);

        champTexteTemps.text = string.Format("{0:00}:{1:00}:{2:000}", ts.Minutes, ts.Seconds, ts.Milliseconds);
    }
}
