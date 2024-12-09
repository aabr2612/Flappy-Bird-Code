using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed;
    public float deadZone;
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe Destroyed");
            Destroy(gameObject);
        }
    }
}
