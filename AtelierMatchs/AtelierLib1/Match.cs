using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matchs
{
    public  class Match
    {
        private Club HomeClub, AwayClub;
        private int HomeScore, AwayScore;

        

        public Match(Club Home, Club Away, int HomeGoals, int AwayGoals)
        {
            this.HomeClub = Home;
            this.AwayClub = Away;
            this.HomeScore = HomeGoals;
            this.AwayScore = AwayGoals;
        }
        public  Club Away
        {
            get { return this.AwayClub; }
        }
        public  int AwayGoals
        {
            get { return this.AwayScore; }
        }
        public  Club Home
        {
            get {return this.HomeClub;}
        }
        public  int HomeGoals
        {
            get { return this.HomeScore; }
        }
        public  bool IsAwayForfeit
        {
            get
            {
                if (this.HomeScore < this.AwayScore)
                    return true;
                return false;
            }
        }
        public  bool IsDraw
        {
            get
            {
                if (this.HomeScore == this.AwayScore)
                    return true;
                return false;
            }
        }
        public  bool IsHomeForfeit
        {
            get 
            {
                if (this.HomeScore > this.AwayScore)
                    return true;
                return false;
            }
        }
     
      

    }
}
