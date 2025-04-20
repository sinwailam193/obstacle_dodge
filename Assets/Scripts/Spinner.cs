using UnityEngine;

public class Spinner : MonoBehaviour {
    [SerializeField] float xAngle = 0;
    [SerializeField] float yAngle = 0.8f;
    [SerializeField] float zAngle = 0;

    void Update() {
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
