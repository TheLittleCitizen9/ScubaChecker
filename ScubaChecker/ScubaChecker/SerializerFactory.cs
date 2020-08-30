using MamasChecker.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScubaChecker
{
    public class SerializerFactory : ISerializerFactory
    {
        public ITestsRunner<T> CreateDeserializer<T>()
        {
            return new TestsRunner<T>();
        }

        public ISerializer<T> CreateSerializer<T>()
        {
            return new Serializer<T>();
        }
    }
}
