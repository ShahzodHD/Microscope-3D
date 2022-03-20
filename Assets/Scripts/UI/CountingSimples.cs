using UnityEngine;

public class CountingSimples : MonoBehaviour
{
    [SerializeField] private GameObject[] scopeSimples;
    public void Count(string nameSimple)
    {
        switch (nameSimple)
        {
            case "ItemK":
                DisableAllScopeSimples();
                scopeSimples[0].SetActive(true);
                break;
            case "ItemJ":
                DisableAllScopeSimples();
                scopeSimples[1].SetActive(true);
                break;
            case "ItemB":
                DisableAllScopeSimples();
                scopeSimples[2].SetActive(true);
                break;
            case "ItemD":
                DisableAllScopeSimples();
                scopeSimples[3].SetActive(true);
                break;
            case "ItemL":
                DisableAllScopeSimples();
                scopeSimples[4].SetActive(true);
                break;
        }
    }
    private void DisableAllScopeSimples()
    {
        for (int i = 0; i < scopeSimples.Length; i++)
        {
            scopeSimples[i].SetActive(false);
        }
    }
}
