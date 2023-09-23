using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject ballPrefab; // プレハブとして設定するボールのゲームオブジェクト
    public float ballSpeed = 10f; // ボールの速度

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LaunchBall();
        }
    }

    void LaunchBall()
    {
        // ボールのインスタンスを作成
        GameObject newBall = Instantiate(ballPrefab, transform.position, Quaternion.identity);

        // ボールの Rigidbody2D コンポーネントを取得
        Rigidbody2D rb = newBall.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            // オブジェクトの向いている方向にボールを発射
            Vector2 direction = new Vector2(-this.gameObject.transform.up.x, -this.gameObject.transform.up.y);
             rb.velocity = direction * ballSpeed;
        }
    }

}
