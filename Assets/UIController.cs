using UnityEngine;
using TMPro; // Necesario para trabajar con TextMesh Pro
using UnityEngine.SceneManagement;
public class UIController : MonoBehaviour

    [Header("Configuración de Texto")]
    public TextMeshProUGUI textoTitulo; // Arrastraremos aquí tu texto de "Realms..."
    public TMP_FontAsset fuenteNueva; // Arrastraremos aquí el archivo de la fuente
    public float tamañoPersonalizado = 85f;

    [Header("Configuración de Animación")]
    public Animator menuAnimator; // <--- AGREGADO: Aquí arrastrarás tu PanelOpciones

    // Función que ya tenías para cambiar la fuente y el tamaño
    public void CambiarEstiloTexto() {
        if (textoTitulo != null && fuenteNueva != null) {
            textoTitulo.font = fuenteNueva;
            textoTitulo.fontSize = tamañoPersonalizado;
        }
    }

    // <--- AGREGADO: Función para que el botón active la animación de salida
    public void EjecutarSalida() {
        if (menuAnimator != null) {
            // Esto activa el trigger "Cerrar" que creamos en el Animator
            menuAnimator.SetTrigger("Cerrar");
        }
    }
// Función para navegar entre las escenas de tu catálogo
public void CargarEscena(string nombreEscena)
{
    // Esto buscará la escena en tus Build Settings y la abrirá
    SceneManager.LoadScene(nombreEscena);
}