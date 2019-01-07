using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;

    public GameObject globalGameObject;

    public int scoreValue;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Boundary"))
        {
            return;
        }

        if (other.tag.Equals("Player"))
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
        }
        else
        {
            Instantiate(explosion, transform.position, transform.rotation);
            (FindObjectOfType(typeof(GlobalController)) as GlobalController).updateScore(scoreValue);
        }

        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
