using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalController : MonoBehaviour
{
    public GameObject asteroid;

    public int asteroidsPerWave;
    public float startWaitTime;
    public float waveWaitTime;
    public float asteroidWaitTime;

    public AsteroidPosition asteroidPosition;

    public Text scoreText;

    private int score;

    // Start is called before the first frame update
    void Start()
    {
        updateScore(0);
        StartCoroutine(spawnAsteroidWaves());
    }

    public void updateScore(int newScore)
    {
        score += newScore;
        scoreText.text = $"Score: {score}";
    }

    private IEnumerator spawnAsteroidWaves()
    {
        yield return new WaitForSeconds(startWaitTime);

        while (true)
        {
            for (int i = 0; i < asteroidsPerWave; i++)
            {
                spawnAsteroid();
                yield return new WaitForSeconds(asteroidWaitTime);
            }

            yield return new WaitForSeconds(waveWaitTime);
        }
    }

    private GameObject spawnAsteroid()
    {
        float asteroidX = Random.Range(asteroidPosition.xRange.min, asteroidPosition.xRange.max);
        return Instantiate(asteroid, new Vector3(asteroidX, asteroidPosition.y, asteroidPosition.z), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
