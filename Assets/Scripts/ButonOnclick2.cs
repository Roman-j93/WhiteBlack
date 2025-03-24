using System;
using UnityEngine;

public class ButonOnclick2 : MonoBehaviour
{
    public GameObject TargetSprite;
    public Shader NormalColor;
    public Shader WrongBlackWhite;
    public Shader PalBlackWhite;
    int TypeBlackWhite = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        TargetSprite.GetComponent<Renderer>().material.SetInt("Type", 0);
        GetComponent<Shader>();
        OnClickButton();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickButton()
    {
        Debug.Log("asd");
        if (TypeBlackWhite == 3) TypeBlackWhite = 0;
       
        switch(TypeBlackWhite)
        {
            case 0:
                TargetSprite.GetComponent<Renderer>().material.shader = NormalColor;
                break;

            case 1:
                TargetSprite.GetComponent<Renderer>().material.shader = WrongBlackWhite;
                break;
            case 2:
                TargetSprite.GetComponent<Renderer>().material.shader = PalBlackWhite;
                break;
            default:
                break;

        }
        TypeBlackWhite++;
    }
}
