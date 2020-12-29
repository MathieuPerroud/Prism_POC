using System;
using System.Collections.Generic;

namespace Prism_POC.Model.Entities
{
    public class StarWarsEntityList<T>
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public IEnumerable<T> results { get; set; }

        public bool isNext
        {
            get
            {
                return !String.IsNullOrEmpty(next);
            }
        }

        public bool isPrev
        {
            get
            {
                return !String.IsNullOrEmpty(previous);
            }
        }
    }

}
