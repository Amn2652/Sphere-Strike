using System.Collections;
using UnityEngine;

public class Color_Changer : MonoBehaviour
{
    public float transitionDuration = 1f; // Duration of color transition (in seconds)
    private SpriteRenderer spriteRenderer; // SpriteRenderer component of the GameObject

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(ChangeColorSmoothly());
    }

    IEnumerator ChangeColorSmoothly()
    {
        while (true)
        {
            // Generate a random color
            Color randomColor = new Color(Random.value, Random.value, Random.value);

            // Smoothly transition to the new color
            Color startColor = spriteRenderer.color;
            float startTime = Time.time;
            float elapsedTime = 0f;

            while (elapsedTime < transitionDuration)
            {
                spriteRenderer.color = Color.Lerp(startColor, randomColor, elapsedTime / transitionDuration);
                elapsedTime = Time.time - startTime;
                yield return null;
            }

            // Ensure the color is exactly the target color when the transition ends
            spriteRenderer.color = randomColor;

            // Wait for the next color change
            yield return null;
        }
    }
}
