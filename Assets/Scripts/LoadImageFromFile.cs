using System.IO;
using UnityEngine;

public class LoadImageFromFile : MonoBehaviour
{
    public Texture2D texture;
    string pathToImage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        using (StreamWriter sw = new StreamWriter(Application.dataPath + "/NewTextFile.txt", true))
        {
            //sw.WriteLine("C:\\Users\\Professional\\bw\\s.jpg");
        }
        using (StreamReader sr = new StreamReader(Application.dataPath + "/NewTextFile.txt"))
        {
            
            pathToImage = sr.ReadLine();
            
        }
        Debug.Log(pathToImage);
        if (File.Exists("C:\\Users\\Professional\\bw\\s.jpg"))
        {
            
            byte[] bytes = File.ReadAllBytes(pathToImage);
            texture = new Texture2D(2, 2);
            texture.LoadImage(bytes);
        }
        else
        {
            Debug.Log("Eror file not exist");
        }
    }

    public void SetImg()
    {
        GetComponent<Renderer>().material.SetTexture("_MainTex", texture);
        //GetComponent<Renderer>().material.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
