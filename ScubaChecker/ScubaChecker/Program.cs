using MamasChecker.Abstract;
using System;
using System.Linq;

namespace ScubaChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestCase testCase = new TestCase();
            testCase.TestContent = "Dar";
            testCase.Id = 9;
            TestCase testCase2 = new TestCase();
            testCase2.TestContent = "Arad";
            testCase2.Id = 19;
            TestCase testCase3 = new TestCase();
            testCase3.TestContent = "Idan";
            testCase3.Id = 1;

            SerializerFactory _serializerFactory = new SerializerFactory();
            Console.WriteLine("Serializnig and Deserializing TestContent");
            var stringSerializer = _serializerFactory.CreateSerializer<TestCase>();
            var stringDeserializer = _serializerFactory.CreateDeserializer<TestCase>();

            var testCaseArray = new TestCase[] { testCase, testCase2, testCase3 };
            TestCase[] stringResult = stringDeserializer.Deserialize(stringSerializer.Serialize(testCaseArray));
            Console.WriteLine(stringResult.SequenceEqual(testCaseArray));
        }
    }
}
