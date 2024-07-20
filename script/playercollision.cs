using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollision : MonoBehaviour
{
    public playerscript playerscript;
    public score score;
    public GameController gameController;
    public AudioSource audioSource;
    public AudioSource audioSource1;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "collectable")
        {
            audioSource.Play();
            score.Addscore(1);
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag=="obstacle")
        {
            audioSource1.Play();
            gameController.GameOver();
            playerscript.enabled = false;
        }
    }
}