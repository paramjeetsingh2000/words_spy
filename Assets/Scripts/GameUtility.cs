
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUtility : MonoBehaviour
{

     void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }   
}
