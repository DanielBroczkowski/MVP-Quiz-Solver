using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_solver
{
    class Presenter
    {
        private int index = 0;
        IView view;
        Model model;
        List<Questions> list;
        public Presenter(IView view, Model model)
        {
            this.view = view;
            this.model = model;
            this.view.New_Question += Next_Question;
            this.view.Points_summary += Points_summary;
        }

        private void Next_Question()
        {
            list = model.ReadXML();
            try
            {
                view.num1 = Decimal.Parse(list[index].valA);
                view.num2 = Decimal.Parse(list[index].valB);
                view.num3 = Decimal.Parse(list[index].valC);
                view.num4 = Decimal.Parse(list[index].valD);
                view.odp1 = list[index].ansA;
                view.odp2 = list[index].ansB;
                view.odp3 = list[index].ansC;
                view.odp4 = list[index].ansD;
                view.pytanie = list[index].question;
                view.time = Decimal.Parse(list[index].time);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                
            }
            index++;
            if (index == list.Count)
            {
                view.end_of_test = true;
            }
        }
        private void Points_summary()
        {
            view.points = model.Points_summary(view.num1, view.num2, view.num3, view.num4);
        }
    }
}
