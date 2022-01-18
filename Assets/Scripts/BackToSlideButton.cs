using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToSlideButton : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    public void OnPointerEnter()
    {
        SceneManager.LoadScene(0);
    }
}
