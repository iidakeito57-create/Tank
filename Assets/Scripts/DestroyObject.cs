using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public GameObject effectPrefab;

// ★★追加
public GameObject effectPrefab2; // 2種類目のエフェクトを入れるための箱
public int objectHP;


    // このメソッドはコライダー同士がぶつかった瞬間に呼び出される
    private void OnTriggerEnter(Collider other)
    {
        // もしもぶつかった相手のTagにShellという名前が書いてあったならば（条件）
        if (other.CompareTag("Shell"))
        {
            // このスクリプトがついているオブジェクトを破壊する（thisは省略が可能）
            Destroy(this.gameObject);

            // ぶつかってきたオブジェクトを破壊する
            // otherがどこと繋がっているか考えてみよう！
            Destroy(other.gameObject);
        }
    }
}
