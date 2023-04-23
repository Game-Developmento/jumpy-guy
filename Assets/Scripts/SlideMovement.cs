using UnityEngine;

public class SlideMovement : MonoBehaviour
{
    public float slideDistance = 1.0f;
    public float slideSpeed = 1.0f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float x = startPos.x + Mathf.PingPong(Time.time * slideSpeed, slideDistance * 2.0f) - slideDistance;
        Vector3 newPos = new Vector3(x, transform.position.y, transform.position.z);

        transform.position = newPos;
    }
}
