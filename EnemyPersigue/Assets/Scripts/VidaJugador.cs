using UnityEngine;
using UnityEngine.UI;

public class VidaJugador : MonoBehaviour
{
    public float vidaMaxima = 100f;
    public float vidaActual;
    public Image  barraVida;

    void Update()
    {
        barraVida.fillAmount = vidaActual / vidaMaxima;  
    }

    public void ReducirVida(float cantidad)
    {
        vidaActual -= cantidad;
    }
}
