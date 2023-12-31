﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerController : MonoBehaviour
{
    Animator _anim;
    SpriteRenderer _sprite;

    public float maxdist = 10f;
    public float movedist = 2f;
    public float moveTime = 2f;

    // Start is called before the first frame update
    void Awake()
    {
        _anim = GetComponent<Animator>();
        _sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Managers.Game.player.transform.position - transform.position).sqrMagnitude > maxdist)
        {
            transform.position = Managers.Game.player.transform.position;
        }


        if ((Managers.Game.player.transform.position - transform.position).sqrMagnitude > movedist)
        {
            _anim.SetBool("IsMove", true);
            float moveX = Mathf.Lerp(transform.position.x, Managers.Game.player.transform.position.x, moveTime * Time.deltaTime);
            transform.position = new Vector3(moveX, transform.position.y, transform.position.z);
        }
        else
        {
            _anim.SetBool("IsMove", false);
        }



        if (transform.position.x > Managers.Game.player.transform.position.x)
        {
            _sprite.flipX = true;
        }
        else
        {
            _sprite.flipX = false;
        }
    }
}
