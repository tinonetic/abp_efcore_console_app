using System;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace MyApp.Console
{
    public class HelloWorldService : ITransientDependency
    {
        private readonly IRepository<MyEntity, Guid> _myEntityRepository;

        public HelloWorldService(IRepository<MyEntity, Guid> myEntityRepository)
        {
            _myEntityRepository = myEntityRepository;
        }
        public void SayHello()
        {
            System.Console.WriteLine("Hello World!");
        }
    }
}
