using UnityEngine;

public class Scorer : MonoBehaviour {
    private int currentScore = 0;

    private void OnCollisionEnter(Collision collision) {
        currentScore++;
        Debug.Log($"You've bumped into a thing this many times: {currentScore}");
    }
}
