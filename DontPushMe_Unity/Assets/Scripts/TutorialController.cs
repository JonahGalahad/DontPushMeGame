using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialController : MonoBehaviour
{
    [SerializeField] private GameObject msj,msj2;
    private bool isMov;
    //[SerializeField] private string GO_tag;

    private void Update() {
        
        if (Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.S) || Input.GetKeyDown (KeyCode.D) ){
            msj2.SetActive(false);
            msj.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.E)){
            msj.SetActive(false);
        }
    }

    /*private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Imagen") {
            msj.SetActive(true);
        }
    }*/
}
