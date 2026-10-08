using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    Scene scene;
    public int currentScene;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
        currentScene = scene.buildIndex;
    }

     public void NextScene1()
    {
        SceneManager.LoadScene(currentScene + 1);
        //currentScene += 1;
    }

    public void RetryScene()
    {
        SceneManager.LoadScene(currentScene);
    }
}
