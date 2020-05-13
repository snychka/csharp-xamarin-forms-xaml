using System;
using System.Collections.Generic;
using System.Text;

namespace XAMLInXamarinForms.ViewModels
{
    public class PlannerViewModel
    {
        public string Nutrition { get { return String.Format("Nutrition: {0} of {1} calories consumed", NutritionCurrent, NutritionGoal); } }
        public int NutritionCurrent { get; set; } = 1400;
        public int NutritionGoal { get; set; } = 2000;
        public string Fitness { get { return String.Format("Fitness: {0} of {1} calories burned", FitnessCurrent, FitnessGoal); } }
        public int FitnessCurrent { get; set; } = 250;
        public int FitnessGoal { get; set; } = 800;
        public int PassiveBurn { get; set; } = 1200;
        public string EstimatedOutcome { 
            get 
            {
                if (NutritionCurrent - (FitnessCurrent + PassiveBurn) <= 0)
                    return "More calories were burned than consumed.";
                else
                    return "More calories were consumed than burned.";
            } 
        }
    }
}
