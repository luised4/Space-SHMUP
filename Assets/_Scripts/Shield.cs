﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour {
    [Header("Set in Inspector")]
    public float rotationsPerSecond = 0.1f;
    [Header("Set Dynamically")]
    public int levelShown = 0;
    Material mat;
    // Use this for initialization
    void Start () {
         mat = GetComponent<Renderer>().material;
    }
	
	// Update is called once per frame
	void Update () {

        //read the current shield level from the hero singleton
        int currLevel = Mathf.FloorToInt(Hero.S.shieldLevel);
        //if this is different from levelShown
        if (levelShown != currLevel)
        {
            levelShown = currLevel;
            Material mat = this.GetComponent<Renderer>().material;
            //adjust the texture offset to show different shield level
            mat.mainTextureOffset = new Vector2(0.2f * levelShown, 0);
        }//end if statement
        //rotate the shield a bit every second
        float rZ = (rotationsPerSecond * Time.time * 360) % 360f;
        transform.rotation = Quaternion.Euler(0, 0, rZ);
    }
    private void OnTriggerEnter(Collider other)
    {
        print("Triggered:" + other.gameObject.name);
    }
}
