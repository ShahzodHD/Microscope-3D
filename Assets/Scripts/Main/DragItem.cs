using UnityEngine;
using UnityEngine.EventSystems;

public class DragItem : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    [SerializeField] private RectTransform rectTransform;
    [SerializeField] private Canvas mainCanvas;
    [SerializeField] private CanvasGroup canvasGroup;

    [SerializeField] private Transform transformParent;

    private Vector3 offset;
    public void OnBeginDrag(PointerEventData eventData)
    {
        var slotTransform = rectTransform.parent;
        slotTransform.SetAsLastSibling();
        canvasGroup.blocksRaycasts = false;
        offset = transform.position - MouseWorldPosition();
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = MouseWorldPosition() + offset;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.localPosition = Vector3.zero;
        canvasGroup.blocksRaycasts = true;
        if (gameObject.transform.parent.tag == "Microscope")
        {
            gameObject.transform.SetParent(transformParent);
        }
    }
    private Vector3 MouseWorldPosition()
    {
        var mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }
}
