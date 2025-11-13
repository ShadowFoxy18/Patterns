using UnityEngine;

public class EstadoVerde : IEstado
{
    float timer = 0.0f;
    public void Ejecutar(SemaforoStateMachine semaforo)
    {
        timer += Time.deltaTime;
        if (timer > 15)
        {
            semaforo.CambiarEstado(new EstadoAmarillo());
        }
    }

    public void Entrar(SemaforoStateMachine semaforo)
    {
        Debug.Log("Entra a semaforo en verde");
        semaforo.luzVerde.SetActive(true);
        timer = 0.0f;
    }

    public void Salir(SemaforoStateMachine semaforo)
    {
        semaforo.luzVerde.SetActive(false);
    }
}
