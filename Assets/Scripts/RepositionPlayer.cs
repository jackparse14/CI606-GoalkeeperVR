using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepositionPlayer : MonoBehaviour
{
    private GameObject player;
    [SerializeField]
    private Vector3 startPos;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        Debug.Log(player);
        player.transform.position = startPos;
    }
}
