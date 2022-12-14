using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delayFinish = 1f;
    [SerializeField] ParticleSystem crashParticle;
    [SerializeField] AudioClip crashSFX;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<PlayerController>().DisableControls();
        crashParticle.Play();
        GetComponent<AudioSource>().PlayOneShot(crashSFX);
        Invoke("ReloadScene", delayFinish);
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(0);

    }
}
