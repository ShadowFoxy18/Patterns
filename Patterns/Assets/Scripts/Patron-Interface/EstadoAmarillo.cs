using UnityEngine;

//Ejecuta la interfaz de estado amarillo
public class EstadoAmarillo : IEstado
{
    float parpadeoTimer = 0.0f;
    float timer = 0.0f;
    public void Ejecutar(SemaforoStateMachine semaforo)
    {
        timer += Time.deltaTime;

        //-Parpadeo-//
        parpadeoTimer += Time.deltaTime;        
        if (parpadeoTimer > 0.2f)
        {
            semaforo.luzAmarilla.SetActive(!semaforo.luzAmarilla.activeSelf);
            parpadeoTimer = 0.0f;
        }


        if (timer > 2)
        {
            semaforo.CambiarEstado(new EstadoRojo());
        }
    }

    public void Entrar(SemaforoStateMachine semaforo)
    {
        Debug.Log("Entra a semaforo en amarillo");
        semaforo.luzAmarilla.SetActive(true);
        timer = 0.0f;
    }

    public void Salir(SemaforoStateMachine semaforo)
    {
        semaforo.luzAmarilla.SetActive(false);
    }
}