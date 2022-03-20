using UnityEngine;

public class ShowDescriptionSimple : MonoBehaviour
{
    private void OnMouseEnter()
    {
        gameObject.transform.GetChild(1).gameObject.SetActive(true);
    }
    private void OnMouseExit()
    {
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
    }
}
