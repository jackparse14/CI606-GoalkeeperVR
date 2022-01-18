using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slideshow : MonoBehaviour
{
    public Texture[] images;
    private int currImageIndex = 0;
    private MeshRenderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponentInChildren<MeshRenderer>();
        DisplaySlide();
        gameObject.SetActive(false);
    }
    public void NextSlide() {
        currImageIndex++;
        if (currImageIndex >= images.Length) {
            currImageIndex = 0;
        }
        DisplaySlide();
    }
    public void PreviousSlide() {
        currImageIndex--;
        if (currImageIndex < 0) {
            currImageIndex = images.Length;
        }
        DisplaySlide();
    }
    private void DisplaySlide() {
        rend.material.mainTexture = images[currImageIndex];
    }
}
