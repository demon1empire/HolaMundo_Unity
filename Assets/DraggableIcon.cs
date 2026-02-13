using UnityEngine;
using UnityEngine.EventSystems; // Necesario para detectar el arrastre
using UnityEngine.UI;

public class DraggableIcon : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    void Awake() {
        rectTransform = GetComponent<RectTransform>();
        // Añade un componente CanvasGroup automáticamente si no existe
        canvasGroup = GetComponent<CanvasGroup>() ?? gameObject.AddComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData) {
        canvasGroup.alpha = 0.6f; // Efecto visual de transparencia
        canvasGroup.blocksRaycasts = false; // Permite que el ratón no se bloquee con el objeto
    }

    public void OnDrag(PointerEventData eventData) {
        // Mueve el objeto según el movimiento del ratón
        rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData) {
        canvasGroup.alpha = 1.0f; // Vuelve a la normalidad
        canvasGroup.blocksRaycasts = true;
    }
}