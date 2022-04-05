using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleCameraView : MonoBehaviour
{
    GameObject mainCamera;
    GameObject leftCamera;
    GameObject rightCamera;
    GameObject frontFacingCamera;
    GameObject povCamera;
    GameObject eagleEyeCamera;

    GameObject playerToFollow;

    // Start is called before the first frame update
    void Start()
    {
        playerToFollow = GameObject.Find("Player");
        mainCamera = GameObject.Find("Main Camera");
        leftCamera = GameObject.Find("LeftCamera");
        rightCamera = GameObject.Find("RightCamera");
        frontFacingCamera = GameObject.Find("FrontFacingCamera");
        povCamera = GameObject.Find("POVCamera");
        eagleEyeCamera = GameObject.Find("TopAngleCamera");



        /*        leftCamera.SetActive(false);
                rightCamera.SetActive(false);
                frontFacingCamera.SetActive(false);*/
    }

    // Update is called once per frame
    void Update()
    {
/*        mainCamera.transform.LookAt(playerToFollow.transform);
        leftCamera.transform.LookAt(playerToFollow.transform);
        rightCamera.transform.LookAt(playerToFollow.transform);
        frontFacingCamera.transform.LookAt(playerToFollow.transform);
        eagleEyeCamera.transform.LookAt(playerToFollow.transform);*/
        povCamera.transform.LookAt(playerToFollow.transform);
        povCamera.transform.rotation = Quaternion.Euler(0, 0, 0);


        /*        if (Input.GetKey(KeyCode.Keypad1))
                {
                    leftCamera.SetActive(true);


                    mainCamera.SetActive(false);
                    rightCamera.SetActive(false);
                    frontFacingCamera.SetActive(false);
                }

                if (Input.GetKey(KeyCode.Keypad2))
                {
                    rightCamera.SetActive(true);


                    mainCamera.SetActive(false);
                    leftCamera.SetActive(false);
                    frontFacingCamera.SetActive(false);
                }

                if (Input.GetKey(KeyCode.Keypad3))
                {
                    frontFacingCamera.SetActive(true);


                    mainCamera.SetActive(false);
                    rightCamera.SetActive(false);
                    leftCamera.SetActive(false);
                }

                if (Input.GetKey(KeyCode.Keypad4))
                {
                    mainCamera.SetActive(true);
                    //mainCamera.transform.LookAt(playerToFollow.transform);

                    frontFacingCamera.SetActive(false);
                    rightCamera.SetActive(false);
                    leftCamera.SetActive(false);
                }*/

    }
}
