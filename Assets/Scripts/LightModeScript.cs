using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightModeScript : MonoBehaviour
{
    public GameObject day;
    public GameObject night;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeBackground()
    {
        day.SetActive(true);
        night.SetActive(false);
    }
}
