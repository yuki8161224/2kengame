using UnityEngine;

public class OpenURLOnClick : MonoBehaviour
{
    public string url = "https://x.com/project_of_2ken?s=21";

    void OnMouseDown()
    {
        Application.OpenURL(url);
    }
}
