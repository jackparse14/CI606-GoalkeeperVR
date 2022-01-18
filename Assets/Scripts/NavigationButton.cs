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
    [SerializeField] private bool isNextButton;
    void Start()
    {
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
    }
    public void OnPointerExit()
    {
        rend.material = exitMat;
    }
}
