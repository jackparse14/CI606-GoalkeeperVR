using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToGoalkeeperButton : MonoBehaviour
{
    public void OnPointerEnter()
    {
        SceneManager.LoadScene(1);
    }
}
