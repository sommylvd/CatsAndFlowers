using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATSANDFLOWERS
{
    public class WreathType
    {
        #region Fields
        private string _nameType; //будет енам
        private int _details; //не придумали еще
        private List<Flower> _flowersRequirements;
        #endregion
        #region Properties
        public string NameType => _nameType;
        public int Details => _details;
        public List<Flower> FlowersRequirements => _flowersRequirements;
        #endregion
    }
}
