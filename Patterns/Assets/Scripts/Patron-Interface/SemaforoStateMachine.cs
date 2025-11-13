using UnityEngine;

//Este es el cerebro de la máuina de estados/semáforo.
public class SemaforoStateMachine : MonoBehaviour
{
    //Luces que tiene el semaforo.
    public GameObject luzRoja, luzAmarilla, luzVerde;

    //Estado actual.
    private IEstado estadoActualSemaforo;
    
    void Start()
    {
        //Prepara semáforo con todo apagado
        luzRoja.SetActive(false);
        luzAmarilla.SetActive(false);
        luzVerde.SetActive(false);

        //Enciende semáforo en ROJO
        CambiarEstado(new EstadoRojo());
    }

    // Update is called once per frame
    void Update()
    {
        //Si tenemos un estado lo ejecutamos
        if (estadoActualSemaforo != null)
        {
            estadoActualSemaforo.Ejecutar(this);
        }
    }

    public void CambiarEstado(IEstado nuevoEstado)
    {
        //Si tenemos un estado salimos del mismo
        if (estadoActualSemaforo != null) {
            estadoActualSemaforo.Salir(this);
        }

        //Pasamos al nuevo estado (esto sirve para tener memoria de dónde estamos)
        estadoActualSemaforo = nuevoEstado;
        //Entramos al nuevo estado.
        estadoActualSemaforo.Entrar(this);
    
    }
}
