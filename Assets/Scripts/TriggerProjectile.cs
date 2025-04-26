using UnityEngine;

public class TriggerProjectile : MonoBehaviour {
    GameObject projectile;
    GameObject dropper;
    GameObject spinner;

    void Start() {
        projectile = GameObject.Find("Flying Stuff");
        projectile.SetActive(false);

        dropper = GameObject.Find("Cube from Sky");
        dropper.SetActive(false);

        spinner = GameObject.Find("Spinning rect");
        spinner.SetActive(false);
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            projectile.SetActive(true);
            dropper.SetActive(true);
            spinner.SetActive(true);
        }
    }
}
