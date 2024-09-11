using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorBottomRandom : MonoBehaviour
{
    public GameObject genController;
    //public List<GameObject> genObject = new List<GameObject>();
    public List<GameObject> objeto;

    public bool random;
    void Start()
    {
        int index = Random.RandomRange(0,2);
        Instantiate(objeto[index],genController.transform);
    }

    // Update is called once per frame
    void Update()
    {
        //SpawnObjet();
    }

/*    public void SpawnObjet()
    {
        int index = random ? Random.Range(0, genObject.Count) : 0;

        if (genObject.Count < 0)
        {
            Instantiate(genObject[index], genController.transform);    
        }
        
    }*/
}
