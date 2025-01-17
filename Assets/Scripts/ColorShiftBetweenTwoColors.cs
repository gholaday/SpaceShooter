﻿using UnityEngine;
using System.Collections;

public class ColorShiftBetweenTwoColors : MonoBehaviour {

    public bool is2d = false;

    public string shaderName = "Standard";

    public Color color1;
    public Color color2;

    public float speed;

    float change = 0;

    bool increasing = true;

    MeshRenderer mr;
    SpriteRenderer sr;

    Color color3;

	// Use this for initialization
	void Start () {

        if(is2d)
        {
            sr = GetComponent<SpriteRenderer>();

        }
        else
        {
            mr = GetComponent<MeshRenderer>();
            mr.material.shader = Shader.Find(shaderName);
            mr.material.SetColor("_Color", color1);
        }
        
	
	}
	
	// Update is called once per frame
	void Update () {

        if(change >= 1)
        {
            increasing = false;
        }

        if (change <= 0)
        {
            increasing = true;
        }



        if(increasing)
        {
            change += speed * Time.deltaTime;
            
        }
        else
        {
            change -= speed * Time.deltaTime;
            
        }

        color3 = Color.Lerp(color1, color2, change);

        if (is2d)
        {
            sr.color = color3;
        }
        else
        {
            mr.material.SetColor("_Color", color3);
        }
        
	
	}
}
