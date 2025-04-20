using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Fader : MonoBehaviour
{
    private const float DeltaSize = .5f;
    private float finalAlpha;
    private float deltaAlpha;
    private bool notFadingAlready = true;

    public void FadeMeOut()
    {
        finalAlpha = 0;
        deltaAlpha = -1 * DeltaSize;
        GoFadeOut();
    }

    public void FadeMeIn()
    {
        finalAlpha = 0;
        deltaAlpha = -1 * DeltaSize;
        GoFade();
    }

    private void GoFade()
    {
        if (notFadingAlready)
        {
            notFadingAlready = false;

            StartCoroutine(DoFade());
        }
    }

    private void GoFadeOut()
    {
        if (notFadingAlready)
        {
            notFadingAlready = false;

            StartCoroutine(DoFadeOut());
        }
    }

    IEnumerator DoFade()
    {
        CanvasGroup cg = GetComponent<CanvasGroup>();

        while (cg.alpha != finalAlpha)
        {
            // Alpha is clamped to [0, 1].

            cg.alpha += deltaAlpha * Time.deltaTime;

            yield return null;
        }

        notFadingAlready = true;
        
        yield return null;
    }

    IEnumerator DoFadeOut()
    {
        CanvasGroup cg = GetComponent<CanvasGroup>();

        while (cg.alpha != finalAlpha)
        {
            // Alpha is clamped to [0, 1].

            cg.alpha += deltaAlpha * Time.deltaTime;

            yield return null;
        }

        notFadingAlready = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        yield return null;
    }
}
