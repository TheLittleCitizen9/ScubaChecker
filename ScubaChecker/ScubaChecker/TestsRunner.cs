using MamasChecker.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ScubaChecker
{
    public class TestsRunner<T> : ITestsRunner<T>
    {
        public T[] Deserialize(Stream stream)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            stream.Seek(0, SeekOrigin.Begin);
            object obj = xmlSerializer.Deserialize(stream);
            return (T[])obj;
        }
    }
}
