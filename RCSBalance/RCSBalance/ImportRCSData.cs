using System.Data;
using New_Wrapper;

namespace RCSBalance
{
    public class ImportRCSData
    {
        /// <summary>
        /// File location for RCS extract
        /// </summary>
        /// <returns></returns>
        private string fileLocation()
        {
            string filePath = Properties.Settings.Default.fileLocation;

            return filePath;
        }

        /// <summary>
        /// Takes an input of file location and transforms input into datatable.
        /// </summary>
        /// <param name="filePath">loaction to RCS extract.</param>
        /// <returns></returns>
        public DataTable importDataFromRCS(string filePath)
        {
            DataHandler dataHandler = new DataHandler();

            DataTable RCSToDt = dataHandler.ConvertExcelToDataTable(filePath);

            return RCSToDt;
        }
    }
}
