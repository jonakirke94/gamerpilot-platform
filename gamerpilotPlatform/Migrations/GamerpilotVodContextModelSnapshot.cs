﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using gamerpilotPlatform.Data;

namespace gamerpilotPlatform.Migrations
{
    [DbContext(typeof(GamerpilotVodContext))]
    partial class GamerpilotVodContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rc1-32029")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("gamerpilotPlatform.Model.Course", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsReleased");

                    b.Property<string>("Name");

                    b.Property<string>("UrlName");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("gamerpilotPlatform.Model.CourseUser", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("CourseId");

                    b.Property<DateTime>("EnrolledAt");

                    b.Property<bool>("IsCompleted");

                    b.HasKey("UserId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseUsers");
                });

            modelBuilder.Entity("gamerpilotPlatform.Model.Instructor", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CourseId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("gamerpilotPlatform.Model.Lectures.CaseSection", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<int?>("CourseCaseId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("CourseCaseId");

                    b.ToTable("CaseSections");
                });

            modelBuilder.Entity("gamerpilotPlatform.Model.Lectures.CompletedLectures", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CourseUserCourseId");

                    b.Property<string>("CourseUserUserId");

                    b.Property<int>("LectureId");

                    b.HasKey("Id");

                    b.HasIndex("CourseUserUserId", "CourseUserCourseId");

                    b.ToTable("CompletedLectures");
                });

            modelBuilder.Entity("gamerpilotPlatform.Model.Lectures.Exercise", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CourseExerciseId");

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.HasIndex("CourseExerciseId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("gamerpilotPlatform.Model.Lectures.LearningGoal", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CourseIntroductionId");

                    b.Property<string>("Goal");

                    b.HasKey("Id");

                    b.HasIndex("CourseIntroductionId");

                    b.ToTable("LearningGoals");
                });

            modelBuilder.Entity("gamerpilotPlatform.Model.Lectures.Lecture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseId");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("InstructorId");

                    b.Property<int>("LectureType");

                    b.Property<string>("Name");

                    b.Property<int>("Section");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("InstructorId");

                    b.ToTable("Lectures");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Lecture");
                });

            modelBuilder.Entity("gamerpilotPlatform.Model.Lectures.Question", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer");

                    b.Property<int?>("CourseQuizId");

                    b.Property<string>("Difficulty");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("CourseQuizId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("gamerpilotPlatform.Model.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("RefreshToken");

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("gamerpilotPlatform.Model.Lectures.CourseCase", b =>
                {
                    b.HasBaseType("gamerpilotPlatform.Model.Lectures.Lecture");

                    b.Property<string>("Description");

                    b.ToTable("CourseCase");

                    b.HasDiscriminator().HasValue("CourseCase");
                });

            modelBuilder.Entity("gamerpilotPlatform.Model.Lectures.CourseExercise", b =>
                {
                    b.HasBaseType("gamerpilotPlatform.Model.Lectures.Lecture");

                    b.Property<string>("Description")
                        .HasColumnName("CourseExercise_Description");

                    b.ToTable("CourseExercise");

                    b.HasDiscriminator().HasValue("CourseExercise");
                });

            modelBuilder.Entity("gamerpilotPlatform.Model.Lectures.CourseInfo", b =>
                {
                    b.HasBaseType("gamerpilotPlatform.Model.Lectures.Lecture");

                    b.Property<string>("CourseLength");

                    b.Property<string>("Language");

                    b.Property<string>("Level");

                    b.Property<string>("LifeSkill");

                    b.ToTable("CourseInfo");

                    b.HasDiscriminator().HasValue("CourseInfo");
                });

            modelBuilder.Entity("gamerpilotPlatform.Model.Lectures.CourseIntroduction", b =>
                {
                    b.HasBaseType("gamerpilotPlatform.Model.Lectures.Lecture");

                    b.Property<string>("Description")
                        .HasColumnName("CourseIntroduction_Description");

                    b.ToTable("CourseIntroduction");

                    b.HasDiscriminator().HasValue("CourseIntroduction");
                });

            modelBuilder.Entity("gamerpilotPlatform.Model.Lectures.CourseQuiz", b =>
                {
                    b.HasBaseType("gamerpilotPlatform.Model.Lectures.Lecture");


                    b.ToTable("CourseQuiz");

                    b.HasDiscriminator().HasValue("CourseQuiz");
                });

            modelBuilder.Entity("gamerpilotPlatform.Model.Lectures.CourseSummary", b =>
                {
                    b.HasBaseType("gamerpilotPlatform.Model.Lectures.Lecture");

                    b.Property<string>("Summary");

                    b.ToTable("CourseSummary");

                    b.HasDiscriminator().HasValue("CourseSummary");
                });

            modelBuilder.Entity("gamerpilotPlatform.Model.Lectures.CourseVideo", b =>
                {
                    b.HasBaseType("gamerpilotPlatform.Model.Lectures.Lecture");


                    b.ToTable("CourseVideo");

                    b.HasDiscriminator().HasValue("CourseVideo");
                });

            modelBuilder.Entity("gamerpilotPlatform.Model.CourseUser", b =>
                {
                    b.HasOne("gamerpilotPlatform.Model.Course", "Course")
                        .WithMany("EnrolledUsers")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("gamerpilotPlatform.Model.User", "User")
                        .WithMany("EnrolledUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("gamerpilotPlatform.Model.Instructor", b =>
                {
                    b.HasOne("gamerpilotPlatform.Model.Course")
                        .WithMany("Instructors")
                        .HasForeignKey("CourseId");
                });

            modelBuilder.Entity("gamerpilotPlatform.Model.Lectures.CaseSection", b =>
                {
                    b.HasOne("gamerpilotPlatform.Model.Lectures.CourseCase")
                        .WithMany("Sections")
                        .HasForeignKey("CourseCaseId");
                });

            modelBuilder.Entity("gamerpilotPlatform.Model.Lectures.CompletedLectures", b =>
                {
                    b.HasOne("gamerpilotPlatform.Model.CourseUser")
                        .WithMany("CompletedLectures")
                        .HasForeignKey("CourseUserUserId", "CourseUserCourseId");
                });

            modelBuilder.Entity("gamerpilotPlatform.Model.Lectures.Exercise", b =>
                {
                    b.HasOne("gamerpilotPlatform.Model.Lectures.CourseExercise")
                        .WithMany("Exercises")
                        .HasForeignKey("CourseExerciseId");
                });

            modelBuilder.Entity("gamerpilotPlatform.Model.Lectures.LearningGoal", b =>
                {
                    b.HasOne("gamerpilotPlatform.Model.Lectures.CourseIntroduction")
                        .WithMany("LearningGoals")
                        .HasForeignKey("CourseIntroductionId");
                });

            modelBuilder.Entity("gamerpilotPlatform.Model.Lectures.Lecture", b =>
                {
                    b.HasOne("gamerpilotPlatform.Model.Course")
                        .WithMany("Lectures")
                        .HasForeignKey("CourseId");

                    b.HasOne("gamerpilotPlatform.Model.Instructor", "Instructor")
                        .WithMany("Lectures")
                        .HasForeignKey("InstructorId");
                });

            modelBuilder.Entity("gamerpilotPlatform.Model.Lectures.Question", b =>
                {
                    b.HasOne("gamerpilotPlatform.Model.Lectures.CourseQuiz")
                        .WithMany("Questions")
                        .HasForeignKey("CourseQuizId");
                });
#pragma warning restore 612, 618
        }
    }
}
