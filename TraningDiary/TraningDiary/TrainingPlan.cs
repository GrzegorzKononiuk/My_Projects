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
        public string ExerciseName { get; set; }
        public int Series { get; set; }
        public int Reps { get; set; }
        public int Weight { get; set; }
        public int CurrentResults { get; set; }
        
        public void Generate()
        {
            File.WriteAllText(@"c:\TRAINING\TRAINING-FBW.txt", @"
              
             

            ");
        }
       
    }
}
