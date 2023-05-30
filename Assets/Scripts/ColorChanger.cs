using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Color color1;
    public Color color2;
    public float transitionDuration = 1f;

    private Renderer renderer;
    private float t = 0f;
    private bool isForward = true;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        // Update the transition value based on the direction
        float deltaT = Time.deltaTime / transitionDuration;
        t += (isForward ? deltaT : -deltaT);
        t = Mathf.Clamp01(t);

        // Check if the transition direction needs to be reversed
        if (t >= 1f || t <= 0f)
        {
            isForward = !isForward;
        }

        // Transition between colors
        Color currentColor = Color.Lerp(color1, color2, t);
        renderer.material.color = currentColor;
    }
}
