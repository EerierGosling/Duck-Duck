using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public Animator cam;
    public int DuckCount;
    public GameObject Particles;
    public bool openDoor = false;

    private void Start()
    {
        DuckCount = 0;
    }

    private void Update()
    {
        if (DuckCount == 2)
        {
            Particles.SetActive(true);
            cam.SetTrigger("done");
            openDoor = true;
            DuckCount = 0;
        }
    }
}