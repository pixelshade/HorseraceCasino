using UnityEngine;

public class Horse
{
    public string Name = "NoName";
    public string Sprite = "NoSprite";
    public float Speed = 1f;
    public float Luck = 0f;
    public float Condition = 1f;
    public float Bonus = 1f;

    public Horse()
    {

    }

    public Horse(string name, string sprite, float speed, float luck, float condition)
    {
        Name = name;
        Sprite = sprite;
        Speed = speed;
        Luck = luck;
        Condition = condition;
    }


    public float GetPos()
    {
        float bonus = 0;
        if(Random.Range(0,1) > Luck)
        {
            bonus = Bonus;
        }
        return Speed * Condition + bonus;
    }

    
    public override string ToString()
    {
        return Name+" sprite:'"+ "' speed:'"+ Speed + "' Luck:'"+ Luck+"' Condition:'"+Condition+"'";
    }
}