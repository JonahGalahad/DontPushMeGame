using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class AudioExecute : MonoBehaviour
{
    [SerializeField]
    public FMODUnity.EventReference audio;
    public void PlaySoundEvent()
    {
        RuntimeManager.PlayOneShot(audio);
    }
}
