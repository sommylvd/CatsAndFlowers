﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public interface IWorkplace
    {
        Bitmap Image { get; set; }
        List<Cat> catsWorkers { get; set; }
    }
}
