using UnityEngine;
using UnityEngine.EventSystems;

public class DragSlot : MonoBehaviour, IDropHandler
{
    [SerializeField] private CountingSimples scope;
    [SerializeField] private EnabledDisabledGreenCircleScope scopeEnable;
    public void OnDrop(PointerEventData eventData)
    {
        var otherItemTransform = eventData.pointerDrag.transform;
        string nameItem = otherItemTransform.name;
        if (gameObject.tag == "Microscope" && gameObject.transform.childCount == 0)  
        {
            otherItemTransform.SetParent(transform);
            scope.Count(nameItem);
            scopeEnable.Enabled();
        }
        otherItemTransform.localPosition = Vector3.zero;
    }
}
