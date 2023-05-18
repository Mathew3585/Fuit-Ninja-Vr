using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float velocityIntencity;
    public GameObject[] prefabs;
    public Transform[] spawnPoint;
    public float spawnTimer = 2;
    private float Timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if(Timer > spawnTimer)
        {
            Transform randomPoint = spawnPoint[Random.Range(0, spawnPoint.Length)];
            GameObject randomsPrefabs = prefabs[Random.Range(0, prefabs.Length)];

            GameObject spawnedPrefabs = Instantiate(randomsPrefabs, randomPoint.position, randomPoint.rotation);

            Timer -= spawnTimer;

            Rigidbody rb = spawnedPrefabs.GetComponent<Rigidbody>();
            rb.velocity = randomPoint.forward * velocityIntencity;
        }
    }
}
