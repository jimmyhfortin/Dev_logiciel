using System;

namespace Project
{
    public class Candy
    {
        public string Name { get; private set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public Candy(String name)//initialisation de mon objet/variable Candy
        {
            this.Name = name;//le mot cl� this remplace la variable de type Candy
        }

        public override string ToString()//fonction ToString() qui retourne la nom de la variable de type Candy
        {
            return this.Name;
        }
    }
}
