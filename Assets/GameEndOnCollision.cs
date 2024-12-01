using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Para reiniciar el nivel si se desea

public class GameEndOnCollision : MonoBehaviour
{
    public string targetObjectName = "Cylinder"; // Nombre del objeto a tocar
    public GameObject messagePanel; // Panel de mensaje opcional para mostrar "Ganaste"

    void OnCollisionEnter(Collision collision)
    {
        // Verificar si el objeto tocado es el cilindro
        if (collision.gameObject.name == targetObjectName)
        {
            Debug.Log("¡Ganaste!"); // Mostrar mensaje en la consola

            // Mostrar mensaje en pantalla
            if (messagePanel != null)
            {
                messagePanel.SetActive(true);
            }

            // Detener el juego o recargar la escena (opcional)
            Time.timeScale = 0; // Pausa el juego
        }
    }
}
