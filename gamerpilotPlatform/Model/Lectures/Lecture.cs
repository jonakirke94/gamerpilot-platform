﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gamerpilotPlatform.Model.Lectures
{
    public class Lecture
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int DisplayOrder { get; set; }

        public Section Section { get; set; }

        public LectureType LectureType { get; set; }

        public Instructor Instructor { get; set; }
        public int? InstructorId { get; set; }
    };

    public enum Section { Welcome = 1, RealLife, Quiz, Game, Practice, Summary};

    public enum LectureType { Info = 1, CourseIntroduction, Case, Video, Quiz, Practice, Summary}

}
