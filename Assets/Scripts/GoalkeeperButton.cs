using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalkeeperButton : MonoBehaviour
{
    public void OnPointerEnter()
    {
        SceneManager.LoadScene(1);
    }
}
