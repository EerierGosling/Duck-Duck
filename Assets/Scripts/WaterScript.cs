using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Animator anim;

    private void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
            
        }
    }
}
