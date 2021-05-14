using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footstep : MonoBehaviour
{
    CharacterController cc;
    //AudioSource audioSource;
    //AudioClip audioClip;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        //audioSource = GetComponent<AudioSource>();
        //audioClip = GetComponent<AudioClip>();
    }

    // Update is called once per frame
    void Update()
    {
        if(cc.isGrounded == true && cc.velocity.magnitude > 2f && GetComponent<AudioSource>().isPlaying == false)
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
