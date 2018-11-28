using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapChange : MonoBehaviour {

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

    }

    void OnTriggerEnter(Collider collider) {

        if (collider.gameObject.tag == "Floor01") {
            sprRen.sprite = f1;
        }

        if (collider.gameObject.tag == "Floor02") {
            sprRen.sprite = f2;
        }

    }
}
