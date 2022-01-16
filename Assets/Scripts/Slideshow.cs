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
        nextSlide();
        nextSlide();
        rend.material.mainTexture = images[currImageIndex];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void nextSlide() {
        currImageIndex++;
        if (currImageIndex >= images.Length) {
            currImageIndex = 0;
        }
    }
    void previousSlide() {
        currImageIndex--;
        if (currImageIndex <= 0) {
            currImageIndex = images.Length;
        }
    }
}
