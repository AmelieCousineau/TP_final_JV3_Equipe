using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boolean : MonoBehaviour
{
    [SerializeField] private InfoJoueur infoJoueur;

    // Start is called before the first frame update
    void Start()
    {
        infoJoueur.inTempleGrec = true;
    }
}
