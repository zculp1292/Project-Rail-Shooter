using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    [Tooltip("In ms^-1")] [SerializeField] float xSpeed = 4f;
    [SerializeField] float ySpeed = 4f;
    [SerializeField] float xLimits = 10f;
    [SerializeField] float yLimits = 10f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float yThrow = CrossPlatformInputManager.GetAxis("Vertical");
        float xOffset = xThrow * xSpeed * Time.deltaTime;
        float yOffset = yThrow * ySpeed * Time.deltaTime;
        float firstYPos = transform.localPosition.y + yOffset;
        float firstXPos = transform.localPosition.x + xOffset;

        float finalYpos = Mathf.Clamp(firstYPos, -yLimits, yLimits);
        float finalXPos = Mathf.Clamp(firstXPos, -xLimits, xLimits);
        transform.localPosition = new Vector3(finalXPos, finalYpos, transform.localPosition.z);


    }
}
