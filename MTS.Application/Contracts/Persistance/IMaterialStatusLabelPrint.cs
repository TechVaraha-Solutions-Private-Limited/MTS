using MTS.Application.Features.CommonDto;
using MTS.Application.MappingProfile;
using MTS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Application.Contracts.Persistance
{
    public interface IMaterialStatusLabelPrint
    {
        Task<Tuple<List<SAPQuarantineFromSAP>, List<Quarantines>>> CheckGRNData(Quarantines quarantine);
        Task<List<ITEMMASTER>> GetItemCode(ITEMMASTER _itemMaster, List<ITEMMASTER> ObjItemMaster);
        Task<string> GetPIP(DeviceNPrinter _deviceNPrinter);
        Task<string> GetDevCode(DeviceNPrinter _deviceNPrinter);
        Task<string> GetSerial(Quarantines _quarantines);
        Task<List<Quarantines>> GetMaxQuarantine(Quarantines _quarantines);
        Task<(bool, string)> InsertGradToGradQtWeight(Quarantines _quarantines);
        Task<string> GetCurContN0(GtGWeightTransferDetails _GtGWeightTransferDetails);
        Task<(bool, string)> InsertSerialQT(List<Quarantines> _quarantine, List<SAPQuarantineFromSAP> sAPQuarantinesLst);
        Task<List<SAPQuarantineFromSAP>> GetSAPQuarantine(SAPQuarantine _sapquarantines, List<SAPQuarantineFromSAP> _sapquarantinesList);
        Task<string> PrintQT(QuarantineDTO quarantineDTO);
        List<SAPQuarantine> sapQuarantineList();
        List<SAPQuarantineFromSAP> sapQuarantinefrmSAPList();
        List<QuarantineDTO> QuarantineDTOList();
        List<ITEMMASTER> ITEMMASTERList();
    }
}
