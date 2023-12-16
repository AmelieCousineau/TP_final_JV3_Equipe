using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextNpc : MonoBehaviour
{
    [SerializeField] private GameObject canvas;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player"){
            canvas.SetActive(true);
           
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag == "Player"){
           canvas.SetActive(false);
        }
    }
}
