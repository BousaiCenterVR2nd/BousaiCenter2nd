﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour {

    //炎で死んだときに表示されるやつ
    [SerializeField]
    private Sprite fire;

    //煙で死んだときに表示されるやつ
    [SerializeField]
    private Sprite smoke;

    //バックドラフトで死んだときに表示されるやつ
    [SerializeField]
    private Sprite draft;

    SpriteRenderer sprRen;

    public static int num;

	// Use this for initialization
	void Start () {

        sprRen = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        
        SprChange();
	}

    void SprChange()
    {
        switch (num)
        {
            case 0:
                //炎で死んだとき
                sprRen.sprite = fire;
                break;
            case 1:
                //煙で死んだとき
                sprRen.sprite = smoke;
                break;
            case 2:
                //バックドラフトで死んだとき
                sprRen.sprite = draft;
                break;
            default:
                break;
        }
    }
}
