using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToPlayer : MonoBehaviour {

    public Transform player;
    public float speed;

    void Update()
    {
            Vector3 targetDir = player.position - transform.position;

            float turnStep = speed * Time.deltaTime;

            Vector3 towardsPlayer = Vector3.RotateTowards(transform.forward, targetDir, turnStep, 0.0F);

          //  Debug.DrawRay(transform.position, towardsPlayer, Color.red);

            transform.rotation = Quaternion.LookRotation(towardsPlayer);
    }
}
