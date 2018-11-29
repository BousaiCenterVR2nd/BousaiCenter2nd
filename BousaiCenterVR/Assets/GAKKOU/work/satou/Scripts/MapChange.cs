using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapChange : MonoBehaviour {

    public int trg = 2;

    //1階のマップのスプライト
    public Sprite f1;

    //2階のマップのスプライト
    public Sprite f2;

    SpriteRenderer sprRen;

    // Use this for initialization
    void Start() {

        sprRen = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update() {

        switch (trg) {
            case 2:
            sprRen.sprite = f2;
            break;

            case 1:
            sprRen.sprite = f1;
            break;

        }

    }
}
