using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class ClassicGameManager : MonoBehaviour
{

    public TouchDetect touchDetect;
    public Button pauseButton;
    public float speedUpSeconds = 5f;

    void Start()
    {
        BallMovement.speed = .7f;
        StickMovement.speed = 1.6f;
        StartCoroutine("SpeedUp");
    }

    IEnumerator SpeedUp()
    {
        for (int i = 0; i < 80; i++)
        {
            BallMovement.speed += .03f;
            StickMovement.speed += .05f;
            TouchDetect.stickDelayTime -= .01f;
            Ball.delay -= .01f;
            yield return new WaitForSeconds(speedUpSeconds);
        }
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseButton.onClick.Invoke();
        }
    }

    public void GoBack()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        touchDetect.setPaused(true);
    }

    public void ResumeGame()
    {

        Time.timeScale = 1;
        Invoke("setPaused", .1f);
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void setPaused()
    {
        touchDetect.setPaused(false);
    }


}
