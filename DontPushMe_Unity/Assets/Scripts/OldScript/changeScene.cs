using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public int numScene;
    public void LoadScene()
    {
        SceneManager.LoadScene(numScene);
    }
}
