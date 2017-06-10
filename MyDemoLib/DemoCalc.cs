namespace MyDemoLib
{
    public sealed class DemoCalc
    {
        public int ComputeThree()
        {
#if NET20
            return new System.Xml.XmlDocument[3].Length;
#elif NET46
            return new System.Data.DataTable[3].Length;
#elif NETSTANDARD1_0
            return new System.Collections.Generic.HashSet<int> { 1, 2, 3 }.Count;
#elif NETSTANDARD1_3
            return new System.IO.FileInfo[3].Length;
#endif
        }
    }
}
