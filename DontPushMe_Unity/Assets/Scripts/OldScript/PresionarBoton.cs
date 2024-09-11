using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using FMODUnity;

public class PresionarBoton : MonoBehaviour
{
    public bool press = false;
    public int numScene;
    public FMODUnity.EventReference sound;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            press = true;
            //Debug.Log("presionado");
            RuntimeManager.PlayOneShot(sound);

            if (press = true)
            {
                SceneManager.LoadScene(numScene);
            }
        }
    }
}
