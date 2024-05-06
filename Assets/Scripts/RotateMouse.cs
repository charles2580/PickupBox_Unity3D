using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMouse : MonoBehaviour
{
    private float rotCamXAxisSpeed = 3;
    private float rotCamYAxisSpeed = 3;

    private float eulerAngleX;
    private float eulerAngleY;
    
    
    public void UpdateRotate(float mouseX, float mouseY)
    {
        eulerAngleY += mouseX * rotCamYAxisSpeed;
        eulerAngleX -= mouseX * rotCamXAxisSpeed;

        eulerAngleX = ClampAngle(eulerAngleX, 0, 0);
        transform.rotation = Quaternion.Euler(eulerAngleX, eulerAngleY, 0);   
    }

    private float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360) angle += 360;
        if (angle > 360) angle -= 360;

        return Mathf.Clamp(angle, min, max);
    }
}
