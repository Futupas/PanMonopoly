using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace PanMonopoly
{
    class Monopoly
    {
        public Website GameWebsite;
        public Player[] Players;
        public int CurrentUser;
        public Monopoly(string[] prefixes, string[] users)
        {
            CurrentUser = 0;
            Player[] players = new Player[users.Length];
            for (int i = 0; i < users.Length; i++)
            {
                players[i] = new Player(users[i]);
            }
            this.Players = players;
            this.GameWebsite = new Website(prefixes, OnRequest);

            GameWebsite.Start();
        }
        ~Monopoly()
        {
            GameWebsite.Stop();
        }
        public string OnRequest(ref HttpListenerContext context)
        {
            return "";
        }
    }
    public class Player
    {
        public readonly string Name;
        private int sum;
        public int Sum {
            get { return sum; }
            set { sum = value; }
        }
        public Player(string name)
        {
            this.Name = name;
        }
    }
    public abstract class Field
    {
        public enum FieldType
        {
            City,
            Company,
            Start,
            Prison,
            Tax,
            Else,
            Chance,
            PublicTreasury,
            Base
        }
        public const FieldType Type = FieldType.Base;
        public abstract void WhenCame(Player player);

    }
    public class CityField : Field
    {
        public new const FieldType Type = FieldType.City;
        public override void WhenCame(Player player)
        {

        }
    }
}
