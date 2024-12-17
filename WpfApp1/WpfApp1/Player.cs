﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Player
    {
        #region Fields
        private double _money;
        private List<Flower> _flowersInStock;
        private List<Cat> _catsInStock;
        private string _name;
        private List<ISkill> _skills;
        #endregion
        #region Properties
        public double Money => _money;
        public List<Flower> FlowersInStock => _flowersInStock;
        public List<Cat> CatsInStock => _catsInStock;
        public string Name => _name;
        public List<ISkill> Skills => _skills;
        #endregion
    }
}
