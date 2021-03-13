using UnityEngine;

public class redball : MonoBehaviour
{

    public GameObject redbaall;
    public static float delay;
    private float nextSpawn;

    void Start()
    {
        delay = 3f;
        nextSpawn = Time.time + 4.5f;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + delay;
            Instantiate(redbaall, transform.position, Quaternion.Euler(0, 0, Random.Range(0, 360)));
        }
    }
}
