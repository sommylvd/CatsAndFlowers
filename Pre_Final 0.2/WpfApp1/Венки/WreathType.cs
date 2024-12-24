﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class WreathType
    {
        #region Fields
        private WreathTypeName _nameType;

        private Dictionary<FlowerRarityNaming, int> _flowerRequirements;
        #endregion
        #region Properties
        public WreathTypeName NameType => _nameType;
        public int Details => _flowerRequirements.Count;
        public Dictionary<FlowerRarityNaming, int> FlowersRequirements => _flowerRequirements;
        #endregion
        public WreathType(WreathTypeName wreathType)
        {
            switch (wreathType)
            {
                case WreathTypeName.Easy:
                    _nameType = WreathTypeName.Easy;
                    _flowerRequirements = new Dictionary<FlowerRarityNaming, int> {
                        { FlowerRarityNaming.Common,6 }
                    };
                    break;
                case WreathTypeName.Medium:
                    _nameType = WreathTypeName.Medium;
                    _flowerRequirements = new Dictionary<FlowerRarityNaming, int> {
                        { FlowerRarityNaming.Common,6 },
                        {FlowerRarityNaming.Rare,4 }
                    };
                    break;
                case WreathTypeName.Hard:
                    _nameType = WreathTypeName.Hard;
                    _flowerRequirements = new Dictionary<FlowerRarityNaming, int> {
                        { FlowerRarityNaming.Common,4 },
                        {FlowerRarityNaming.Rare,6 },
                        {FlowerRarityNaming.Elite,2 }
                    };
                    break;
            }
        }
    }
    public enum WreathTypeName
    {
        Easy,
        Medium,
        Hard
    }
}

