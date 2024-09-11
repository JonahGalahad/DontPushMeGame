using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneInitial : MonoBehaviour
{
    [SerializeField] private int numScene;
    void Update()
    {
        ChangeToMenu();
    }
    public void ChangeToMenu() {
        if (Input.GetKeyDown(KeyCode.Return)) {
            SceneManager.LoadScene(numScene);
        }
    }
}
