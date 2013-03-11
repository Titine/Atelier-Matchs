using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using PointSystemLib;
using Matchs;
using TestRanking;
using SoccerRankingLib;

namespace FrenchLeague1PointSystemLib
{
    public class FrenchLigue1PointSystem : PointSystem
    {
        public class TotalPoints : ITotal
        {
            private int goalaverage = 0;
            private int points;

            public TotalPoints()
            {
                this.points = 0;
            }
            public TotalPoints(Match m, bool home)
            {
                this.points = m.HomeGoals - m.AwayGoals;
                this.goalaverage += this.points;
            }
            public void Increment(ITotal point)
            {
                this.points += ((TotalPoints)point).points;
            }
            public int CompareTo(object obj)
            {
                return this.points - ((TotalPoints)obj).points;
            }
        }

        private static FrenchLigue1PointSystem theInstance = new FrenchLigue1PointSystem();

        public ITotal initialPoint
        {
            get { return new TotalPoints();}
        }
        public static PointSystem Instance
        {
            get { return theInstance;}
        }
        public override PointSystem.ITotal  GetPointFromMatch(Match m, bool isHome)
        {
 	        return new TotalPoints(m , isHome);
        }
        public override string  ToString()
        {
 	         return base.ToString();
        }
    }
}
