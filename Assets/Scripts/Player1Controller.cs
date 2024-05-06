
using UnityEngine;

//
// Atari Combat 1977 v2020.11.26
//
// created 2020.11.26
//

public class Player1Controller : MonoBehaviour
{
    public Transform weaponLauncher;
    public GameObject playerMissile;

    private float fireCounter;
    private float fireRate;

    private float tankSpeed;



    // Start is called before the first frame update
    void Start()
    {
        Initialise();
    }


    // Update is called once per frame
    void Update()
    {
        TankController();

        MissileController();
    }


    private void Initialise()
    {
        tankSpeed = 1f;

        fireRate = 1.2f;
        fireCounter = 0f;
    }


    private void TankController()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * tankSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(0f, 0f, tankSpeed);
        }

        if (Input.GetKey(KeyCode.X))
        {
            transform.Rotate(0f, 0f, -tankSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            FireMissile();
        }
    }


    private void MissileController()
    {
        fireCounter -= Time.deltaTime;
    }


    private void FireMissile()
    {
        if (fireCounter <= 0f)
        {
            Instantiate(playerMissile, weaponLauncher.position, transform.rotation);

            fireCounter = fireRate;
        }
    }


} // end of class
