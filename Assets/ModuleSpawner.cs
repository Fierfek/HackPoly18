using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuleSpawner : MonoBehaviour {

    [SerializeField] private GameObject[] modules;

	// Use this for initialization
	void Start () {
        // Spawn a module every few seconds
        InvokeRepeating("Spawn", 10, Random.Range(10.0f, 15.0f));
    }

    // Update is called once per frame
    private void Spawn()
    {
        // Load random module prefab into scene
        Instantiate(modules[Random.Range(0, modules.Length)],
                    transform.position,
                    Quaternion.identity);

        randomizeSpawnPosition();
    }

    private void randomizeSpawnPosition()
    {
        //NEEDS UPDATING, SPAWN WITHIN DEATH SPHERE
        transform.position += new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), 0);
    }
}
