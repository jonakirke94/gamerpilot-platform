﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gamerpilotPlatform.Model
{
    public class Lecture
    {
        public int Id { get; set; }

        public int Order { get; set; }

        public Section Section { get; set; }

        public LectureType LectureType { get; set; }

        public Course Course { get; set; }
        public string CourseId { get; set; }

        public Instructor Instructor { get; set; }
        public string InstructorId { get; set; }

        //public CourseIntroduction CourseIntroduction { get; set; }
        //public string CourseIntroductionId { get; set; }
    };

    public enum Section { Welcome = 1, RealLife, Test, Game, Practice, Summary};

    public enum LectureType { Info, Text = 1, CourseIntroduction, Video, Quiz, Exercise}

}
