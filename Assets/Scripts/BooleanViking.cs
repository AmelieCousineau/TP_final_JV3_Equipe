using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleanViking : MonoBehaviour
{
    [SerializeField] private InfoJoueur infoJoueur;

    // Start is called before the first frame update
    void Start()
    {
        infoJoueur.inMaisonViking = true;
    }
}
