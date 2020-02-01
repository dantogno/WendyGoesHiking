using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 5f;

    private PlayerControlActions playerControlActions;
    private float moveX = 0f;
    private float moveY = 0f;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the player controls with default bindings
        playerControlActions = PlayerControlActions.CreateWithDefaultBindings();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = playerControlActions.MoveX;
        moveY = playerControlActions.MoveY;
    }

    private void FixedUpdate()
    {
        MovePlayer(moveX, moveY);
    }

    private void MovePlayer(float _moveX, float _moveY)
    {
        this.transform.Translate(new Vector3(moveX * moveSpeed, 0, moveY  * moveSpeed));
    }
}
