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
        public Serializer()
        {
            
        }


        Stream ISerializer<T>.Serialize(T[] testsToSerialize)
        {
            MemoryStream stream = new MemoryStream();
            XmlSerializer x = new XmlSerializer(typeof(T));
            x.Serialize(stream, testsToSerialize);
            return stream;
        }
    }
}
