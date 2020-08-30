using MamasChecker.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ScubaChecker
{
    [Serializable()]
    public class TestCase : ITestCase
    {
        public string TestContent { get; set; }
        public int Id { get; set; }
        public bool Run()
        {
            return true;
        }

        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(TestContent, Id);
        }
    }
}
