using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Rigidbody2D rb;

    Vector2 movementInput;
    Vector2 smoothedMovementInput;
    Vector2 movementInputSmoothVelocity;

    void Update()
    {
        // Krzysiek: otrzymujemy dane wej�ciowe, np. Horizontal kt�rym b�dzie a i d.
        movementInput.x = Input.GetAxisRaw("Horizontal");
        movementInput.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {

        // Krzysiek: wyt�umaczenie tego znajdziesz tu (1:30 minuta): https://www.youtube.com/watch?v=V3NR1n-UhI0
        // Pomaga to w p�ynnym ruchu postaci przez przej�cie od smoothedMovementInput do celu, kt�rym jest movementInput w 0.1 sekundy
        smoothedMovementInput = Vector2.SmoothDamp(smoothedMovementInput, movementInput, 
            ref movementInputSmoothVelocity, 0.1f);

        rb.velocity = smoothedMovementInput * moveSpeed;
    }
}
