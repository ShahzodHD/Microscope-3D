using UnityEngine;

public class AppearanceButtonOpen : MonoBehaviour
{
    public void Appearance()
    {
        Invoke("Appears", (float)1.1);
    }

    private void Appears()
    {
        gameObject.SetActive(true);
    }
}
