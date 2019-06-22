using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public float movementSpeed = 5f;
    public float rotationSpeed = 200f;
    public float jumpForce = 100f;
    bool isTouchingOnFloor;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);
        transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);

        if(Input.GetAxis("Jump") > 0 && isTouchingOnFloor)
        {
            rb.AddForce(Vector3.up * jumpForce);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "floor")
        {
            isTouchingOnFloor = true;
        }

        if(collision.gameObject.tag == "enemy")
        {
            SceneManager.LoadScene("main", LoadSceneMode.Single);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "floor")
        {
            isTouchingOnFloor = false;
        }
    }
}