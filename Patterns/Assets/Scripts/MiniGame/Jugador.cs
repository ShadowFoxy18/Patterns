using UnityEngine;

public class Jugador : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        //Sistema con Interface
        if (other.GetComponent<IPickeableObject>() != null) // Comprobar si el objeto se puede coger
        {
            other.GetComponent<IPickeableObject>().RecogerObjeto(); // Cogerlo
        }
        
        //Sistema antiguo
        
        if (other.CompareTag("Coin"))
        {
            Debug.Log("Toca moneda");
        }
        else if (other.CompareTag("Life"))
        {
            Debug.Log("Toca vida");
        }
        else if (other.CompareTag("Time"))
        {
            Debug.Log("Toca time");
        }
    }
}
