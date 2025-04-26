using UnityEngine;

public class TriggerProjectile : MonoBehaviour {
    GameObject projectiles;
    GameObject dropper;
    GameObject spinner;

    void Awake() {
        projectiles = GameObject.Find("Projectiles");
        projectiles.SetActive(false);

        dropper = GameObject.Find("Cube from Sky");
        dropper.SetActive(false);

        spinner = GameObject.Find("Spinning rect");
        spinner.SetActive(false);
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            projectiles.SetActive(true);
            dropper.SetActive(true);
            spinner.SetActive(true);
        }
    }
}
