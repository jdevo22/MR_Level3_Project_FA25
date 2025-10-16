// ImageCue.cs
using UnityEngine;

/// <summary>
/// A simple data structure to hold a texture and the time it should appear.
/// This [System.Serializable] tag allows us to edit it in the Unity Inspector.
/// </summary>
[System.Serializable]
public struct ImageCue
{
    [Tooltip("The image that will be displayed.")]
    public Texture2D imageTexture;

    [Tooltip("The time in seconds since the performance started when this image will appear.")]
    public float displayTime;
}