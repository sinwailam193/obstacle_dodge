using UnityEngine;

public class Mover : MonoBehaviour {
    [SerializeField] float moveSpeed = 20f;

    // Update is called once per frame
    void Update() {
        MovePlayer();
    }

    void MovePlayer() {
        // using Time.deltaTime to make the movement framerate independent
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, yValue, zValue);
    }
}
