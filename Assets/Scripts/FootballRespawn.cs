using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballRespawn : MonoBehaviour
{
    private FootballSpawner ballSpawn;
    private void Start()
    {
        ballSpawn = FindObjectOfType<FootballSpawner>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Football")) {
            Destroy(collision.gameObject);
            ballSpawn.SpawnFootball();
        }
    }
}
