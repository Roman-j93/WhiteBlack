using System;
using UnityEngine;

public class ButonOnclick2 : MonoBehaviour
{
    public GameObject TargetSprite;
    public Shader NormalColor;
    public Shader WrongBlackWhite;

    Material cashMat;
    int TypeBlackWhite = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        cashMat = TargetSprite.GetComponent<Renderer>().material;
        //OnClickButton();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickButton(int TypeShade)
    {
       
        switch(TypeShade)
        {
            case 0:
                cashMat.shader = NormalColor;
                break;

            case 1:
                cashMat.shader = WrongBlackWhite;
                cashMat.SetFloat("_RatioR", 0.333f);
                cashMat.SetFloat("_RatioG", 0.333f);
                cashMat.SetFloat("_RatioB", 0.333f);
                break;
            case 2:
                cashMat.shader = WrongBlackWhite;
                cashMat.SetFloat("_RatioR", 0.299f);
                cashMat.SetFloat("_RatioG", 0.587f);
                cashMat.SetFloat("_RatioB", 0.114f);
                break;

            case 3:
                cashMat.shader = WrongBlackWhite;
                cashMat.SetFloat("_RatioR", 0.216f);
                cashMat.SetFloat("_RatioG", 0.7125f);
                cashMat.SetFloat("_RatioB", 0.0722f);
                break;

            default:
                break;

        }
        TypeBlackWhite++;
    }
    
}
