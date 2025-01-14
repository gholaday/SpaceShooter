﻿using UnityEngine;
using System.Collections;

public class SceneChange : MonoBehaviour {

	public string sceneName;
	public bool clickToChange = true;
    public string button = "Fire1";

    public bool usePriorScene = false;
    public bool anyKey = false;
    public bool automaticChange = false;
    

	// Use this for initialization
	void Awake () {

        if(usePriorScene)
        {
            sceneName = InitializePriorScene.priorScene;
		
        }

       
	
	}
	
	void Start()
	{
		if(automaticChange)
		{
			Application.LoadLevel(sceneName);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
        if(anyKey && clickToChange)
        {
            if (Input.anyKey) Application.LoadLevel(sceneName);
        }
        else if(clickToChange && Input.GetButton(button))
		{
           
			Application.LoadLevel(sceneName);
		}


	}
}
