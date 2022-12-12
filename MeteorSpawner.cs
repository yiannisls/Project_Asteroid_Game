using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float spawnRatePerMinute = 30; // once it surpasses it, repeat
    public float spawnRateIncrement = 1; //Everytime i spawn a meteor, the next one is going to spawn faster.
    private float spawnNext = 0; //make sure the timestamp of my game.

    void Update()
    {
        if (Time.time > spawnNext) {// Timestamps in Unity. 
            spawnNext = Time.time + 60 / spawnRatePerMinute; // just an increment to make sure the spawn is not too fast for me
          //  spawnRatePerMinute += spawnRateIncrement;
            
            Instantiate(asteroidPrefab, transform.position, Quaternion.identity); // args = prefab , position, rotation
        }
    }
}
