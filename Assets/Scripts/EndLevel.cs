using UnityEngine;
using UnityEngine.Events;

public class EndLevel : MonoBehaviour
{
    public UnityEvent enteredTrigger;
    public int endedCount = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Red") || collision.CompareTag("Blue") || collision.CompareTag("Green") || collision.CompareTag("Yellow"))
        {
            //enteredTrigger.Invoke();
            collision.gameObject.SetActive(false);
            endedCount += 1;
        }
    }

    private void FixedUpdate()
    {
        if (endedCount == 4)
        {
            Debug.Log("Congrats");
            enteredTrigger.Invoke();
        }
    }
}
