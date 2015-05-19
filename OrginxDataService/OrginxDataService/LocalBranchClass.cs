using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrginxDataService
{
   public class LocalBranchClass
    {
        private string countrybranchcod;
        private string branchdesc;
        private string branchcity;
        private string branchadmin;

        public string Countrybranchcod
        {
            get { return countrybranchcod; }
            set { countrybranchcod = value; }
        }
        

        public string Branchcity
        {
            get { return branchcity; }
            set { branchcity = value; }
        }
       

        public string Branchadmin
        {
            get { return branchadmin; }
            set { branchadmin = value; }
        }
       

        public string Branchdesc
        {
            get { return branchdesc; }
            set { branchdesc = value; }
        }
    }
}
