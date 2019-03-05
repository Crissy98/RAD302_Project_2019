﻿using System;
using NUnit.Framework;
using StudentAssAttSys.Infrastructure.Repositories;
using StudentAssAttSys.Core.Core;
using Telerik.JustMock;
using System.Collections.Generic;

namespace StudentAssAttSys.Infrastructure.Tests.Repositories
{
    [TestFixture]
    public class ModuleRepositoryTest
    {
        private ModuleRepository Repository = new ModuleRepository();

        [OneTimeSetUp]
        public void InitialeSetup()
        {
            Repository = new ModuleRepository();
        }

        [SetUp]
        public void Setup()
        {
            //Put some Data
            Repository.Add
                ( new Module
                    {
                        Name = "FirstModule",
                        GPAPercentage = 10.00
                    }
                );
        }

        [TearDown]
        public void CleanUp()
        {
            List<Module> modules = Repository.GetAll();

            foreach (Module module in modules)
            {
                Repository.Remove(module);
            }
        }

        [Test]
        public void ShouldAddModule()
        {
            Module module = new Module
            {
                Name = "ShouldAddModuleTest",
                GPAPercentage = 10.00
            };

            int result = Repository.Add(module);
            Assert.That(result, Is.GreaterThan(0));
        }

        [Test]
        public void ShouldGetAllModule()
        {
            List<Module> modules = Repository.GetAll();
            Assert.That(modules.Count, Is.EqualTo(1));
        }

        [Test]
        public void ShouldGetModuleById()
        {
            int moduleId = Repository.Add(new Module { Name = "ShouldGetModuleByIdTest", GPAPercentage = 1.0 });
            Module module = Repository.GetById(moduleId);

            Assert.That(module.Name, Is.EqualTo("ShouldGetModuleByIdTest"));
        }

        [Test]
        public void ShouldEditModule()
        {
            int moduleId = Repository.Add(new Module { Name = "ShouldEditModuleTest", GPAPercentage = 1.0 });
            Module module = Repository.GetById(moduleId);

            module.Name = "ShouldEditModuleTestEdited";

            bool result = Repository.Edit(module);

            Assert.That(result, Is.EqualTo(true));

        }

        [Test]
        public void ShouldDeleteModule()
        {
            Module module = Repository.GetAll().ToArray()[0];

            bool result = Repository.Remove(module);

            Assert.That(result, Is.EqualTo(true));
        }
    }
}
