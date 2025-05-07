using UnityEngine;

public class spawnzone : MonoBehaviour
{

    public GameObject stackCubePrefab;
    public Transform spawnPoint;
    public float moveSpeed = 2f;
    public float limit = 1f;
    public Vector3 moveDirection = Vector3.forward;

    private Vector3 startPos;


    void Start()
    {
        startPos = transform.position;


    }

    void Update()
    {
        transform.position = startPos + moveDirection * Mathf.Sin(Time.time * moveSpeed) * limit;

        if (Input.GetMouseButtonDown(0))
        {
            StartFalling();
        }
    }

    private void StartFalling()
    {
        Vector3 spawnOffset = spawnPoint.position + Vector3.up * 1f;

        GameObject newCube = Instantiate(stackCubePrefab, spawnOffset, Quaternion.identity);
        newCube.transform.parent = null; // ←これで親を切る！


        Rigidbody rb = newCube.GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogWarning("生成されたCubeにRigidbodyがついてません！");
        }
        else
        {
            Debug.Log("Rigidbodyあり。UseGravity: " + rb.useGravity);
        }
    }





}
