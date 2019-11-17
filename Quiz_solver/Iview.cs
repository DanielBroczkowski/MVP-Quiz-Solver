using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_solver
{
    interface IView
    {
        bool end_of_test { get; set; }
        string pytanie {set; }
        string odp1 { set; }
        string odp2 {set; }
        string odp3 {set; }
        string odp4 {set; }

        decimal num1 { get; set; }
        decimal num2 { get; set; }
        decimal num3 { get;  set; }
        decimal num4 { get;  set; }
        decimal points { set; }
        decimal time {set; }

        event Action Points_summary;
        event Action New_Question;
    }
}
