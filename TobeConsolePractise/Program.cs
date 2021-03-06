﻿using Autofac;
using Autofac.Extras.CommonServiceLocator;
using CommonServiceLocator;
using Quartz.Spi;
using System;
using TobeConsolePractise.QuartzJob;

namespace TobeConsolePractise
{
    /// <summary>
    /// Main console app
    /// </summary>
    /// <param name="args"></param>
    /// <devdoc>Really cool, aint it</devdoc>
    class Program
    {
        public static void Main(string[] _)
        {
            using (var scope = Container)
            {
                scope.Resolve<Application>().Run();
                Console.ReadKey();
            }
        }

        private static IContainer _container;
        public static IContainer Container
        {
            get
            {
                if (_container == null)
                {
                    _container = GetContainer();
                    ServiceLocator.SetLocatorProvider(() => new AutofacServiceLocator(_container));
                }

                return _container;
            }
        }

        public static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MyJob>().AsSelf();
            builder.RegisterType<MyMailJob>().AsSelf();
            builder.RegisterType<MyJobFactory>().As<IJobFactory>();
            builder.RegisterType<MyScheduler>().AsSelf();

            builder.RegisterType<Application>().AsSelf();

            return builder.Build();
        }
    }

    class Application
    {
        public Application(IComponentContext _)
        {
        }

        public void Run()
        {
            //MergeSort.Run();
            //ShellSort.Run();
            //BetweenTwoSets.Run();
            //BreakingRecords.Run();
            //NodeTest.Run();
            //TaskTest.Run();    
            //BalancedBrackets.Run();
            //MaxTriangles.Run();
            //LargestPrimeFactor.Run();
            //IntPtrReverse.Run();
            //ThreadTest.Run();  
            //StackCheck.Run();
            //TestMathLibrary.Run();
            //GenericsTest.Run();
            ////LinqToSql.Run();
            //DiPractise.Run();
            //AddShift.Run();
            //Serialization.DtoSerialize.Run();
            //Join.Run();
            //Cousant.EncryptDecrypt.Run();
            //Mapping_EF.PractiseEf.Run();
            //new Mapping_EF.TestService().UpdateStudent_Did_Update();
            //WebServices.IntegrationJavaSoap.Run();
            //DataStructures.SinglyLinkedList.Run();
            //Scheduling.Job.Run();
            //TaskTest.Run().Wait();
            //context.Resolve<MyScheduler>().Run().Wait();
            //HoneyPot.Challenges.Run();
            //EMail.TestSmtpMailServer.Run();
            //ThreadTiming.Run()
            //LargestPrimeFactor.Run(6857);
            //Observables.Run();
            //FluentValidatorTest.Run();
            //PostSharpTest.Run();
        }
    }
}