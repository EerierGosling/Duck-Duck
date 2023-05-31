using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public Sprite Button_Unpressed;   // The default sprite
    public Sprite Button_Pressed;   // The sprite to switch to when the button is pressed

    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider;

    private void Start()
    {
        // Get the SpriteRenderer component
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Get the BoxCollider2D component
        boxCollider = GetComponent<BoxCollider2D>();

        // Set the default sprite initially
        spriteRenderer.sprite = Button_Unpressed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with the button's box collider
        if (collision.collider == boxCollider)
        {
            // Switch the sprite to the pressed sprite
            spriteRenderer.sprite = Button_Pressed;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // Check if the collision is with the button's box collider
        if (collision.collider == boxCollider)
        {
            // Switch the sprite back to the default sprite
            spriteRenderer.sprite = Button_Unpressed;
        }
    }
}