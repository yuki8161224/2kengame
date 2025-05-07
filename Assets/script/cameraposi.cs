using UnityEngine;

public class cameraposi : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        if (target != null)
        {
            Vector3 targetPos = transform.position;
            targetPos.y = target.position.y - 69;

            transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * 3f);
        }
    }

}
