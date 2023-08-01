using MTS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Application.Contracts.Logging;

public interface ILogs
{
    Task<int> WriteErrorMsg(DateTime errorDate, string formName, string functionName, string batch, string errorDescription, string result, string plantCode, string ipAddres, string userName, string application);
    Task<List<Log>> ReadErrorMsg(Log objTblLogs);
    Task<(bool, string)> DeleteMsg(Log objTblLogs);
    Log GetLogObject();
    Task<Log> AuditLog(Log log, Log result);
}
