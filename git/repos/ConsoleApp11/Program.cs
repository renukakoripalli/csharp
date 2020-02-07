using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAbstract
{
    abstract class Player
    {
        protected string name;
        protected string teamname;
        protected int noofmatches;
        public Player(string name, string teamname, int noofmatches)
        {
            this.name = name;
            this.teamname = teamname;
            this.noofmatches = noofmatches;
        }
        public abstract void DisplayPlayerStatistics();

    }
    class CricketPlayer : Player
    {
        int totalRunsScored;
        int noOfWicketsTaken;
        public CricketPlayer(string name, string teamname, int noofmatches, int totalRunsScored,
            int noOfWicketsTaken) : base(name, teamname, noofmatches)
        {
            this.totalRunsScored = totalRunsScored;
            this.noOfWicketsTaken = noOfWicketsTaken;
        }
        public override void DisplayPlayerStatistics()
        {
            Console.WriteLine("" + name + "\n" + teamname + "\n" + noofmatches + "\n" +
                totalRunsScored + "\n" + noOfWicketsTaken);
        }
    }
    class HockeyPlayer : Player
    {
        int position;
        int noOfgoals;
        public HockeyPlayer(string name, string teamname, int noofmatches, int position,
            int noOfgoals) : base(name, teamname, noofmatches)
        {
            this.position = position;
            this.noOfgoals = noOfgoals;
        }
        public override void DisplayPlayerStatistics()
        {
            Console.WriteLine("" + name + "\n" + teamname + "\n" + noofmatches + "\n" +
                position + "\n" + noOfgoals);
        }
    }


}