using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloumn_Destroy : MonoBehaviour
{

    float makeTime;
    float life_time = 5f;
    // Start is called before the first frame update
    void Start()
    {
        makeTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - makeTime > life_time) Destroy(gameObject);
    }
}
