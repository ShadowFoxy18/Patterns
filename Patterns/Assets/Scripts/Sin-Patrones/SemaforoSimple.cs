using UnityEngine;

public class SemaforoSimple : MonoBehaviour
{
    /// <summary>
    /// Diferentes luces del semaforo que activamos y desactivamos
    /// </summary>
    public GameObject luzRoja, luzAmarilla, luzVerde;
    //Contador de tiempo, en este caso público para poder desde inspector durante la ejecución
    //cambiarlo.
    public float timer = 0f;

    /// <summary>
    /// Vamos a crear un semaforo que empieza en rojo 10 segundos,pasa a verde 15 segundos,
    /// luego a ambar 2 segundos y vuelve al estado rojo
    /// </summary>
    void Start()
    {
        //Inicialmente el semáforo empieza en rojo.
        PonerEnRojo();
    }

    // Update is called once per frame
    void Update()
    {
        //Contamos el tiempo
        timer += Time.deltaTime;

        //Si el semáforo está rojo y han pasado 10 segundos pasa a verde.
        if (timer > 10f && luzRoja.activeSelf == true)
        {
            PonerEnVerde();
        } //Semáforo está verde y pasan 15 segundos pasa a ambar
        else if (timer >= 15f && luzVerde.activeSelf == true)
        {
            PonerEnAmbar();
        } // Semáforo en ambar y pasan dos segundos.
        else if(timer > 2f && luzAmarilla.activeSelf == true)
        {
            PonerEnRojo();
        }
    }
    // Las siguientes funciones son todas muy parecidas 
    //Activan o desactivan luces y vuelven a poner el contador de tiempo a cero.
    void PonerEnRojo()
    {
        luzRoja.SetActive(true);
        luzAmarilla.SetActive(false);
        luzVerde.SetActive(false);
        timer = 0f;

    }

    void PonerEnVerde()
    {
        luzRoja.SetActive(false);
        luzAmarilla.SetActive(false);
        luzVerde.SetActive(true);
        timer = 0f;

    }

    void PonerEnAmbar()
    {
        luzRoja.SetActive(false);
        luzAmarilla.SetActive(true);
        luzVerde.SetActive(false);
        timer = 0f;

    }
}
