using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventTest : MonoBehaviour
{
    public AudioClip stepSound;
    public AudioClip shootSound;
    public AudioClip aimSound;
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

    public void StepsSound()
    {
        audioSource.PlayOneShot(stepSound);
    }

    public void AimSound()
    {
        audioSource.PlayOneShot(aimSound);
    }

    public void ShootSound()
    {
        audioSource.PlayOneShot(shootSound);
    }
}
