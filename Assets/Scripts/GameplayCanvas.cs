using UnityEngine;

public class GameplayCanvas : MonoBehaviour
{
    void Start()
    {
        GetComponent<Fader>().FadeMeIn();
    }
}
