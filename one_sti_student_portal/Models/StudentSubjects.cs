﻿// Decompiled with JetBrains decompiler
// Type: one_sti_student_portal.Models.StudentSubjects
// Assembly: one_sti_student_portal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 39E34984-485E-45CE-9895-F7524E3024D6
// Assembly location: \\wsl.localhost\kali-linux\root\One STI Student Portal_1.3.8_apkcombo.com (1)\unknown\assemblies\one_sti_student_portal.dll

using SQLite;
using System;

namespace one_sti_student_portal.Models
{
  public class StudentSubjects
  {
    [PrimaryKey]
    [AutoIncrement]
    public int Id { get; set; }

    public string PSCSId { get; set; }

    public string Semester { get; set; }

    public string SemesterDesc { get; set; }

    public string ClassNumber { get; set; }

    public string CourseCareer { get; set; }

    public string SubjectCode { get; set; }

    public string SubjectDesc { get; set; }

    public string Professor { get; set; }

    public string FinalGrade { get; set; }

    public DateTime DatePosted { get; set; }

    public DateTime UpdatedOn { get; set; }
  }
}