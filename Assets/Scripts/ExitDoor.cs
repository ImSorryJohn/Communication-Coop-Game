using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    public int count = 0;
    public GameObject exitDoor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void ChangeCount(int change)
    {
        count += change;
        //print(count);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        //Debug.Log("Fixed Update Running");
        if (count == 1)
        {
            //Debug.Log("door should appear");
            RevealDoor();
        }
    }

    private void RevealDoor()
    {
        exitDoor.SetActive(true);
    }
}
