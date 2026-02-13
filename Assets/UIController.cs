using UnityEngine;
using TMPro; // Necesario para trabajar con TextMesh Pro

public class UIController : MonoBehaviour
{
    public TextMeshProUGUI textoTitulo; // Arrastraremos aquí tu texto de "Realms of Fantansia"
    public TMP_FontAsset fuenteNueva;   // Arrastraremos aquí el archivo de la fuente que quieras
    public float tamañoPersonalizado = 85f;

    // Función para que el botón cambie la fuente y el tamaño
    public void CambiarEstiloTexto() {
        if (textoTitulo != null && fuenteNueva != null) {
            textoTitulo.font = fuenteNueva;
            textoTitulo.fontSize = tamañoPersonalizado;
        }
    }
}