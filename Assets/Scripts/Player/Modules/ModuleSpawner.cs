using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuleSpawner : MonoBehaviour {

    // NOTE: Whenever a module is parented to a player we must lower the counter
    public static int modulesCounter = 0; // Use to limit number of modules that can be spawned

    [SerializeField] private GameObject[] modules;
    [SerializeField] private float spawnRange = 20;
    [SerializeField] private int maxModulesToSpawn = 20;

    // Use this for initialization
    void Start () {
        randomizeSpawnPosition();

        // Spawn a module every few seconds
        InvokeRepeating("Spawn", 5, 5);
    }

    // Update is called once per frame
    private void Spawn()
    {
        if (modulesCounter < maxModulesToSpawn)
        {
            // Load random module prefab into scene
            PhotonNetwork.Instantiate(modules[Random.Range(0, modules.Length)].name,
                        transform.position,
                        Quaternion.identity, 0);

            modulesCounter++;
        }

        randomizeSpawnPosition();
    }

    private void randomizeSpawnPosition()
    {
        transform.position += new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), 0);

        if (transform.position.x < -spawnRange)
        {
            transform.position += new Vector3(spawnRange, 0, 0);
        }
        if (transform.position.x > spawnRange)
        {
            transform.position -= new Vector3(spawnRange, 0, 0);
        }

        if (transform.position.y < -spawnRange)
        {
            transform.position += new Vector3(0, spawnRange, 0);
        }
        if (transform.position.y > spawnRange)
        {
            transform.position -= new Vector3(0, spawnRange, 0);
        }
    }
}
