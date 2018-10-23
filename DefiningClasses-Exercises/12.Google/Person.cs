﻿namespace DefiningClasses
{
    using System.Collections.Generic;

    public class Person
    {
        private string name;
        private Company company;
        private List<Pokemon> pokemons;
        private List<Parent> parents;
        private List<Child> children;
        private Car car;


        public Person(string name)
        {
            this.Name = name;
            this.Company = new Company();
            this.Car = new Car();
            this.Pokemons = new List<Pokemon>();
            this.Parents = new List<Parent>();
            this.Children = new List<Child>();
        }


        public string Name { get => name; set => name = value; }
        public Company Company { get => company; set => company = value; }
        public List<Pokemon> Pokemons { get => pokemons; set => pokemons = value; }
        public List<Parent> Parents { get => parents; set => parents = value; }
        public List<Child> Children { get => children; set => children = value; }
        public Car Car { get => car; set => car = value; }
    }
}
