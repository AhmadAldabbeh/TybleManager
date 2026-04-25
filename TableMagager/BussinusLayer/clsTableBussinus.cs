using DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BussinusLayer
{
    public class clsTableBussinus
    {




        public static DataTable GetAllTableDataWith_ID(int TableNum)
        {
            return clsTableManagerData.GetFullFormTable(TableNum);
        }

//        public static decimal EvaluateFormula(string formula, int tableID, int rowID)
//        {
//            if (string.IsNullOrWhiteSpace(formula))
//                return 0;

//            // 1) معالجة الدوال (SUM, AVG, MIN, MAX, ROUND)
//            formula = ProcessFunctions(formula, tableID, rowID);

//            // 2) استبدال أسماء الأعمدة بقيمها
//            formula = ReplaceFieldsWithValues(formula, tableID, rowID);

//            // 3) حساب النتيجة
//            try
//            {
//                DataTable dt = new DataTable();
//                var result = dt.Compute(formula, "");
//                return Convert.ToDecimal(result);
//            }
//            catch
//            {
//                throw new Exception($"Invalid formula: {formula}");
//            }
//        }
//        private static string ReplaceFieldsWithValues(string formula, int tableID, int rowID)
//        {
//            var matches = Regex.Matches(formula, @"

//\[(.*?)\]

//");

//            foreach (Match match in matches)
//            {
//                string fieldName = match.Groups[1].Value;

//                int fieldID = clsFields.GetFieldIDByName(tableID, fieldName);
//                decimal value = clsFieldValues.GetDecimalValue(tableID, rowID, fieldID);

//                formula = formula.Replace(match.Value, value.ToString());
//            }

//            return formula;
//        }

//        private static string ProcessFunctions(string formula, int tableID, int rowID)
//        {
//            // SUM
//            formula = Regex.Replace(formula, @"SUMRANGE\((.*?)\)", match =>
//            {
//                string fieldName = match.Groups[1].Value.Trim();

//                int fieldID = clsFields.GetFieldIDByName(tableID, fieldName);

//                decimal sum = 0;

//                foreach (int rowID in filteredRows)
//                {
//                    decimal val = clsFieldValues.GetDecimalValue(tableID, rowID, fieldID);
//                    sum += val;
//                }

//                return sum.ToString();
//            });

//            // AVG
//            formula = Regex.Replace(formula, @"AVG\((.*?)\)", match =>
//            {
//                var args = match.Groups[1].Value.Split(',');
//                decimal sum = 0;

//                foreach (var arg in args)
//                {
//                    string cleaned = arg.Trim();
//                    decimal val = EvaluateFormula(cleaned, tableID, rowID);
//                    sum += val;
//                }

//                return (sum / args.Length).ToString();
//            });

//            // MIN
//            formula = Regex.Replace(formula, @"MIN\((.*?)\)", match =>
//            {
//                var args = match.Groups[1].Value.Split(',');
//                decimal min = decimal.MaxValue;

//                foreach (var arg in args)
//                {
//                    decimal val = EvaluateFormula(arg.Trim(), tableID, rowID);
//                    if (val < min) min = val;
//                }

//                return min.ToString();
//            });

//            // MAX
//            formula = Regex.Replace(formula, @"MAX\((.*?)\)", match =>
//            {
//                var args = match.Groups[1].Value.Split(',');
//                decimal max = decimal.MinValue;

//                foreach (var arg in args)
//                {
//                    decimal val = EvaluateFormula(arg.Trim(), tableID, rowID);
//                    if (val > max) max = val;
//                }

//                return max.ToString();
//            });

//            // ROUND
//            formula = Regex.Replace(formula, @"ROUND\((.*?),(.*?)\)", match =>
//            {
//                string expr = match.Groups[1].Value.Trim();
//                int digits = int.Parse(match.Groups[2].Value.Trim());

//                decimal val = EvaluateFormula(expr, tableID, rowID);
//                return Math.Round(val, digits).ToString();
//            });

//            return formula;
//        }

//        public static decimal EvaluateFormulaForRange(string formula, int tableID, List<int> rowIDs)
//        {
//            decimal total = 0;

//            foreach (int rowID in rowIDs)
//            {
//                total += EvaluateFormula(formula, tableID, rowID);
//            }

//            return total;
//        }

    }


}
