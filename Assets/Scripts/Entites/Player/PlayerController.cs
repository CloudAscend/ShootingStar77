using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;

public class PlayerController : MonoBehaviour
{
    //Component;
    private Rigidbody2D rigidbody;
    private PlayerInput playerInput;

    private InputAction moveAction;

    //Script;
    private PlayerShooter playerShooter;
    private PlayerStat playerStat;

    private Vector2 moveVec;

    private float timeRate;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        playerInput = GetComponent<PlayerInput>();

        moveAction = playerInput.actions.FindAction("Move");

        playerShooter = GetComponent<PlayerShooter>();
        playerStat = GetComponent<PlayerStat>();
    }

    private void FixedUpdate()
    {
        PlayerMove();
        PlayerAttack();
    }

    private void PlayerMove()
    {
        moveVec = moveAction.ReadValue<Vector2>();

        rigidbody.velocity = playerStat.moveSpeed * moveVec;
    }

    private void PlayerAttack()
    {
        timeRate += Time.deltaTime;

        if (timeRate < playerStat.attackDelay) return;
        
        timeRate = 0;

        playerShooter.Shoot(playerStat.attackCount, playerStat.attackPower);
    }
}
