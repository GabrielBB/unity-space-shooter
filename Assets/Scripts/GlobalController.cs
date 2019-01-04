using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalController : MonoBehaviour
{
    public GameObject asteroid;

    public AsteroidPosition asteroidPosition;

    // Start is called before the first frame update
    void Start()
    {
        float asteroidX = Random.Range(asteroidPosition.xRange.min, asteroidPosition.xRange.max);
        Instantiate(asteroid, new Vector3(asteroidX, asteroidPosition.y, asteroidPosition.z), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
