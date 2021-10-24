using UnityEngine;

public class CarA : MonoBehaviour
{
    public float Movespeed = 50f;
    public float Turnspeed = 90f;
    private Rigidbody rb = null;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        float move = Input.GetAxis("Vertical");
        float turn = Input.GetAxis("Horizontal");

        rb.AddRelativeForce(Vector3.forward * move * Movespeed * Time.deltaTime, ForceMode.VelocityChange);
        this.transform.Rotate(Vector3.up, turn * Turnspeed * Time.deltaTime);
    }
}
