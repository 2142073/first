using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public static EnemyHealth instance;

    void Awake()
    {
        instance = this;
    }
    public int maxHealth = 100; // 最大ヒットポイント
    private int currentHealth; // 現在のヒットポイント

    void Start()
    {
        currentHealth = maxHealth;
    }

    // ダメージを受けるメソッド
    public void TakeDamage(int damageAmount)
    {
        Debug.Log("敵にダメージを与えた");
        currentHealth -= damageAmount;
        Debug.Log("残りHP: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die(); // 敵が倒れた場合の処理をここに追加
        }
    }

    void Die()
    {
        Debug.Log("敵が倒れた");
        // 敵が倒れたときの処理を記述
        Destroy(gameObject); // 例: ゲームオブジェクトを削除
    }
}
