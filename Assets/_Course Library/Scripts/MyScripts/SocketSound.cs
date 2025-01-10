using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketSound : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip entersound;
    public AudioClip exitsound;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayEnterSound()
    {
        audioSource.PlayOneShot(entersound);
    }

    public void PlayExitSound()
    {
        audioSource.PlayOneShot(exitsound);
    }
}
