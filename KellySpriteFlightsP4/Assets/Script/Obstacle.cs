using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    float minSize = 0.5f;
    float maxSize = 2.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created yo SHUT UP
    //this script is so stupid and dumb and stupid and idiotic and stupid and i hate fun
    void Start()
    {
        float randomSize = Random.Range(minSize, maxSize);
        transform.localScale = new Vector3(randomSize, randomSize, 1); //i hate fun and i hate this script and i hate this game and i hate this code and i hate this project and i hate this engine and i hate this world and i hate this life and i hate this universe and i hate this existence and i hate this reality and i hate this everything and i hate this nothing and i hate this everythingness and i hate this nothingness and i hate this everythingnessness and i hate this nothingnessness and i hate this everythingnessnessness and i hate this nothingnessnessness and i hate this everythingnessnessnessness and i hate this nothingnessnessnessness and i hate this everythingnessnessnessnessness and i hate this nothingnessnessnessnessness
    }

    // Update is called once per frame NOBODY CARES DUDE SHUT UP!!!!
    void Update()
    {
        
    }
}