using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangementVersSceneInterieur : MonoBehaviour
{
    private LevelManager levelManager;

    [SerializeField] private InfoJoueur infoJoueur;

    // Start is called before the first frame update
    void Start()
    {
        levelManager = LevelManager.Instance;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            Debug.Log("test Player");
            if(gameObject.tag == "TempleGrec"){
                Debug.Log("test Temple");
                levelManager.LoadAsyncScene("SceneTemple");

            }
        }

        if(other.tag == "Player"){
            Debug.Log("test Player");
            if(gameObject.tag == "MaisonViking"){
                Debug.Log("test viking");
                levelManager.LoadAsyncScene("SceneViking");
                infoJoueur.inMaisonViking = true;
            }
        }

        if(other.tag == "Player"){
            Debug.Log("test Player");
            if(gameObject.tag == "VersExterieur"){
                Debug.Log("test exterieur");
                levelManager.LoadAsyncScene("SceneExterieur");
            }
        }
    }
}
