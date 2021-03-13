using UnityEngine;

public class StickMovement : MonoBehaviour
{

    public static float speed = 1.6f;
    public static ScoreCounter scoreCount;
    public GameObject stickPopSound;
	public GameObject healSound;
    private int sound;
    private LifeControl life;

    // Use this for initialization
    void Start()
    {
        life = FindObjectOfType<LifeControl>();
        sound = PlayerPrefs.GetInt("sound");
        scoreCount = FindObjectOfType<ScoreCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "redball"){
            life.IncreaseLife();
            scoreCount.heal(other.gameObject);
            Destroy(other.gameObject);
			if (sound == 0)
			{
				GameObject heal = Instantiate(healSound, this.transform);
				Destroy(heal, 3);
			}
		}
        if (other.gameObject.tag == "ball")
        {
            scoreCount.AddScore(1);
            scoreCount.explode(other.gameObject);
            Destroy(other.gameObject);
            if (sound == 0)
            {
                GameObject sound = Instantiate(stickPopSound, this.transform);
                Destroy(sound, 1);
            }


        }
     
    }
}
