using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using New_Wrapper;

namespace RCSBalance
{
    public class ImportDataToCompareRCS
    {
        DataHandler dataHandler = new DataHandler();

        public ImportFasterPaymentData ImportFasterPaymentData
        {
            get => default;
            set
            {
            }
        }

        private DataTable ImportSQLData(string filepath, string dateToImport)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Provide a file to be converted into a DataTable.
        /// </summary>
        /// <param name="filepath">Location of Excel workbook to be imported.</param>
        /// <returns>Datatable</returns>
        private DataTable ImportExcelData(string filepath)
        {
            DataTable excelData = dataHandler.ReturnExcelAsDataTable(filepath);

            return excelData;
        }

        private void ImportTextData()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Provide a file to be converted into a DataTable.
        /// </summary>
        /// <param name="filepath">Location of CSV to be imported.</param>
        /// <returns>DataTable</returns>
        private DataTable ImportCSVData(string filepath)
        {
            DataTable csvData = dataHandler.ReturnCSVAsDataTable(filepath, false);

            return csvData;
        }
    }
}