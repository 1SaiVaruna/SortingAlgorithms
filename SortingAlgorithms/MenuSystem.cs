using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class MenuSystem
    {
        string callingClass;
        Dictionary<string, MethodInfo> menuOptions;

        public MenuSystem(string callingClassName)
        {
            callingClass = callingClassName;

            menuOptions = new Dictionary<string, MethodInfo>();

            Type thisType = typeof(Environment);
            AddMenuItem("Exit Application", thisType.GetMethod("Exit"));
        }
    }
}
