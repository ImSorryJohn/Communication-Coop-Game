using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
     public void NextScene1()
    {
        SceneManager.LoadScene("Level2");
    }
}
