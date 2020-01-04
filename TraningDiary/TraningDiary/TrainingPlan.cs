using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TraningDiary
{
    public class TrainingPlan
    {
        Random random = new Random();
        public Exercises exercises { get; set; }
        public int Series 
        {
            get 
            {
                int NumberOfSeries = random.Next(3, 5);
                return NumberOfSeries;
            }
            
        }
       /**
        public int Reps { get; set; }
        public int Weight { get; set; }
        public int CurrentResults { get; set; }
        **/
        public void Generate()
        {
            
            StreamWriter writer = new StreamWriter(@"c:\TRAINING\TRAINING-FBW.txt");
            writer.WriteLine(Exercises.BenchPress.ToString() + Series.ToString());
            writer.WriteLine(Exercises.Ohp.ToString() + Series.ToString());

            writer.Close();




        }
       
    }
}
