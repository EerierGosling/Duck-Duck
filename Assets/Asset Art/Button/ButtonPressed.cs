using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ButtonPressed : MonoBehaviour
{
    public Sprite buttonPressedSprite;

    private BoxCollider2D boxCollider;
    public Manager Man;
    private SpriteRenderer spriteRenderer;

    public bool buttonPressed = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        spriteRenderer.sprite = buttonPressedSprite;
        
        boxCollider.offset = new Vector2(0f, 0.05f);
        boxCollider.size = new Vector2(0.16f, 0.06f);
        
    }
}
