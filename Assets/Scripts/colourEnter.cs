using UnityEngine;
using UnityEditor.Events;
using UnityEngine.Events;

public class colourEnter : MonoBehaviour
{
    public UnityEvent enteredTrigger, exitedTrigger;
    public GameObject correctColour;
    //public TagHandle colourTag;

    public ExitDoor ExitDoor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //colourTag = gameObject.GetComponent<TagHandle>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == gameObject.tag)
        {
            enteredTrigger.Invoke();
            //Debug.Log("Correct Colour Entered");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == gameObject.tag)
        {
            exitedTrigger.Invoke();
        }
    }
}
