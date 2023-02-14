using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork_14._02._2023
{
    internal interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByValue(bool isAsc);
    }
}
