using UnityEngine;

public class EnabledScope : MonoBehaviour
{
    [SerializeField] private GameObject scope;
    private void OnMouseDown()
    {
        scope.SetActive(true);
    }
}
