using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnabledDisabledGreenCircleScope : MonoBehaviour
{
    [SerializeField] private GameObject GreenCircleScope;
    public void Enabled()
    {
        GreenCircleScope.SetActive(true);
    }
    public void Disabled()
    {
        GreenCircleScope.SetActive(false);
    }
}
