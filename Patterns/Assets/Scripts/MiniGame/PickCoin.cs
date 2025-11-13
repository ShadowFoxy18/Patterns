using UnityEngine;

public class PickCoin : MonoBehaviour, IPickeableObject
{
    public void RecogerObjeto()
    {
        Debug.Log("recoger moneda");
    }
}
