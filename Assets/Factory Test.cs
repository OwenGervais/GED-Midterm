using UnityEngine;

public class FactoryTest : MonoBehaviour
{
    public SimpleFactory Factory;


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            //Create Peach
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Create Bellpepper
        }

        //Should randomly choose between the two after the enemy dies.
    }
}
