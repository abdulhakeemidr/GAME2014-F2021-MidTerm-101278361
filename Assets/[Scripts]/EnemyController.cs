/* 
 * Full Name        : Abdulhakeem Idris
 * StudentID        : 101278361
 * Date Modified    : October 19, 2021
 * File             : EnemyController.cs
 * Description      : This is the Enemy Controller Script
 * Revision History : Version02 - 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 
/// The Enemy Controller moves the enemies up and down across the screen
/// 
/// </summary>
public class EnemyController : MonoBehaviour
{
    public float verticalSpeed = 2;
    public float verticalBoundary;
    public float direction;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    // Move function adds verticalSpeed to the y position of the enemy over time
    private void _Move()
    {
        transform.position += new Vector3(0.0f, verticalSpeed * direction * Time.deltaTime, 0.0f);
    }

    // Checkbounds determines if the enemy has exceeded the vertical (y) boundary
    private void _CheckBounds()
    {
        // check right boundary
        if (transform.position.y >= verticalBoundary)
        {
            direction = -1.0f;
        }

        // check left boundary
        if (transform.position.y <= -verticalBoundary)
        {
            direction = 1.0f;
        }
    }
}
