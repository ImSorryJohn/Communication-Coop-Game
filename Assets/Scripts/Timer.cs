using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField] private float timeLeft;
    [SerializeField] private Text timeText;
    private bool timerRunning = false;

    public UnityEvent timeUp;

    void Start()
    {
        timerRunning = true;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (timerRunning)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
            }

            else
            {
                //Debug.Log("Time Up");
                timerRunning = false;
                timeLeft = 0;
                timeUp.Invoke();
            }
        }

        DisplayTime(timeLeft);
    }

    void DisplayTime(float timeToShow)
    {
        float seconds = Mathf.FloorToInt(timeToShow % 60);
        float milliseconds = (timeToShow % 1) * 1000;

        timeText.text = string.Format("{0:00}:{1:000}", seconds, milliseconds);
    }
}
