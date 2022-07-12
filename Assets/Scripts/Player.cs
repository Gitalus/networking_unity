using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : NetworkBehaviour
{
  float moveSpeed = 20f;

  void HandleMovement()
  {
    if (isLocalPlayer)
    {
      float moveHorizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
      float moveVertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
      Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);
      transform.position += movement;
    }
  }

  void Update()
  {
    HandleMovement();
  }
}
