using UnityEngine;

public class HidingPanels : MonoBehaviour
{
    [SerializeField] private float speed = 10;

    private Vector3 direction;
    private bool SwitchBool = false;
    private float timeCount;

    public void Hide()
    {
        SwitchBool = true;
    }

    private void Update()
    {
        if (SwitchBool == true)
        {
            direction.x = -timeCount;
            transform.Translate(direction.x * speed, 0, 0);
            timeCount = Time.deltaTime;
            if (transform.localPosition.x < -990)
            {
                SwitchBool = false;
            }
        }
    }
}
