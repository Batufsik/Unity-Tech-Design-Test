using UnityEngine;
using UnityEngine.SceneManagement;
public class UI_FUNCTIONS : MonoBehaviour
{
    public void Menu_Start()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Menu_Exit()
    {
        Application.Quit();
    }
}
