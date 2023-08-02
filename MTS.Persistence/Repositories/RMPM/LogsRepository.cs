using Microsoft.EntityFrameworkCore;
using MTS.Application.Contracts.Logging;
using MTS.Domain;
using MTS.Persistence.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Persistence.Repositories.RMPM;


public class LogsRepository : ILogs
{
    private readonly MtstestContext _context;
    private readonly LogData _logData;
    public LogsRepository(MtstestContext context)
    {
        _context = context;

    }

    public async Task<Log> AuditLog(Log log, Log result)
    {
        try
        {
            log.ErrDate = result.ErrDate;
            log.Form_Name = result.Form_Name;
            log.Function_Name = result.Function_Name;
            log.Batch = result.Batch;
            log.Err_Description = result.Err_Description;
            log.Result = result.Result;
            log.PlantCode = result.PLANT;
            log.IP_Address = result.IP_Address;
            log.Username = result.Username;
            log.USER = result.USER;
            log.Application = result.Application;
            await _context.Logs.AddAsync(log);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            await _logData.WriteErrorMsg(DateTime.Now, "AuditLog", "AuditLog", result.Batch,
                ex.Message.ToString(), "", result.PlantCode, result.IP_Address, result.Username, "Application");
        }
        return result;
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
            await _logData.WriteErrorMsg(DateTime.Now, "Write Error Msg", "WriteErrorMsg", batch,
                ex.Message.ToString(), "", plantCode, ipAddres, userName, "Server");
            throw ex;
        }

    }

    public async Task<List<Log>> ReadErrorMsg(Log objTblLog)
    {
        try
        {
            return await _context.Logs.Where(w => w.PlantCode == objTblLog.PlantCode.Trim()).ToListAsync();
        }
        catch (Exception ex)
        {
            await _logData.WriteErrorMsg(DateTime.Now, "Error Log", "ReadErrorMsg", objTblLog.Batch,
                ex.Message.ToString(), "", objTblLog.PlantCode, objTblLog.IP_Address, objTblLog.Username, "Server");
            throw ex;
        }
    }

    public async Task<(bool, string)> DeleteMsg(Log objTblLog)
    {
        var _logData = new LogData(_context);
        bool val = false;
        string msg = string.Empty;
        try
        {
            var tblLogs = await _context.Logs.FindAsync(objTblLog.Sr);
            if (tblLogs != null)
            {
                _context.Logs.Remove(tblLogs);
                await _context.SaveChangesAsync();
                val = true; msg = "success";
                await _logData.WriteErrorMsg(DateTime.Now, "Error Log", "ReadErrorMsg", objTblLog.Batch,
                    "Log Record Deleted", "", objTblLog.PlantCode, objTblLog.IP_Address, objTblLog.Username,
                    "Server");
            }
            else
            {
                val = false; msg = "Record not found";
            }
        }
        catch (Exception ex)
        {
            val = false; msg = "Fail";
            await _logData.WriteErrorMsg(DateTime.Now, "Error Log", "ReadErrorMsg", objTblLog.Batch,
                ex.Message.ToString(), "", objTblLog.PlantCode, objTblLog.IP_Address, objTblLog.Username, "Server");
        }
        return (val, msg);
    }

    public Log GetLogObject()
    {
        return new Log();
    }
}

