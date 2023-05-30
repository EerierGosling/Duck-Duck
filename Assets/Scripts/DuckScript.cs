using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckScript : MonoBehaviour
{
    public Animator anim;
    public Manager Man;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        Man = FindObjectOfType<Manager>(); // Find the Manager script in the scene
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player collided with the duck");
            anim.SetTrigger("gone");
            Man.DuckCount++; // Increment the DuckCount variable in the Manager script
            Destroy(gameObject);
        }
    }
}
