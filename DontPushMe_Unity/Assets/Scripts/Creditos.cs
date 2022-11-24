using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creditos : MonoBehaviour
{
    public Animator transi;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("WaitFOrSecond",14);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WaitFOrSecond()
    {
        transi.SetBool("stop",true);

    }
}