using UnityEngine;

public class FadedGreenCircle : MonoBehaviour
{
    [SerializeField] private MeshRenderer meshRenderer;
    private void OnMouseEnter()
    {
        meshRenderer.enabled = false;
    }
    private void OnMouseExit()
    {
        meshRenderer.enabled = true;
    }
}
