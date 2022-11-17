using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float delayFinish = 0.5f;
    [SerializeField] ParticleSystem finishEffect;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        finishEffect.Play();
        Invoke("ReloadScene", delayFinish);
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);

    }
}
