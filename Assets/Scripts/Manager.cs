using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public Animator cam;
    public int DuckCount;
    public GameObject Door;
    public GameObject Particles;

    private void Start()
    {
        DuckCount = 0;
    }

    private void Update()
    {
        if (DuckCount == 2)
        {
            Destroy(Door);
            Particles.SetActive(true);
            cam.SetTrigger("done");
            DuckCount = 0;
        }
    }
}
