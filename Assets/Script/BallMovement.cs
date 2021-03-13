using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public static float speed = 0.7f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
}
