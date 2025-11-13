using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Localization.Settings;

public class SemaforoConEnum : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI textoSemaforo;
    //Declarando los diferentes estados de mi semáforo.
    public enum EstadoEnumSemaforo
    {
        enRojo,
        enVerde,
        enAmarillo
    }

    //Para poder seleccionar desde el inspector el estado inicial.
    [SerializeField]
    EstadoEnumSemaforo estadoInicial;
    //Estado actual del semaforo NADIE lo puede cambiar por eso es privado.
    private EstadoEnumSemaforo estadoActualSemaforo;

    //Contador de tiempo
    float timer = 0.0f;

    //Acceso a las luces.
    public GameObject luzRoja, luzVerde, luzAmarilla;

    // Pone el estado actual del semaforo en el que tengamos seleccionado en el inspector de unity.
    void Start()
    {
        estadoActualSemaforo = estadoInicial;
    }

    //Cuenta tiempo y ejecuta el estado actual.
    void Update()
    {
        timer += Time.deltaTime;

        //Un Switch es como un IF simplificado en este ejemplo lo que hace es 
        //mirar el valor de estadoActualSemaforo y según el estado (rojo, verde, amarillo)
        //Ejecuta la función de dicho estado.
        switch (estadoActualSemaforo)
        {
            case EstadoEnumSemaforo.enRojo:
                SemaforoEnRojo();
                break;
            case EstadoEnumSemaforo.enAmarillo:
                SemaforoEnAmarillo();
                break;
            case EstadoEnumSemaforo.enVerde:
                SemaforoEnVerde();
                break;
        }
    }

    //Funciones de cada estado.
    void SemaforoEnRojo()
    {
        textoSemaforo.text = LocalizationSettings.StringDatabase.GetLocalizedString("UI", "_red"); 
        luzRoja.SetActive(true);
        luzVerde.SetActive(false);
        luzAmarilla.SetActive(false);
        
        if(timer > 10.0f) 
        {
            estadoActualSemaforo = EstadoEnumSemaforo.enVerde;
            timer = 0.0f;
        }
    }

    void SemaforoEnVerde()
    {
        textoSemaforo.text = LocalizationSettings.StringDatabase.GetLocalizedString("UI", "_green");
        if (timer < 15f)
        {
            luzRoja.SetActive(false);
            luzVerde.SetActive(true);
            luzAmarilla.SetActive(false);
        }
        else
        {
            estadoActualSemaforo = EstadoEnumSemaforo.enAmarillo;
            timer = 0.0f;
        }
    }

    void SemaforoEnAmarillo()
    {
        string desc = LocalizationSettings.StringDatabase.GetLocalizedString("UI", "_orange");
        textoSemaforo.text = desc;
        if (timer < 2f)
        {
            luzRoja.SetActive(false);
            luzVerde.SetActive(false);
            luzAmarilla.SetActive(true);
        }
        else
        {
            estadoActualSemaforo = EstadoEnumSemaforo.enRojo;
            timer = 0.0f;
        }
    }

}

