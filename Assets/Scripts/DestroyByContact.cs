using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Boundary"))
        {
            return;
        }

        Instantiate(explosion, transform.position, transform.rotation);

        if (other.tag.Equals("Player"))
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
        }

        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
