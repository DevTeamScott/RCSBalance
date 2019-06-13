using System;
using New_Wrapper;
using System.Data;
using System.Collections.Generic;

namespace RCSBalance
{
    public class ImportFasterPaymentData
    {
        DataHandler dataHandler = new DataHandler();

        private int ReturnIdFromFp(DateTime date)
        {
            int linkedId = dataHandler.RunStoredProcedure(ref date, connectionString:"", ReturnIdFromFpDb);

            return linkedId;
        }

        /// <summary>
        /// return single day of data. 
        /// 
        /// </summary>
        /// <param name="linkedId"></param>
        /// <returns></returns>
        private DataTable ReturnFpByDay(int linkedId)

        {
            DataTable FpByDay = dataHandler.RunStoredProcedure(ref linkedId, connectionString:"", ReturnFpDataByDayDb);

            return FpByDay;
        }

        /// <summary>
        /// return a date range for use with weekly and monthly comparissions. 
        /// </summary>
        /// <param name="linkedId">returns a date ...kinda</param>
        /// <returns></returns>
        private DataTable ReturnFpByDateRange(int linkedId)
        {
            DataTable FpByDateRange = dataHandler.RunStoredProcedure(ref linkedId, connectionString:"", ReturnFpDataByDateRangeDb);

            return FpByDateRange;
        }
    }
}