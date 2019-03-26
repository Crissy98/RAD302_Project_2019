﻿using StudentAssAttSys.Core.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAssAttSys.Infrastructure.Tests
{
    public static class InfrastructureTestsSeed
    {

        public static void SeedAll(StudentAssAttSysContext db)
        {
            SeedStudents(db);
            SeedLecturers(db);
            SeedModules(db);
            SeedLinks(db);
        }

        public static void SeedStudents(StudentAssAttSysContext db)
        {
            db.Students.AddRange(new List<Student>()
            {
                new Student
                {
                    Id = "S80611",
                    FirstName = "Joe",
                    LastName = "Test",
                    StudentNumber = "S80611",
                    Email = "S80611@mail.itsligo.ie"
                },
                new Student
                {
                    Id = "S47223",
                    FirstName = "Brenda",
                    LastName = "Test",
                    Email = "S47223@mail.itsligo.ie",
                    StudentNumber = "S47223"
                }
            });
        }

        public static void SeedLecturers(StudentAssAttSysContext db)
        {
            db.Lecturers.AddRange(new List<Lecturer>()
            {
                new Lecturer
                {
                    Id = "JLect",
                    FirstName = "John",
                    LastName = "Test",
                    Email = "john.test@mail.itsligo.ie"
                },
                new Lecturer
                {
                    Id = "BLect",
                    FirstName = "Bali",
                    LastName = "Test",
                    Email = "bali.test@mail.itsligo.ie"
                }
            });
        }

        public static void SeedModules(StudentAssAttSysContext db)
        {
            db.Modules.AddRange(new List<Module>()
            {
                new Module
                {
                    Name = "Module 1",
                    GPAPercentage = 20.0
                },
                new Module
                {
                    Name = "Module 2",
                    GPAPercentage = 50.0
                }
            });
        }

        public static void SeedLinks(StudentAssAttSysContext db)
        {
            Module[] modules = db.Modules.ToArray();
            int n = 1;
            foreach (Module module in modules)
            {
                if(module.Lecturers == null)
                {
                    module.Lecturers = new List<Lecturer>();
                }

                if (module.Students == null)
                {
                    module.Students = new List<Student>();
                }

                if (n == 1)
                {
                    module.Lecturers.AddRange(db.Lecturers.ToList());
                    module.Students.AddRange(db.Students.ToList());
                }
                else
                {
                    module.Lecturers.Add(db.Lecturers.FirstOrDefault());
                    module.Students.Add(db.Students.FirstOrDefault());
                }

                n++;
            }
        }
    }
}
