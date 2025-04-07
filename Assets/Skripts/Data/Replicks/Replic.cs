using UnityEngine;

[CreateAssetMenu(fileName = "Replic", menuName = "ScriptableObjects/Replics", order = 3)]
public class Replic : ScriptableObject
{
    [System.Serializable]
    public class Repliks
    {

        [field: TextArea(2, 30)]
        [field: SerializeField] public string ru { get; private set; }
        [field: TextArea(2, 30)]
        [field: SerializeField] public string en { get; private set; }
    }
    public Repliks[] repliks;
}
