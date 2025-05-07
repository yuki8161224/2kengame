using UnityEngine;

public class yajirusiposi : MonoBehaviour
{
    public Transform target;

    void Update()
    {

        if (target != null)
        {
            Vector3 currentPos = transform.position;


            currentPos.z = target.position.z;
            currentPos.y = target.position.y + 2;

            transform.position = currentPos;
        }
    }

}
