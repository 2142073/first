using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knight : MonoBehaviour
{
    int attack = 5;
    int attackRange = 100;
    float attackInterval = 1.5f;
    bool enemyCheck = false;

    void Start()
    {
        //attackRange内にenemyのタグを持つ敵がいるかどうかを確認する
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, attackRange);
        //enemyのタグを持つ敵がenemyCheckをtrueにする
        foreach (Collider hitCollider in hitColliders)
        {
            if (hitCollider.tag == "enemy")
            {
                enemyCheck = true;
            }
        }
        if (enemyCheck == true)
        {
            Debug.Log("敵がいる");

        }
    }


    void Update()
    {

    }
}