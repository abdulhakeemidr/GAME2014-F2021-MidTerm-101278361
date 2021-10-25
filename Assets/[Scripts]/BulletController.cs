/* 
 * Full Name        : Abdulhakeem Idris
 * StudentID        : 101278361
 * Date Modified    : October 19, 2021
 * File             : BulletController.cs
 * Description      : This is the Bullet Controller Script
 * Revision History : Version02
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 
/// The BulletController script translates the bullet horizontally across the screen
/// 
/// </summary>
public class BulletController : MonoBehaviour, IApplyDamage
{
    public float horizontalSpeed = 4;
    public float horizontalBoundary = 10;
    public BulletManager bulletManager;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(horizontalSpeed, 0.0f, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        if (transform.position.x > horizontalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        bulletManager.ReturnBullet(gameObject);
    }

    public int ApplyDamage()
    {
        return damage;
    }
}
