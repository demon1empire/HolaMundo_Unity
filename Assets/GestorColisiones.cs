using UnityEngine;
using UnityEngine.UI; // Necesario para manejar imágenes de la interfaz

public class GestorColisiones : MonoBehaviour
{
    private Image miImagen;

    void Start()
    {
        // Guardamos la referencia a la imagen al empezar
        miImagen = GetComponent<Image>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Zona_Activacion")
        {
            Debug.Log("¡Contacto detectado!");
            miImagen.color = Color.green; // Cambia a verde al entrar
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Zona_Activacion")
        {
            miImagen.color = Color.white; // Vuelve a su color normal al salir
        }
    }
}