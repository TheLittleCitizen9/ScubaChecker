using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using MamasChecker.Abstract;

namespace ScubaChecker
{
    public class Serializer<T> : ISerializer<T>
    {
        Stream ISerializer<T>.Serialize(T[] testsToSerialize)
        {
            MemoryStream stream = new MemoryStream();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T[]));
            xmlSerializer.Serialize(stream, testsToSerialize);
            return stream;
        }
    }
}
