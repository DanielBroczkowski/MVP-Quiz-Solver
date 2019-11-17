using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_solver
{
    public class Questions  //class describing single question
    {
        public string index { get; set; }
        public string question { get; set; }
        public string ansA { get; set; }
        public string ansB { get; set; }
        public string ansC { get; set; }
        public string ansD { get; set; }
        public string time { get; set; }
        public string valA { get; set; }
        public string valB { get; set; }
        public string valC { get; set; }
        public string valD{ get; set; }


    public Questions(string index, string question, string ansA, string ansB, string ansC, string ansD, string valA, string valB, string valC, string valD, string time)
        {
            this.index = index;
            this.question = question;
            this.ansA = ansA;
            this.ansB = ansB;
            this.ansC = ansC;
            this.ansD = ansD;
            this.valA = valA;
            this.valB = valB;
            this.valC = valC;
            this.valD = valD;
            this.time = time;
        }

        public Questions() { }

        public override string ToString()
        {
            return index + question +  ansA +  ansB +  ansC + ansD + valA + valB + valC + valD + time;
        }
    }
}
