using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radioTuner : MonoBehaviour
{

    public AudioClip[] radioTracks;
    int currentTrack = 0;
    int totalTracks;
    public AudioSource source;
    public Vector3 currentTrans;
    public Vector3 targetTrans;
    public GameObject Dial;
   

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        totalTracks = radioTracks.Length;

        if (totalTracks > 0)
            plusTrack();

     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void minusTrack()
    {
        if (source.isPlaying)
            source.Stop();

        if (currentTrack < 0)
        {
            currentTrack = totalTracks-1;
        }
            source.clip = radioTracks[currentTrack--];
            source.Play();


        Dial.transform.Rotate(Vector3.up * 200);


    }

    public void plusTrack()
    {
        if (source.isPlaying)
            source.Stop();

        if (currentTrack >= totalTracks)
        {
            currentTrack = 0;
        } else
        { 
        source.clip = radioTracks[currentTrack++];
        }
        source.Play();
        Dial.transform.Rotate(-Vector3.up * 200);
    }
}
