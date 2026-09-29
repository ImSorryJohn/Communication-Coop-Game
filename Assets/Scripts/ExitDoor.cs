using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    public int count = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 1)
        {
            RevealDoor();
        }
    }

    public void ChangeCount(int change)
    {
        count += change;
    }

    private void RevealDoor()
    {
        gameObject.SetActive(true);
    }
}
