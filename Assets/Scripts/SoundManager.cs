using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private static  SoundManager _instance;

    public static SoundManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<SoundManager>();
            }

            return _instance;
        }
    }

    public AudioClip CoinCollectSound;

    public void CoinSound()
    {
        AudioSource.PlayClipAtPoint(CoinCollectSound, transform.position);
    }
}
