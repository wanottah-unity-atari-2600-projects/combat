
using UnityEngine;

//
// Atari Combat 1977 v2020.11.26
//
// created 2020.11.26
//

public class Player2Controller : MonoBehaviour
{
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
    }


    private void Initialise()
    {
        tankSpeed = 1f;
    }


    private void TankController()
    {
    }


} // end of class
