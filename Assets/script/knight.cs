using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knight : MonoBehaviour
{
    //
    public int rotation = 1;

    void Start()
    {
        
    }


    void Update()
    {
        //毎秒x軸に１ずつ移動する
        transform.Translate(1 * Time.deltaTime, 0, 0);


    }
}