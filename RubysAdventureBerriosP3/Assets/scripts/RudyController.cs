using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RudyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //QualitySettings.vSyncCount = 0;
        //Application.targetFrameRate = 10;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Veritcal");

        Vector2 postion = transform.position;
        postion.x = postion.x + 0.1f * horizontal * Time.deltaTime;
        postion.y = postion.y + 0.1f * vertical * Time.deltaTime;
        transform.position = postion;
    }
}
