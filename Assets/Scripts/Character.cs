using UnityEngine;
[RequireComponent(typeof(MoveBehaviour))]

public class Character : MonoBehaviour
{
    protected MoveBehaviour _mb;

    private void Awake()
    {
        _mb = GetComponent<MoveBehaviour>();
    }
}
