using UnityEngine;

public class LoadImageOnClick : MonoBehaviour
{
    public LoadImageFromFile loadImg;
    Material mat;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadImageOnClickButton()
    {
        loadImg.SetImg();

    }
    
}
