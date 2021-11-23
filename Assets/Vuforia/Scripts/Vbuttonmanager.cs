using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.Video;


public class Vbuttonmanager : MonoBehaviour, IVirtualButtonEventHandler
{
    public VideoPlayer player;
    public GameObject playButton;

    private AudioSource audioSource;
    private bool paused1;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        audioSource = GetComponent<AudioSource>();
        paused1 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        
        player.Play();
        playButton.GetComponent<Renderer>().enabled = false;
        paused1 = true;
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        player.Pause();
        playButton.GetComponent<Renderer>().enabled = true;
        paused1 = false;
    }
}
