﻿using System;
using System.Linq;

namespace TechTalk.SpecFlow.Generator
{
    public class TestGeneratorFactory : ITestGeneratorFactory
    {
        static public readonly Version GeneratorVersion = new Version("1.5.0.0");

        public Version GetGeneratorVersion()
        {
            return GeneratorVersion;
        }

        public ITestGenerator CreateGenerator(SpecFlowConfigurationHolder configurationHolder)
        {
            var container = GeneratorContainerBuilder.CreateContainer(configurationHolder);
            return container.Resolve<ITestGenerator>();
        }
    }
}
