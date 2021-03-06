﻿namespace _04.FirstAndReserveTeam
{
    using System.Collections.Generic;

    public class Team
    {
        private string name;

        private List<Person> firstTeam;

        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
            this.Name = name;
        }

        public string Name
        {
            get => this.name;
            set => name = value;
        }

        public List<Person> FirstTeam
        {
            get => this.firstTeam;
        }

        public List<Person> ReserveTeam
        {
            get => this.reserveTeam;
        }

        public void AddPlayer(Person player)
        {
            if (player.Age < 40)
            {
                firstTeam.Add(player);
            }
            else
            {
                reserveTeam.Add(player);
            }
        }
    }
}
