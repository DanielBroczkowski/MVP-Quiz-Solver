using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Collections;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Timers;
namespace Quiz_solver
{
    class Model
    {
        public List<Questions> listOfQuestions = new List<Questions>();
        private decimal points = 0, l = 0;
        string filePath = string.Empty;

        public List<Questions> ReadXML()
        {
            // Create an instance of the XmlSerializer specifying type and namespace.
            if (l == 0)
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "Pliki XML (*.xml)|*.xml";
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        filePath = openFileDialog.FileName;
                    }
                }
            }
            l=1;

            Console.WriteLine("Reading with XmlReader");
            XmlSerializer serializer = new XmlSerializer(typeof(List<Questions>));

            FileStream fs = new FileStream(filePath, FileMode.Open);
            XmlReader reader = XmlReader.Create(fs);

            List<Questions> list;
            
            list = (List<Questions>)serializer.Deserialize(reader);
            fs.Close();
            return list;
        }

        public decimal Points_summary(decimal i, decimal j, decimal k, decimal l)
        {
            points = points + i+j+k+l;
            Console.WriteLine(points);
            return points; 
        }
    }
}
