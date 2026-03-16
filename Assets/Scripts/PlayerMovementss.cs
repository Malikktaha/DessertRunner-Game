//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PlayerMovementss : MonoBehaviour
//{
//    public float playerSpeed = 2;
//    public float horizontalSpeed = 3;
//    public float leftLimit = -5.5f;
//    public float rightLimit = 5.5f;
//    [SerializeField] bool isRunning;

//    // Update is called once per frame
//    void Update()
//    {
//        HandleMobileInput();

//        if (isRunning == false)
//        {
//            isRunning = true;
//            StartCoroutine(AddDistance());
//        }

//        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed, Space.World);

//#if UNITY_EDITOR
//        if (Input.GetMouseButton(0))
//        {
//            if (Input.mousePosition.x < Screen.width / 2)
//            {
//                if (transform.position.x > leftLimit)
//                    transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);
//            }
//            else
//            {
//                if (transform.position.x < rightLimit)
//                    transform.Translate(Vector3.right * Time.deltaTime * horizontalSpeed);
//            }
//        }
//#endif

//    }

//    void HandleMobileInput()
//    {
//        if (Input.touchCount > 0)
//        {
//            Touch touch = Input.GetTouch(0);

//            if (touch.position.x < Screen.width / 2)
//                MoveLeft();
//            else
//                MoveRight();
//        }
//    }

//    void MoveLeft()
//    {
//        if (transform.position.x > leftLimit)
//            transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);
//    }

//    void MoveRight()
//    {
//        if (transform.position.x < rightLimit)
//            transform.Translate(Vector3.right * Time.deltaTime * horizontalSpeed);
//    }

//    IEnumerator AddDistance()
//    {
//        yield return new WaitForSeconds(0.35f);
//        MasterInfo.distanceRun += 1;
//        isRunning = false;
//    }
//}
