using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jump : MonoBehaviour
{
    public float jumpForce = 40f;
    private Rigidbody2D rig;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && transform.position.y < 5  )
        {
            Debug.Log("스페이스 눌림");
            rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            if (transform.position.y >= 5f)
            {
                if (rig.linearVelocity.y > 0)
                {
                    rig.linearVelocity = new Vector2(rig.linearVelocity.x, 0);
                }
            }
        }
    }
}
