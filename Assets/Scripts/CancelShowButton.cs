using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelShowButton : MonoBehaviour
{
    [SerializeField]
    private GameObject slideMenu;
    [SerializeField]
    private GameObject ss;
    [SerializeField]
    private bool isCancelButton;
    private SoundManager sm;
    private void Start()
    {
        sm = FindObjectOfType<SoundManager>();
    }
    public void OnPointerEnter()
    {
        if (isCancelButton)
        {
            slideMenu.SetActive(true);
            ss.SetActive(false);
        }
        else
        {
            slideMenu.SetActive(false);
            ss.SetActive(true);
        }
        sm.PlayClick();
    }
}

