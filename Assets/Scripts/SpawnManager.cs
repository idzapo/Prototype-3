using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private PlayerController playerControllerScript;

    private Vector3 spawnPos = new Vector3(27, 0, 0);

    private float startDelay = 1.5f;
    private float repeatRate = 2;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);

        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        //Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);

        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
