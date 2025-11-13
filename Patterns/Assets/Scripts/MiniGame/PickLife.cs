using UnityEngine;

public class PickLife : MonoBehaviour, IPickeableObject
{
    [SerializeField]
    AudioClip clip;
    public void RecogerObjeto()
    {
        Debug.Log("recoger vida");
        AudioEffects.Instance.PlaySound(clip);
    }
}
