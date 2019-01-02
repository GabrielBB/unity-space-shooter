using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour
{
    // Start is called before the first frame update

    public float rotationSpeed;

    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.onUnitSphere * rotationSpeed;
    }
}
