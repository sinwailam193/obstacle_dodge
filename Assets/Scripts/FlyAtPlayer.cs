using UnityEngine;

public class FlyAtPlayer : MonoBehaviour {
    [SerializeField] float moveSpeed = 3f;
    [SerializeField] Transform player;
    Vector3 playerPos;

    void Start() {
        playerPos = player.position;
    }

    void Update() {
        // input current position, new postion, move speed
        transform.position = Vector3.MoveTowards(transform.position, playerPos, Time.deltaTime * moveSpeed);
    }
}
