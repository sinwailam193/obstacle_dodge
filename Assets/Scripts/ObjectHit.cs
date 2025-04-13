using UnityEngine;

public class ObjectHit : MonoBehaviour {
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.name != "Ground" && other.gameObject.tag == "Player") {
            GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}
