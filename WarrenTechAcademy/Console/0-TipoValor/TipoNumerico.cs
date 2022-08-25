using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._0_TipoValor
{
    internal class TipoNumerico
    {
        public void Executa()
        {
           // tipos de variáveis númericas

            // byte
            byte byteMin = byte.MinValue; // 0
            byte byteMax = byte.MaxValue; // 255
            System.Console.WriteLine("Byte Min: " + byteMin);
            System.Console.WriteLine("Byte Max: " + byteMax);

            // sbyte
            sbyte sbyteMin = sbyte.MinValue; // -128
            sbyte sbyteMax = sbyte.MaxValue; // 127
            System.Console.WriteLine("Sbyte min: " + sbyteMin);
            System.Console.WriteLine("Sbyte max: " + sbyteMax);

            // short
            short shortMin = short.MinValue; // -32768
            short shortMax = short.MaxValue; // 32767
            System.Console.WriteLine("Short min: " + shortMin);
            System.Console.WriteLine("Short max: " + shortMax);

            // ushort
            ushort ushortMin = ushort.MinValue; // 0
            ushort ushortMax = ushort.MaxValue; // 65535
            System.Console.WriteLine("Ushort min: " + ushortMin);
            System.Console.WriteLine("Ushort max: " + ushortMax);

            // Int16
            Int16 int16Min = Int16.MinValue; //-32768
            Int16 int16Max = Int16.MaxValue;// 32767
            System.Console.WriteLine("Int16 min: " + int16Min);
            System.Console.WriteLine("Int16 max: " + int16Max);

            // Int32
            Int32 int32Min = Int32.MinValue;  //-2147483648
            Int32 int32Max = Int32.MaxValue; // 2147483647
            System.Console.WriteLine("Int32 min: " + int32Min);
            System.Console.WriteLine("Int32 max: " + int32Max);

            // Int64
            Int64 int64Min = Int64.MinValue; // -9223372036854775808
            Int64 int64Max = Int64.MaxValue; // 9223372036854775807
            System.Console.WriteLine("Int64 min: " + int64Min);
            System.Console.WriteLine("Int64 max: " + int64Max);
            
            // int
            int intMin = int.MinValue; // -2147483648
            int intMax = int.MaxValue; //  2147483647
            System.Console.WriteLine("Int min: " + intMin);
            System.Console.WriteLine("Int max: " + intMax);

            // long
            long longMin = long.MinValue; //  -9223372036854775808
            long longMax = long.MaxValue; //  9223372036854775807
            System.Console.WriteLine("Long min: " + longMin);
            System.Console.WriteLine("Long max: " + longMax);

        }
    }
}
