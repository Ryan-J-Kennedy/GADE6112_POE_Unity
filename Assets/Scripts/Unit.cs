﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit
{
    protected string name;
    protected int posX, posY;
    protected int health;
    protected int maxHealth;
    protected int speed;
    protected int attack, attackRange;
    protected string symbol;
    protected Faction factionType;
    protected bool isAttacking;

    public Unit(string n, int x, int y, int hp, int sp, int att, int attRange, string sym, Faction faction, bool isAtt)
    {
        name = n;
        posX = x;
        posY = y;
        health = hp;
        speed = sp;
        attack = att;
        attackRange = attRange;
        symbol = sym;
        factionType = faction;
        isAttacking = isAtt;

        maxHealth = hp;
    }

    public abstract void Move(int type);

    public abstract void Combat(int type);

    public abstract void CheckAttackRange(List<Unit> uni, List<Building> build);

    public abstract Unit ClosestEnemy();

    public abstract bool Death();

    public abstract override string ToString();
}