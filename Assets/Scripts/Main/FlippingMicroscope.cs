using UnityEngine;

public class FlippingMicroscope : MonoBehaviour
{
    [SerializeField] float speedRotation;
    [SerializeField] float rotateA;
    [SerializeField] float rotateB;

    private float time;
    private Quaternion angleA;
    private Quaternion angleB;

    private void Start()
    {
        angleA = Quaternion.Euler(-90, rotateA, 0);
        angleB = Quaternion.Euler(-90, -rotateB, 0);
    }
    private void Update()
    {
        time = Mathf.PingPong(Time.time * speedRotation, 1.0f);
        transform.rotation = Quaternion.Lerp(angleA, angleB, time);
    }
}
