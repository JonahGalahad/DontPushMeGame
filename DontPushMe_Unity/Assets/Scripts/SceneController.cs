using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void ChangeScene(int numScene) {
        SceneManager.LoadScene(numScene);
    }
    public void CloseApp() {
        Application.Quit();
    }
}
