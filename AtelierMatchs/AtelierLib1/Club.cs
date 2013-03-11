using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matchs
{
    public class Club
    {
        private string nomClub;

        public Club(string name)
        {
            this.nomClub = name;
        }
        public override string ToString()
        {
            return nomClub.ToString();
        }
      
    }

    
}
