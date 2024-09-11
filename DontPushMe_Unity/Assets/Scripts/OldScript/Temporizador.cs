using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Temporizador : MonoBehaviour
{
    [SerializeField] 
    int min, seg;
    [SerializeField] 
    Text tiempo;

    private float restante;
    private bool tiempoEnMarcha;
    public int numScene;

    private void Awake() 
    {
        restante = (min*60)+seg;
        tiempoEnMarcha = true;
    }

    
    void Update()
    {
        if (tiempoEnMarcha)
        {
            restante -= Time.deltaTime;
            if (restante < 1)
            {
                tiempoEnMarcha = false;

                SceneManager.LoadScene(numScene);
            }
            int tiempoMin= Mathf.FloorToInt(restante / 60);
            int tiempoSeg= Mathf.FloorToInt(restante % 60);
            tiempo.text = string.Format("{00:00}:{01:00}",tiempoMin,tiempoSeg);
        }    
    }
}
