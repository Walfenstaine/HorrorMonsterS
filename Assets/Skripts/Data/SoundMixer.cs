using UnityEngine;

[CreateAssetMenu(fileName = "Mixer", menuName = "ScriptableObjects/SoundMixer", order = 2)]
public class SoundMixer : ScriptableObject
{
    [System.Serializable]
    public class Chenels 
    {
        public AudioClip clip;
        [Range(0, 1)]
        public float volume;
    }
    public Chenels[] cenel;
}
