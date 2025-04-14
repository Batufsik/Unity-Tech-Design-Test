using UnityEngine;
using UnityEngine.SceneManagement;
public class UI_FUNCTIONS : MonoBehaviour
{
    public AudioSource sound;
    public AudioClip clip;
    public void Menu_Start()
    {
        sound.Play();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Menu_Exit()
    {
        Application.Quit();
    }

}
