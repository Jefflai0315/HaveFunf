using UnityEngine;

public class ThrowObject : MonoBehaviour {

    public GameObject objectToThrow;
    // public GameObject Camera;
    public float throwForce;
    public float throwUpwardForce;
    public float speed = 5;
    public float radius = 10;

    void Update() {
        // Move the NPC in a circle.
        Vector3 direction = transform.position - Camera.main.transform.position;
        print(direction);
        direction.Normalize();
        transform.position += direction * speed * Time.deltaTime;

        if (transform.position.magnitude > radius) {
            transform.position = transform.position.normalized * radius;
        }


        // Throw the object at the player if the player is close.
        if (Physics.Raycast(transform.position, direction, 10)) {
            objectToThrow.GetComponent<Rigidbody>().AddForce(direction * throwForce, ForceMode.Impulse);
            objectToThrow.GetComponent<Rigidbody>().AddForce(Vector3.up * throwUpwardForce, ForceMode.Impulse);
        }
    }
}
