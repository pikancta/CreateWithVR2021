using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip DestroySound;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Destroyer"))
        {
            audioSource.PlayOneShot(DestroySound);
            Destroy(gameObject);
        }
    }

}
