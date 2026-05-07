using DataAccesLayer;
using System;


namespace BussinusLayer
{
    public class clsFlexibleFormula
    {

        public clsFlexibleFormula()
        {



        }
        // ============================================================
        // 1) حساب فيلد واحد
        // ============================================================
        public static double? CalculateSingleField(
            int tableID,
            int fieldID1,
            string operationType,           
            string formulaText,
            string RowName,
            DateTime? fromDate,
            DateTime? toDate)
        {
            return clsFormulaData.ExecuteFlexibleFormula(
                tableID,
                fieldID1,
                null,
                operationType,
                formulaText,
                RowName,
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
             string RowName,
            int? employeeID,
            DateTime? fromDate,
            DateTime? toDate)
        {
            return clsFormulaData.ExecuteFlexibleFormula(
                tableID,
                fieldID1,
                null,
                operationType,
                formulaText,
                RowName,
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
             string RowName,
            int? employeeID ,
            DateTime fromDate,
            DateTime toDate)
        {
            return clsFormulaData.ExecuteFlexibleFormula(
                tableID,
                fieldID1,
                null,
                operationType,
                formulaText,
                 RowName,
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
             string RowName,
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
                RowName,
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
             string RowName,
            DateTime? fromDate,
            DateTime? ToDate,
            int? employeeID = null)
        {
            return clsFormulaData.ExecuteFlexibleFormula(
                tableID,
                fieldID1,
                null,
                operationType,
                formulaText,
                RowName,
                fromDate,
                ToDate,
                employeeID,
                true,
                null,
                null
            );
        }
        public static double? CalculateMonthly(
           int tableID,
           int fieldID1,
           int? field2,
           string operationType,
           string formulaText,
            string RowName,
           DateTime? fromDate,
           DateTime? ToDate,
           int? employeeID = null)
        {
            return clsFormulaData.ExecuteFlexibleFormula(
                tableID,
                fieldID1,
                field2,
                operationType,
                formulaText,
                RowName,
                fromDate,
                ToDate,
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
             string RowName,
              DateTime? fromDate,
            DateTime? ToDate,
            int? employeeID = null)
        {
            return clsFormulaData.ExecuteFlexibleFormula(
                tableID,
                fieldID1,
                null,
                operationType,
                formulaText,
                RowName,
                fromDate,
                ToDate,
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
             string RowName,
               DateTime? fromDate,
            DateTime? ToDate,
            int? employeeID = null)
        {
            return clsFormulaData.ExecuteFlexibleFormula(
                tableID,
                fieldID1,
                null,
                operationType,
                formulaText,
                RowName,
                fromDate,
                ToDate,
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
             string RowName,
               DateTime? fromDate,
            DateTime? ToDate,
            int? employeeID = null)
        {
            return clsFormulaData.ExecuteFlexibleFormula(
                tableID,
                fieldID1,
                null,
                operationType,
                formulaText,
                RowName,
                fromDate,
                ToDate,
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
             string RowName,
            DateTime specificDate,
            int? employeeID = null)
        {
            return clsFormulaData.ExecuteFlexibleFormula(
                tableID,
                fieldID1,
                null,
                operationType,
                formulaText,
                RowName,
                null,
                null,
                employeeID,
                false,
                null,
                specificDate
            );
        }


    }
    public static class FlexibleFormulaDeleteService
    {
        // ============================================================
        // 1) DeleteSingleRow → حذف صف واحد فقط حسب FormulaID
        // ============================================================
        public static bool DeleteSingleRow(int tableID, int formulaID, int? employeeID = null)
        {
            return clsFormulaData.DeleteFlexibleFormula(
                tableID,
                employeeID,
                formulaID,
                null,
                null,
                null
            );
        }

        // ============================================================
        // 2) DeleteByEmployee → حذف كل النتائج لموظف معيّن
        // ============================================================
        public static bool DeleteByEmployee(int tableID, int employeeID)
        {
            return clsFormulaData.DeleteFlexibleFormula(
                tableID,
                employeeID,
                null,
                null,
                null,
                null
            );
        }

        // ============================================================
        // 3) DeleteByRowName → حذف نتائج RowName معيّن
        // ============================================================
        public static bool DeleteByRowName(int tableID, string rowName)
        {
            return clsFormulaData.DeleteFlexibleFormula(
                tableID,
                null,
                null,
                rowName,
                null,
                null
            );
        }

        // ============================================================
        // 4) DeleteByDateRange → حذف حسب الفترة الزمنية
        // ============================================================
        public static bool DeleteByDateRange(int tableID, DateTime fromDate, DateTime toDate)
        {
            return clsFormulaData.DeleteFlexibleFormula(
                tableID,
                null,
                null,
                null,
                fromDate,
                toDate
            );
        }

        // ============================================================
        // 5) DeleteByEmployeeAndDate → حذف موظف معيّن ضمن فترة
        // ============================================================
        public static bool DeleteByEmployeeAndDate(
            int tableID,
            int employeeID,
            DateTime fromDate,
            DateTime toDate)
        {
            return clsFormulaData.DeleteFlexibleFormula(
                tableID,
                employeeID,
                null,
                null,
                fromDate,
                toDate
            );
        }

        // ============================================================
        // 6) DeleteAllForTable → حذف كل النتائج التابعة لجدول معيّن
        // ============================================================
        public static bool DeleteAllForTable(int tableID)
        {
            return clsFormulaData.DeleteFlexibleFormula(
                tableID,
                null,
                null,
                null,
                null,
                null
            );
        }
    }


}
