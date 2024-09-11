using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarCuadro : MonoBehaviour
{
    private bool pres = false;
    public GameObject cuadro;
    public void showImage()
    {
        cuadro.SetActive(true);
    }
    public void BackToPlay()
    {
        cuadro.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        pres = true;
        if (pres = true && Input.GetKey(KeyCode.E))
        {

            showImage();

        }
        if (Input.GetKey(KeyCode.Escape))
        {
            BackToPlay();
        }
    }
}