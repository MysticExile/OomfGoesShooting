using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeOut : MonoBehaviour
{

    // the image you want to fade, assign in inspector
    public SpriteRenderer spriteRenderer;

    public void Start()
    {
        // fades the image out when you click
        StartCoroutine(FadeImage(true));
    }

    IEnumerator FadeImage(bool fadeAway)
    {
        // fade from opaque to transparent
        if (fadeAway)
        {
            // loop over 1 second backwards
            for (float i = 2; i >= 0; i -= Time.deltaTime)
            {
                // set color with i as alpha
                spriteRenderer.color = new Color(1, 1, 1, i);
                yield return null;
            }
        }
        // fade from transparent to opaque
        else
        {
            // loop over 1 second
            for (float i = 0; i <= 2; i += Time.deltaTime)
            {
                // set color with i as alpha
                spriteRenderer.color = new Color(1, 1, 1, i);
                yield return null;
            }
        }
    }
}