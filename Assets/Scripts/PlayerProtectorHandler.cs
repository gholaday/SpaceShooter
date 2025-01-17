﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerProtectorHandler : MonoBehaviour {

    
    public GameObject obj;
    public bool spawn = false;
    public int numAlive = 0;

	// Use this for initialization
	void Start () {

        StartCoroutine(Spawn());
        
	}
	

    IEnumerator Spawn()
    {
        
        if(spawn && numAlive < 4)
        {
            spawn = false;
            numAlive++;
            GameObject go = (GameObject)Instantiate(obj, transform.position, Quaternion.identity);
            go.GetComponent<Protector>().target = this.gameObject.transform;
            
        }
        yield return new WaitForSeconds(.25f);
        
        StartCoroutine(Spawn());
    }

    
}
