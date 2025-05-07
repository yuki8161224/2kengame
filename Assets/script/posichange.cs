using UnityEngine;

public class posichange : MonoBehaviour
{
    private int clickCount = 0;
    private spawnzone spawnZoneScript;

    void Start()
    {
        // spawnzoneスクリプトを取得
        spawnZoneScript = GetComponent<spawnzone>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickCount++;
            Debug.Log("クリック回数: " + clickCount);

            if (clickCount >= 4)
            {
                Vector3 newPos = transform.position;
                newPos.y += 2f;
                transform.position = newPos;

                if (spawnZoneScript != null)
                {
                    // spawnzoneのstartPosも更新して動く位置を反映
                    typeof(spawnzone)
                        .GetField("startPos", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                        .SetValue(spawnZoneScript, newPos);
                }

                Debug.Log("Y座標を上げました: " + transform.position);
            }
        }
    }
}
