using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        int BSMCount = FindObjectsOfType<BackgroundSoundManager>().Length;
        if (BSMCount > 1)
        {
            Restart();
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Restart()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
