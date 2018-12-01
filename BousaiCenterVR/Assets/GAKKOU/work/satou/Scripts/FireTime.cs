using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTime : MonoBehaviour {

    //照射しているか
    public bool use = false;

    //照射してられる時間
    public int time;

    //消火器本体
    [SerializeField]
    private GameObject body;
    //消火器の先っぽ
    [SerializeField]
    private GameObject hose;
    //マップ
    [SerializeField]
    private GameObject map;
    //置いてある消火器
    [SerializeField]
    private GameObject[] okimono = new GameObject[1];

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        Time();

    }

    void Time()
    {
        if (use == true)
        {
            time--;
        }

        if (time <= 0)
        {
            time = 300;
            map.SetActive(true);
            okimono[0].SetActive(true);
            okimono[1].SetActive(true);
            body.SetActive(false);
            hose.SetActive(false);
        }
    }
}
