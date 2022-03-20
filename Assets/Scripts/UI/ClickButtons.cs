using UnityEngine;

public class ClickButtons : MonoBehaviour
{
    [SerializeField] private GameObject[] panels;

    public void ShowPanel1() { PanelSwitching(0, 1, 2); }
    public void ShowPanel2() { PanelSwitching(1, 0, 2); }
    public void ShowPanel3() { PanelSwitching(2, 0, 1); }

    private void PanelSwitching(int enable, int disable1, int disable2)
    {
        panels[enable].SetActive(true);
        panels[disable1].SetActive(false);
        panels[disable2].SetActive(false);
    }
}
