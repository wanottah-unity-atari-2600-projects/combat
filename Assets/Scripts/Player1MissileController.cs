
using UnityEngine;

//
// Atari Combat 1977 v2020.11.26
//
// created 2020.11.26
//

public class Player1MissileController : MonoBehaviour
{
    // reference to audio controller script
    //private AudioController audioController;

    private Rigidbody2D bulletRigidbody;

    public GameObject bulletEcho;

    private float bulletSpeed;
    private float timeBetweenSpawns;
    private float startTimeBetweenSpawns;

    private float bulletLifeSpan;
    private float soundLifeSpan;

    private bool playingFireBulletSound;




    private void Awake()
    {
        //audioController = AudioController.instance;
    }


    private void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody2D>();

        Initialise();
    }


    private void FixedUpdate()
    {
        MoveBullet();
    }


    private void Initialise()
    {
        bulletSpeed = 10f;

        bulletLifeSpan = 1.2f;

        soundLifeSpan = bulletLifeSpan;

        playingFireBulletSound = false;

        timeBetweenSpawns = 0f;

        startTimeBetweenSpawns = 0.001f;
    }


    private void MoveBullet()
    {/*
        if (!playingFireBulletSound)
        {
            //audioController.PlayAudioClip("Fire Player Bullet");

            playingFireBulletSound = true;
        }

        soundLifeSpan -= Time.deltaTime;*/

        bulletRigidbody.velocity = transform.right * bulletSpeed;

        //bulletRigidbody.rotation += -PlayerController.playerController.rotationInput * PlayerController.playerController.rotationSpeed;
        /*
        GameController.gameController.ScreenWrap(transform);

        SpawnBulletEcho();*/

        Destroy(gameObject, bulletLifeSpan);
        /*
        if (soundLifeSpan <= 0f)
        {
            //audioController.StopAudioClip("Fire Player Bullet");

            playingFireBulletSound = false;
        }*/
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        
        if (collision.gameObject.CompareTag("Player 2"))
        {
            //audioController.StopAudioClip("Fire Player Bullet");
            //audioController.StopAudioClip("Rotate Ship");
            //audioController.StopAudioClip("Thrusters Engaged");

            //audioController.PlayAudioClip("Explosion");

            //GameController.gameController.enemyDestroyed = true;

            //if (!GameController.gameController.gameOver)
            //{
               //GameController.gameController.UpdatePlayerScore();
            //}
        }
    }


} // end of class
