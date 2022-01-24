using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballSpawner : MonoBehaviour
{
    public Football footballPrefab;
    private void Start()
    {
        SpawnFootball();
    }
    public void SpawnFootball() { 
        Instantiate(footballPrefab);
    }
}
