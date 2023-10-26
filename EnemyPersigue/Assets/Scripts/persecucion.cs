using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class persecucion : MonoBehaviour
{
    public NavMeshAgent myEnemy;
    public Transform myPlayer;
    public VidaJugador vidaJugador;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colisión detectada");

        if (collision.gameObject.CompareTag("Player"))
        {
            vidaJugador.ReducirVida(5f);
        }
    }

    void Update()
    {
        myEnemy.SetDestination(myPlayer.position);
    }
}
