using UnityEngine;

namespace WebGame397
{
    [CreateAssetMenu(fileName = "AudioAsset", menuName = "AudioSystem/AudioAsset")]

    public class AudioAsset : ScriptableObject
    {
        public string audioName;
        public AudioClip audioClip;
        [Range(0.0f, 1.0f)] public float audioVolume;
        public bool audioLooping = false;
    }

}
