using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Victoire : MonoBehaviour
{
    [SerializeField] private InfoJoueur infoJoueur;

    [SerializeField] private GameObject portail;

    [SerializeField] private TMP_Text textNPC1;
    [SerializeField] private TMP_Text textNPC2;
    [SerializeField] private TMP_Text textNPC3;
    [SerializeField] private TMP_Text textNPC4;
    [SerializeField] private TMP_Text textNPC5;
    [SerializeField] private TMP_Text textNPC_Foret;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        VerifVictoire();
    }

    private void VerifVictoire(){
        if(infoJoueur.nbPoints == 5){
            portail.SetActive(true);

            textNPC1.text = "Rendez-vous dans la forêt";
            textNPC2.text = "Rendez-vous dans la forêt";
            textNPC3.text = "Rendez-vous dans la forêt";
            textNPC4.text = "Rendez-vous dans la forêt";
            textNPC5.text = "Rendez-vous dans la forêt";
            textNPC_Foret.text = "Félicitations, intrépide aventurier, pour avoir triomphé des défis et découvert les cinq gemmes éparpillées aux quatre coins du monde. Ton courage, ta perspicacité et ta détermination t'ont permis de rassembler ces joyaux mystiques, chacun renfermant un pouvoir unique et ancestral.";
        }
    }
}
