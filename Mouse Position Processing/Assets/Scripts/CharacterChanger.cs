using UnityEngine;

public class CharacterChanger : MonoBehaviour
{
    [SerializeField]
    GameObject prefabCharacter0;
    [SerializeField]
    GameObject prefabCharacter1;
    [SerializeField]
    GameObject prefabCharacter2;
    [SerializeField]
    GameObject prefabCharacter3;

    // need for location of the new character
    GameObject currentCharacter;


    // Start is called before the first frame update
    void Start()
    {
        currentCharacter = Instantiate<GameObject>(
            prefabCharacter0, Vector3.zero,
            Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        // change character on left mouse button
        if (Input.GetMouseButtonDown(0))
        {
            // save position and destroy current character
            Vector3 position = currentCharacter.transform.position;
            Destroy(currentCharacter);

            // instantiate new character
            int prefabNumber = Random.Range(0, 4);
            if(prefabNumber == 0)
            {
                currentCharacter = Instantiate<GameObject>(
                    prefabCharacter0, position,
                    Quaternion.identity);
            }else if(prefabNumber == 1)
            {
                currentCharacter = Instantiate<GameObject>(
                    prefabCharacter1, position,
                    Quaternion.identity);
            }else if(prefabNumber == 2)
            {
                currentCharacter = Instantiate<GameObject>(
                    prefabCharacter2, position,
                    Quaternion.identity);
            }
            else
            {
                currentCharacter = Instantiate<GameObject>(
                    prefabCharacter3, position,
                    Quaternion.identity);
            }
        }
    }
}
