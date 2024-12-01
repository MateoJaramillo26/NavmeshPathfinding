using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMover : MonoBehaviour
{
    // Referencia al objeto destino
    public Transform target;

    // Componente NavMeshAgent
    private NavMeshAgent agent;

    void Start()
    {
        // Obtener el NavMeshAgent del objeto
        agent = GetComponent<NavMeshAgent>();
        
        if (agent == null)
        {
            Debug.LogError("No se encontró un NavMeshAgent en el objeto.");
        }
    }

    void Update()
    {
        if (target != null && agent != null)
        {
            // Actualizar el destino del agente al objeto objetivo
            agent.SetDestination(target.position);
        }
    }
}
