using UnityEngine;
using TMPro;

public class TagCounter : MonoBehaviour
{
    public string targetTag = "StackCube";
    public TMP_Text counterText;

    void Update()
    {
        int count = GameObject.FindGameObjectsWithTag(targetTag).Length / 2;

        counterText.text = "counter:" + count.ToString();
    }
}
