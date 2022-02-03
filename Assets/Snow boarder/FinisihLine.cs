using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinisihLine : MonoBehaviour
{

    [SerializeField] float timeDelay = 1f;
    [SerializeField] ParticleSystem finishEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", timeDelay);
            
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(1);
    }


}
