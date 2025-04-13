using UnityEngine;

public class Scorer : MonoBehaviour {
    private int currentScore = 0;

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.name != "Ground" && other.gameObject.tag != "Hit") {
            other.gameObject.tag = "Hit";
            currentScore++;
            Debug.Log($"You've bumped into a thing this many times: {currentScore}");
        }
    }
}
