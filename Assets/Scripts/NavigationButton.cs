using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationButton : MonoBehaviour
{
    private Material exitMat;
    [SerializeField]
    private Material enterMat;
    public Slideshow ss;
    private Renderer rend;
    private SoundManager sm;
    [SerializeField] private bool isNextButton;
    void Start()
    {
        sm = FindObjectOfType<SoundManager>();
        rend = GetComponent<Renderer>();
        exitMat = rend.material;
    }
    public void OnPointerEnter()
    {
        rend.material = enterMat;
        if (isNextButton)
        {
            ss.NextSlide();
        }
        else {
            ss.PreviousSlide();
        }
        sm.PlayClick();
    }
    public void OnPointerExit()
    {
        rend.material = exitMat;
    }
}
