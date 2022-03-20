using UnityEngine;

public class SwitchingButtons : MonoBehaviour
{
    [SerializeField] private GameObject[] panels;
    [SerializeField] private int page = 0;
    public int IntSwitch
    {
        get { return page; }
        set { page = Mathf.Clamp(value, 0, panels.Length - 1); }
    }
    public void SwitchLeft()
    {
        IntSwitch--;
        SwitchingPage();
    }

    public void SwitchRight()
    {
        IntSwitch++;
        SwitchingPage();
    }

    private void SwitchingPage()
    {
        switch (page)
        {
            case 0:
                DisableAllPanels();
                panels[0].SetActive(true);
                break;
            case 1:
                DisableAllPanels();
                panels[1].SetActive(true);
                break;
            case 2:
                DisableAllPanels();
                panels[2].SetActive(true);
                break;
            case 3:
                DisableAllPanels();
                panels[3].SetActive(true);
                break;
            case 4:
                DisableAllPanels();
                panels[4].SetActive(true);
                break;
            case 5:
                DisableAllPanels();
                panels[5].SetActive(true);
                break;
            case 6:
                DisableAllPanels();
                panels[6].SetActive(true);
                break;
            case 7:
                DisableAllPanels();
                panels[7].SetActive(true);
                break;
            case 8:
                DisableAllPanels();
                panels[8].SetActive(true);
                break;
        }
    }

    private void DisableAllPanels()
    {
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].SetActive(false);
        }
    }
}
