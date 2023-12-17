using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "InfosJoueur", menuName = "SO/NouveauJoueur")]
public class InfoJoueur : ScriptableObject
{
    [Header("nombre de points")]
    public int nbPoints;

    [Header("nombre de temps")]
    public float nbTemps;

    public bool inTempleGrec;
    public bool inMaisonViking;

    private void OnEnable(){
        nbPoints = 0;
        nbTemps = 300;
    }
}
