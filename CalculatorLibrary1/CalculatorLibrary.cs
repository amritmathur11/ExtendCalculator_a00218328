using System;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;

namespace Calculator
{
    public class Calculator
    {
        private static JsonWriter writer;
        public Calculator()
        {
            StreamWriter logFile = File.CreateText("calculatorlog.json");
            logFile.AutoFlush = true;
            writer = new JsonTextWriter(logFile);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartObject();
            writer.WritePropertyName("Operations");
            writer.WriteStartArray();
        }

        public double DoOperation(double value1, double value2, string op)
        {
            double result = double.NaN;
            writer.WriteStartObject();
            writer.WritePropertyName("Operand1");
            writer.WriteValue(value1);
            writer.WritePropertyName("Operand2");
            writer.WriteValue(value2);
            writer.WritePropertyName("Operation");
            switch (op)
            {
                case "A":
                    result = value1 + value2;
                    writer.WriteValue("Add");
                    break;
                case "S":
                    result = value1 - value2;
                    writer.WriteValue("Subtract");
                    break;
                case "M":
                    result = value1 * value2;
                    writer.WriteValue("Multiply");
                    break;
                case "D":
                    if (value2 != 0)
                    {
                        result = value1 / value2;
                        writer.WriteValue("Divide");
                    }
                    break;
                default:
                    break;
            }
            writer.WritePropertyName("Result");
            writer.WriteValue(result);
            writer.WriteEndObject();
            return result;
        }
        
    }

   
}
