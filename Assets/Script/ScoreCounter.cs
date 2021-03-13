using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{

    public TextMeshProUGUI smashText;
    public static int smashNumber;
    public GameObject explosion;
    public GameObject healing;

    // Use this for initialization
    void Start()
    {
        smashNumber = 0;
        smashText.text = "Score: 0";
    }

    public void AddScore(int value)
    {
        smashNumber += value;
        smashText.text = "Score: " + smashNumber;
    }

    public void explode(GameObject ball)
    {

        Instantiate(explosion, ball.transform.position, ball.transform.rotation);
        
    }
    public void heal(GameObject redball)
    {
        Instantiate(healing, redball.transform.position, redball.transform.rotation);
    }
}
