using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // 触れたオブジェクトに "StackCube" タグがついていたら
        if (collision.gameObject.CompareTag("StackCube"))
        {
            Debug.Log("StackCube が床に触れた！ゲームオーバー！");
            SceneManager.LoadScene("GameOver");
        }
    }
}
