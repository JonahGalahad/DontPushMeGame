using System.Collections;
using System.Collections.Generic;
using UnityEngine;
///using FMODUnity;

public class CharacterMove : MonoBehaviour
{
    //public FMODUnity.EventReference sound;
    public SpriteRenderer direccion;
    public float vel = 3f;
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * vel * Time.deltaTime;
            direccion.flipX = true;

           // RuntimeManager.PlayOneShot(sound);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * vel * Time.deltaTime;
            direccion.flipX = false;

           // RuntimeManager.PlayOneShot(sound);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * vel * Time.deltaTime;

          //  RuntimeManager.PlayOneShot(sound);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * vel * Time.deltaTime;

          //  RuntimeManager.PlayOneShot(sound);
        }
    }
}
