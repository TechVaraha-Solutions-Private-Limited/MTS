using MTS.Domain;
using MTS.Persistence.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Persistence.Repositories.RMPM;


public class LogData
{
    private readonly MtstestContext _context;
    public LogData(MtstestContext context)
    {
        _context = context;
    }
    public async Task<int> WriteErrorMsg(DateTime errorDate, string formName, string functionName, string batch, string errorDescription, string result, string plantCode, string ipAddres, string userName, string application)
    {

        try
        {
            Log objLog = new Log()
            {
                ErrDate = errorDate,
                Form_Name = formName,
                Function_Name = functionName,
                Batch = batch,
                Err_Description = errorDescription,
                Result = result,
                PlantCode = plantCode,
                IP_Address = ipAddres,
                Username = userName,
                Application = application
            };
            await _context.Logs.AddAsync(objLog);
            var result1 = _context.SaveChanges();
            return result1;
        }
        catch (Exception ex)
        {

            throw ex;
        }

    }


}

