using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicOnOff : MonoBehaviour
{
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActiveSound()
    {
        bool active = true;
        if(active == false)
        {
            audio.mute = true;
            active = false;
        }
        else 
        {
            audio.mute = false;
            active = true;
        }
    }
}
