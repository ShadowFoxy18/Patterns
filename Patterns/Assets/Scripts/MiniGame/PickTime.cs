using UnityEngine;

public class PickTime : MonoBehaviour, IPickeableObject
{
    [SerializeField]
    AudioClip clip;
    public void RecogerObjeto()
    {
        Debug.Log("Recoger tiempo");
        AudioEffects.Instance.PlaySound(clip);
    }
}
