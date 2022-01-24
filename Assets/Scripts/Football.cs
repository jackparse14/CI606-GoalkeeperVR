using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Football : MonoBehaviour
{
    private Rigidbody rb;
    private float shotPowerForward;
    private float shotPowerUp;
    private float shotPowerLeftRight;
    private AudioSource audioSrc;
    [SerializeField]
    private AudioClip[] ballKicks;
    private int ballKicksIndex = 0;
    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        shotPowerForward = CreateRand(12f,15f);
        shotPowerUp = CreateRand(4f,6.5f);
        float leftRightMidChoose = CreateRand(0f, 5f);
        if (leftRightMidChoose <= 2.5)
        {
            shotPowerLeftRight = CreateRand(-3f, -2f);
        }
        else if (leftRightMidChoose >= 3)
        {
            shotPowerLeftRight = CreateRand(2f, 3f);
        }
        else {
            shotPowerLeftRight = CreateRand(-1.5f, 1.5f);
        }
        
        StartCoroutine(Shoot());
        StartCoroutine(DespawnSelf());
    }
    private float CreateRand(float min, float max) {
        float randNum = Random.Range(min,max);
        return randNum;
    }

    private void playBallKick() {
        audioSrc.PlayOneShot(ballKicks[ballKicksIndex]);
        ballKicksIndex++;
        if (ballKicksIndex > ballKicks.Length) {
            ballKicksIndex = 0;
        }
    }

    IEnumerator Shoot() {
        yield return new WaitForSeconds(3f);
        rb.AddForce(transform.forward * shotPowerForward, ForceMode.Impulse);
        rb.AddForce(transform.up * shotPowerUp, ForceMode.Impulse);
        rb.AddForce(Vector3.left * shotPowerLeftRight, ForceMode.Impulse);
        playBallKick();
    }
    IEnumerator DespawnSelf() {
        yield return new WaitForSeconds(3f);
        Destroy(this);
    }
}
