using UnityEngine;
using UnityEngine.Video;

public class VideoPlaneController : MonoBehaviour
{
    public VideoPlayer vp;

    private void OnEnable()
    {
        if (vp !=null)vp.Play();
    }

    private void OnDisable()
    {
        if (vp != null) vp.Stop();
    }
}
