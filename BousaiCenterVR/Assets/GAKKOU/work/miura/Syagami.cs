using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class Syagami : MonoBehaviour
{
    //変数定義
    public bool ONE;           //1回だけ処理のフラグ
    public bool smokeFlg;    //煙範囲内にいるかどうか
    public Vector3 startPos;   //初期位置の代入する変数
    public Vector3 pos;        //常に更新する座標

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "smokeDamage")
        {//otherには入ってきたオブジェクトが渡されているのでtagを比較しています。
            smokeFlg = true;
           // Debug.Log("煙");
        }


    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "smokeDamage")
        {//otherには入ってきたオブジェクトが渡されているのでtagを比較しています。
            smokeFlg = false;
            // Debug.Log("煙");
        }
    }
    
    // Use this for initialization
    void Start()
    {
        ONE = true;
        smokeFlg = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("しゃがみ時"+startPos.y *0.98);
        Debug.Log("スタート時"+startPos);
        if (ONE)
        {
            startPos = transform.position;
            ONE = false;

        }
        pos = transform.position;
        
        if (smokeFlg == true)
        {
            if (pos.y >= startPos.y * 0.98)
            {
                FindObjectOfType<ImageEffectControl>().damageone = true;
                FindObjectOfType<ImageEffectControl>().recovery = false;
            }
            else
            {
                FindObjectOfType<ImageEffectControl>().recovery = true;
                FindObjectOfType<ImageEffectControl>().damageone = false;
            }
        }
        else
        {
            FindObjectOfType<ImageEffectControl>().recovery = true;
            FindObjectOfType<ImageEffectControl>().damageone = false;
        }

      //  Debug.Log("startPos"+startPos);
      //  Debug.Log(pos);
    }
}
