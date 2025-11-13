using UnityEngine;

public class AudioEffects : MonoBehaviour
{
    private AudioSource m_Source;
    private static AudioEffects _instance;
    
    //Esto es un getter sirve para que desde otros scripts puedan acceder 
    // pero NO modificar el valor de la instancia.
    public static AudioEffects Instance { get { return _instance; } }

    //Awake solamente lo usamos para configurar los singleton
    void Awake()
    {
        if (_instance == null)
        {
            AudioEffects._instance = this;
            m_Source = GetComponent<AudioSource>();
        }
        else
        { 
            Destroy(this);
        }
    }
    public void PlaySound(AudioClip clip)
    { 
        m_Source.clip = clip;
        PlaySound();
    }
    public void PlaySound()
    {
        m_Source.Play();
    }

}
