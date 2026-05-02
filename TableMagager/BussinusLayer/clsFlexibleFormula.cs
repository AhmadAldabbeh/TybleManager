using DataAccesLayer;
using System;


namespace BussinusLayer
{
    public class clsFlexibleFormula
    {
        //public int TableID { get; set; }
        //public int FieldID1 { get; set; }
        //public int? FieldID2 { get; set; }
        //public string OperationType { get; set; }
        //public string FormulaText { get; set; }
        //public string RowName { get; set; }
        //public DateTime? FromDate { get; set; }
        //public DateTime? ToDate { get; set; }
        //public int? EmployeeID { get; set; }
        //public bool IsMonthly { get; set; }
        //public string Mode { get; set; }
        //public DateTime? SpecificDate { get; set; }

        //public double? Result { get; private set; }

        public clsFlexibleFormula()
        {
            //TableID = -1;
            //FieldID1 = -1;
            //FieldID2 = null;
            //OperationType = "";
            //FormulaText = "";
            //RowName = "";
            //FromDate = null;
            //ToDate = null;
            //EmployeeID = null;
            //IsMonthly = false;
            //Mode = null;
            //SpecificDate = null;
            //Result = null;
        }
        // ============================================================
        // 1) حساب فيلد واحد
        // ============================================================
        public static double? CalculateSingleField(
            int tableID,
            int fieldID1,
            string operationType,
            string formulaText,
            DateTime? fromDate,
            DateTime? toDate)
        {
            return clsFormulaData.ExecuteFlexibleFormula(
                tableID,
                fieldID1,
                null,
                operationType,
                formulaText,
                null,
                fromDate,
                toDate,
                null,
                false,
                null,
                null
            );
        }

        // ============================================================
        // 2) حساب فيلد واحد + موظف
        // ============================================================
        public static double? CalculateFieldForEmployee(
            int tableID,
            int fieldID1,
            string operationType,
            string formulaText,
            int employeeID,
            DateTime? fromDate,
            DateTime? toDate)
        {
            return clsFormulaData.ExecuteFlexibleFormula(
                tableID,
                fieldID1,
                null,
                operationType,
                formulaText,
                null,
                fromDate,
                toDate,
                employeeID,
                false,
                null,
                null
            );
        }

        // ============================================================
        // 3) حساب حسب التاريخ + موظف
        // ============================================================
        public static double? CalculateDateForEmployee(
            int tableID,
            int fieldID1,
            string operationType,
            string formulaText,
            int employeeID,
            DateTime fromDate,
            DateTime toDate)
        {
            return clsFormulaData.ExecuteFlexibleFormula(
                tableID,
                fieldID1,
                null,
                operationType,
                formulaText,
                null,
                fromDate,
                toDate,
                employeeID,
                false,
                null,
                null
            );
        }

        // ============================================================
        // 4) حساب بين فيلدين (+ - * /)
        // ============================================================
        public static double? CalculateTwoFields(
            int tableID,
            int fieldID1,
            int fieldID2,
            string operationType,
            string formulaText,
            DateTime? fromDate,
            DateTime? toDate,
            int? employeeID = null)
        {
            return clsFormulaData.ExecuteFlexibleFormula(
                tableID,
                fieldID1,
                fieldID2,
                operationType,
                formulaText,
                null,
                fromDate,
                toDate,
                employeeID,
                false,
                null,
                null
            );
        }

        // ============================================================
        // 5) حساب شهري IsMonthly = true
        // ============================================================
        public static double? CalculateMonthly(
            int tableID,
            int fieldID1,
            string operationType,
            string formulaText,
            DateTime fromDate,
            int? employeeID = null)
        {
            return clsFormulaData.ExecuteFlexibleFormula(
                tableID,
                fieldID1,
                null,
                operationType,
                formulaText,
                null,
                fromDate,
                null,
                employeeID,
                true,
                null,
                null
            );
        }

        // ============================================================
        // 6) AUTO_MONTHLY
        // ============================================================
        public static double? CalculateAutoMonthly(
            int tableID,
            int fieldID1,
            string operationType,
            string formulaText,
            int? employeeID = null)
        {
            return clsFormulaData.ExecuteFlexibleFormula(
                tableID,
                fieldID1,
                null,
                operationType,
                formulaText,
                null,
                null,
                null,
                employeeID,
                false,
                "AUTO_MONTHLY",
                null
            );
        }

        // ============================================================
        // 7) AUTO_WEEKLY
        // ============================================================
        public static double? CalculateAutoWeekly(
            int tableID,
            int fieldID1,
            string operationType,
            string formulaText,
            int? employeeID = null)
        {
            return clsFormulaData.ExecuteFlexibleFormula(
                tableID,
                fieldID1,
                null,
                operationType,
                formulaText,
                null,
                null,
                null,
                employeeID,
                false,
                "AUTO_WEEKLY",
                null
            );
        }

        // ============================================================
        // 8) AUTO_YEARLY
        // ============================================================
        public static double? CalculateAutoYearly(
            int tableID,
            int fieldID1,
            string operationType,
            string formulaText,
            int? employeeID = null)
        {
            return clsFormulaData.ExecuteFlexibleFormula(
                tableID,
                fieldID1,
                null,
                operationType,
                formulaText,
                null,
                null,
                null,
                employeeID,
                false,
                "AUTO_YEARLY",
                null
            );
        }

        // ============================================================
        // 9) SpecificDate → تحويله لشهر كامل
        // ============================================================
        public static double? CalculateSpecificDate(
            int tableID,
            int fieldID1,
            string operationType,
            string formulaText,
            DateTime specificDate,
            int? employeeID = null)
        {
            return clsFormulaData.ExecuteFlexibleFormula(
                tableID,
                fieldID1,
                null,
                operationType,
                formulaText,
                null,
                null,
                null,
                employeeID,
                false,
                null,
                specificDate
            );
        }
    }
}
