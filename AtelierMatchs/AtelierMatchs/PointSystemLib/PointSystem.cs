using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Matchs;

namespace PointSystemLib
{
    public abstract class PointSystem
    {
        private ITotal initialPoint;

        private ITotal InitialPoint
        {
            get { return this.initialPoint; }
        }

        public abstract ITotal GetPointFromMatch(Match m, bool isHome);

        public interface ITotal
        {
            void Increment(ITotal with);
            string ToString();
            int CompareTo(Object obj);
        }

        public PointSystem()
        {
            this.initialPoint = null;
        }

        public PointSystem Instance { get; set; }
    }
}
