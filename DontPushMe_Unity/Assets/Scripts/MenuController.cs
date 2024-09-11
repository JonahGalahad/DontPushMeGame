using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{

    public void ChangeOnCanvas (GameObject canvasMenu) {
        canvasMenu.SetActive (true);
    }
    public void ChangeOffCanvas (GameObject canvasMenu) {
        canvasMenu.SetActive(false);
    }
}
