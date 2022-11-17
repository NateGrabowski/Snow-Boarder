using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delayFinish = 1f;
    [SerializeField] ParticleSystem crashParticle;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        crashParticle.Play();
        Invoke("ReloadScene", delayFinish);
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);

    }
}
