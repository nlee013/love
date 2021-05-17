using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footstep : MonoBehaviour
{
    [SerializeField] private CharacterController cc;
    [SerializeField] private AudioSource audioSource;
    //AudioClip audioClip;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //audioClip = GetComponent<AudioClip>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((cc.isGrounded == true && cc.velocity.magnitude > 2f))
        { 
            if (audioSource.isPlaying == false)
            {
                audioSource.Play();
            }
        }
    }
}
