using UnityEngine;

public class ManejadorEnlaces : MonoBehaviour
{
    // Esta función abrirá los links de tus 3 botones
    public void AbrirPagina(string url)
    {
        Application.OpenURL(url);
    }
}