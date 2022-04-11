using UnityEngine;
using UnityEngine.SceneManagement;

public class control : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Main");
    }
}
