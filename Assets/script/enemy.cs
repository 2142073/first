using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public static enemy instance;
    private Rigidbody2D rb;
    private float speed = 30f;
    public int x = 1;
    public int y = 0;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //毎秒x軸に１ずつ移動する
        transform.Translate(x * Time.deltaTime, y * Time.deltaTime, 0);
    }

    void Update()
    {

    }
    public void RightMove()
    {
        Debug.Log("右");
        x = 1;
        y = 0;
    }
    public void LeftMove()
    {
        Debug.Log("左");
        x = -1;
        y = 0;
    }
    public void UpMove()
    {
        Debug.Log("上");
        x = 0;
        y = 1;
    }
    public void DownMove()
    {
        Debug.Log("下");
        x = 0;
        y = -1;
    }

}