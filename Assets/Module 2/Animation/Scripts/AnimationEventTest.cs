using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventTest : MonoBehaviour
{
    public AudioClip stepSound;
    Animator anim;
    AudioSource audioSource;

    private void Start()
    {
        if (!anim)
        {
            anim = GetComponent<Animator>();
        }

        if (!audioSource)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    public void Steps()
    {
        audioSource.PlayOneShot(stepSound);
    }
}
