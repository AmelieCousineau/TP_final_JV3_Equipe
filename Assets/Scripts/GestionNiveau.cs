using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class GestionNiveau : MonoBehaviour
{
    [Header("Les informations gardées en mémoire")]
    [SerializeField] private InfoJoueur infoJoueur;

    [Space(50)]

    [Header("Information pour le Canvas")]
    [SerializeField] private TMP_Text champTemps;

    [Space(50)]

    [Header("Information pour le décompte du temps")]
    private bool decompteActif = false;
    public UnityEvent auChangementDuTemps;
    public UnityEvent aLaFinDuTemps;

    void Start()
    {
        DemarrerDecompte();
    }

    void Update()
    {
        champTemps.text = infoJoueur.nbTemps.ToString();

        if(decompteActif){
            if(infoJoueur.nbTemps > 0){
                //On décrémente le temps
                infoJoueur.nbTemps -= Time.deltaTime;

                //On envoie l'événement
                auChangementDuTemps.Invoke();
            }

            else{
                infoJoueur.nbTemps = 0;
                decompteActif = false;

                //On envoie l'événement
                aLaFinDuTemps.Invoke();
            }
        }
    }

    public void DemarrerDecompte(){
        decompteActif = true;
    }

}
