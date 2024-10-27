using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip coinCollectSound; // Звук сбора монеты
    public AudioClip objectCollisionSound; // Звук столкновения с объектом
    public AudioClip leftClickSound; // Звук левой кнопки мыши
    public AudioClip rightClickSound; // Звук правой кнопки мыши
    public AudioClip spacebarSound; // Звук пробела

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayCoinCollectSound()
    {
        audioSource.PlayOneShot(coinCollectSound);
    }

    public void PlayObjectCollisionSound()
    {
        audioSource.PlayOneShot(objectCollisionSound);
    }

    public void PlayLeftClickSound()
    {
        audioSource.PlayOneShot(leftClickSound);
    }

    public void PlayRightClickSound()
    {
        audioSource.PlayOneShot(rightClickSound);
    }

    public void PlaySpacebarSound()
    {
        audioSource.PlayOneShot(spacebarSound);
    }
}
