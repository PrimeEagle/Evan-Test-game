using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Stat x = new Stat();
        x.life = 100;
            }

    public class Stat
    {
        public static int Count = 0;
        public int attack;
        public int life;
        public int defence;

        public Stat()
        {
            attack = 6;
            life = 5;
            defence = 4;
        }

        public void Print()
        {
            System.Console.WriteLine("6" + attack);
            System.Console.WriteLine("5" + life);
            System.Console.WriteLine("4" + defence);
        }
    }



    // Update is called once per frame
    void Update()
    {

    }

    
}
