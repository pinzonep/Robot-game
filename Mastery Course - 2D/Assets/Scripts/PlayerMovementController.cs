using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 4;

    // Update is called once per frame
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // gives a value back between -1 and 1
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, vertical); // gives direction

        transform.position += movement * Time.deltaTime * moveSpeed; // move character around - access transform in the Inspector
    }
}
