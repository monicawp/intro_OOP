﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro_OOP
{
    class cat
    {
        //states
        //fields 
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;



        //properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; } 
        } 

        //behaviors

        //constructors
        public cat()
        {
            //default contructor because it takes no 
            // parameters in the parentheses 
        }

        public cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor; 
        }

        //methods

        public void Eat()
        {
            if(isHungry = true)
            {
                isHungry = false;
            }

            Console.WriteLine("Is the cat hungry? " + isHungry); 
        }

        public void WorkOut()
        {
            if(isHungry == false)
            {
                isHungry = true;

            }
            Console.WriteLine("The cat worked out. Hungry now? " + isHungry); 
        }











    }
}
