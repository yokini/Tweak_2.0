using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiverTimer : MonoBehaviour
{
    public float time;

    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time = time + 0.005f;
    }
}
