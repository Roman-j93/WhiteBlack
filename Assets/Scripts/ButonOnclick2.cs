using System;
using UnityEngine;

public class ButonOnclick2 : MonoBehaviour
{
    public GameObject WhiteBlackShader;
    int TypeBlackWhite = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        WhiteBlackShader.GetComponent<Renderer>().material.SetInt("Type", 0);
        GetComponent<Shader>();
        //OnClickButton();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickButton()
    {
        Debug.Log("asd");
        if (TypeBlackWhite == 3) TypeBlackWhite = 1;
        int TypeForShader = TypeBlackWhite + 1;
        WhiteBlackShader.GetComponent<Renderer>().material.SetInt("Type", TypeForShader);
    }
}
