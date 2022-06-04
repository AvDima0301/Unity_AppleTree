using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    //link to obj
    public GameObject applePrefab;
    //speed
    public float speed = 10f;
    //movement
    public float leftAndRightEnge = 20f;
    //chance of change direction of move
    public float chanceToChangeDirections = 0.01f;
    //frequency of apple drops
    public float secondsBetweenAppleDrops = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropApple", 2);
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", secondsBetweenAppleDrops);
    }

    public void SpeedUpDrop()
    {
        secondsBetweenAppleDrops -= 0.2f;
        speed += 1;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -leftAndRightEnge)
        {
            speed = Mathf.Abs(speed); // move to right
        }
        else if(pos.x > leftAndRightEnge)
        {
            speed = -Mathf.Abs(speed); //move to left
        }
    }

    private void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1;
        }
    }
}
