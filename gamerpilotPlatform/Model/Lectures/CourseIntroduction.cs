﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gamerpilotPlatform.Model.Lectures
{
    public class CourseIntroduction : Lecture
    {
        public string Description { get; set; }
        public ICollection<LearningGoal> LearningGoals { get; set; }

        public CourseIntroduction()
        {
            LearningGoals = new List<LearningGoal>();
        }
    }
}
