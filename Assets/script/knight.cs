using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knight : MonoBehaviour
{
    int attack = 5;
    int attackRange = 100;
    float attackInterval = 1.5f; 
   
    void Start()
    {
        //自分の座標を取得
        Vector3 pos = transform.position;
        //周囲１マスのenemyタグを持っている敵を取得
        Collider[] hitColliders = Physics.OverlapSphere(pos, attackRange);
        //もし敵がいたら（敵を見つけた）出力する
        if (hitColliders.Length > 0)
        {
            Debug.Log("敵を見つけた");
        }
    }


    void Update()
    {
        
    }
}
