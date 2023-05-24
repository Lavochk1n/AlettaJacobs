using UnityEngine;
using UnityEngine.Video;

public class VideoTexture : MonoBehaviour
{
    public VideoClip videoClip;

    private Renderer renderer;
    private VideoPlayer videoPlayer;

    void Start()
    {
        renderer = GetComponent<Renderer>();

        videoPlayer = gameObject.AddComponent<VideoPlayer>();
        videoPlayer.clip = videoClip;
        videoPlayer.isLooping = true;
        videoPlayer.Play();

        renderer.material.SetTexture("_MainTex", videoPlayer.texture);
    }
}
