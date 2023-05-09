using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeLists.Codes
{
    public class SolutionOne
    {
        public List<int> MergeListsIntoOneList(List<int> list1, List<int> list2)
        {
            list1.AddRange(list2);
            list1.Sort();
            return list1;
        }
    }
}
