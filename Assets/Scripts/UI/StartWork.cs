using UnityEngine;

public class StartWork : MonoBehaviour
{
    [SerializeField] private Transform target;
    [Header("Target position")]
    [SerializeField] private int positionX;
    [SerializeField] private int positionY;
    [SerializeField] private int positionZ;
    [Header("Target rotation")]
    [SerializeField] private int rotationX;
    [SerializeField] private int rotationY;
    [SerializeField] private int rotationZ;
    public void StartScene()
    {
        target.transform.position = new Vector3(positionX, positionY, positionZ);
        target.transform.rotation = Quaternion.Euler(rotationX, rotationY, rotationZ);
    }
}
