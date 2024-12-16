using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATSANDFLOWERS
{
    public interface Workplace
    {
        Bitmap Image { get; set; }
        List<Cat> catsWorkers { get; set; }
    }
}
