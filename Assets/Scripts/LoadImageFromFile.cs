using System.IO;
using UnityEngine;

public class LoadImageFromFile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        using (StreamWriter sw = new StreamWriter(Application.dataPath + "/NewTextFile.txt", true))
        {
            sw.WriteLine("This is a new text file!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
