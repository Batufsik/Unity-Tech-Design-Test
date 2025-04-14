using UnityEngine;

public class UI_FUNCTIONS : MonoBehaviour
{
    public AudioSource sound;
    public AudioClip clip;
    public void Menu_Start()
    {
        sound.Play();
    }

    public void Menu_Exit()
    {
        Application.Quit();
    }

}
