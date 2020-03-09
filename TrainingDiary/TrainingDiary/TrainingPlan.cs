using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrainingDiary
{
    public class TrainingPlan
    {
        Random random = new Random();
        public Exercises exercises
        {
            get
            {
                Array values = Enum.GetValues(typeof(Exercises));
                Exercises randomBar = (Exercises)values.GetValue(random.Next(values.Length));
                return randomBar;
            }


        }
        public int Series
        {
            get
            {
                int NumberOfSeries = random.Next(3, 5);
                return NumberOfSeries;
            }

        }
        public int Reps
        {
            get
            {
                int NumberOfReps = random.Next(4, 12);
                return NumberOfReps;
            }
        }
        public int Weight
        {
            get
            {

                int Weight = random.Next(50, 80);
                return Weight;
            }
        }
    }
}