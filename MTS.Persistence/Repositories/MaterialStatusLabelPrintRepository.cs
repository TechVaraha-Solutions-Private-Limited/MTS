using Microsoft.Extensions.Configuration;
using MTS.Application.Contracts.Logging;
using MTS.Application.Contracts.Persistance;
using MTS.Application.Features.CommonDto;
using MTS.Application.Shared;
using MTS.Domain;
using MTS.Persistence.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MTS.Application.Shared.Common;

namespace MTS.Persistence.Repositories
{
    public class MaterialStatusLabelPrintRepository : IMaterialStatusLabelPrint
    {
        private readonly MtstestContext _context;
        private readonly ILogs _logsRepository;
        private readonly IConfiguration configuration;
        List<SAPQuarantine> sAPQuarantinesList;
        List<SAPQuarantineFromSAP> sAPQuarantinesListSAP;
        DataSet ds = new DataSet();

        public MaterialStatusLabelPrintRepository(MtstestContext context, ILogs logsRepository, IConfiguration configuration)
        {
            this._context = context;
            this._logsRepository = logsRepository;
            this.configuration = configuration;
        }
        public Task<Tuple<List<SAPQuarantineFromSAP>, List<Quarantines>>> CheckGRNData(Quarantines quarantine)
        {
            if (quarantine.PLANT == EnumHelper<PlantCode>.GetDisplayValue(PlantCode.Plant6))
            {
                if (quarantine.GRNNO.Split(',').Length == 2)
                {
                    quarantine.GRNNO = quarantine.GRNNO.Split(',')[0];
                }
            }
            else if (quarantine.PLANT == EnumHelper<PlantCode>.GetDisplayValue(PlantCode.Plant11))
            {
                if (quarantine.GRNNO.Split(',').Length == 2)
                {
                    quarantine.GRNNO = quarantine.GRNNO.Split(',')[0];
                }
            }
            else if (quarantine.PLANT == EnumHelper<PlantCode>.GetDisplayValue(PlantCode.Plant3))
            {
                if (quarantine.GRNNO.Split(',').Length == 2)
                {
                    quarantine.GRNNO = quarantine.GRNNO.Split(',')[0];
                }
            }
            else if (quarantine.PLANT == EnumHelper<PlantCode>.GetDisplayValue(PlantCode.Plant14))
            {
                if (quarantine.GRNNO.Split(',').Length == 2)
                {
                    quarantine.GRNNO = quarantine.GRNNO.Split(',')[0];
                }
            }
            var result = new Tuple<List<SAPQuarantineFromSAP>, List<Quarantines>>(null, null);

            List<Quarantines> GRNData = QuarantinesList();
            List<ITEMMASTER> ObjItemMaster = ITEMMASTERList();
            try
            {
                sAPQuarantinesListSAP = sapQuarantinefrmSAPList();

                GRNData = _context.Quarantines.Where(x => x.GRNNO == quarantine.GRNNO).Distinct().ToList();
                SAPQuarantine sAPQuarantine = objsapQuarantine();
                sAPQuarantine.MBLNR = quarantine.GRNNO;
                sAPQuarantinesListSAP = await GetSAPQuarantine(sAPQuarantine, sapQuarantinefrmSAPList());
                if (sAPQuarantinesListSAP.Count > 0)
                {

                    //result = new Tuple<List<Quarantines>, List<SAPQuarantineFromSAP>>(null, sAPQuarantinesListSAP);

                }
                if (GRNData.Count != 0)
                {
                    if (quarantine.PLANT == EnumHelper<PlantCode>.GetDisplayValue(PlantCode.Plant24))
                    {
                        await UpdateQuarantineTable(sAPQuarantinesListSAP, ObjItemMaster);
                    }

                }
                result = new Tuple<List<SAPQuarantineFromSAP>, List<Quarantines>>(sAPQuarantinesListSAP, GRNData);


            }
            catch (Exception ex)
            {
                await _logsRepository.WriteErrorMsg(DateTime.Now, "MaterialStatusLabelPrintRepository", "CheckGRNData", quarantine.GRNNO,
                     ex.Message.ToString(), "", quarantine.PLANT, quarantine.DeviceIP, quarantine.USER, "Server");
                //throw ex;
            }
            return result;
        }

        public Task<string> GetCurContN0(GtGWeightTransferDetails _GtGWeightTransferDetails)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetDevCode(DeviceNPrinter _deviceNPrinter)
        {
            throw new NotImplementedException();
        }

        public Task<List<ITEMMASTER>> GetItemCode(ITEMMASTER _itemMaster, List<ITEMMASTER> ObjItemMaster)
        {
            throw new NotImplementedException();
        }

        public Task<List<Quarantines>> GetMaxQuarantine(Quarantines _quarantines)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetPIP(DeviceNPrinter _deviceNPrinter)
        {
            throw new NotImplementedException();
        }

        public Task<List<SAPQuarantineFromSAP>> GetSAPQuarantine(SAPQuarantine _sapquarantines, List<SAPQuarantineFromSAP> _sapquarantinesList)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var SAPUrl = configuration.GetValue<string>("AppIdentitySettings:SAPUrl:SAPUrl");

                    using (var response = await httpClient.GetAsync(SAPUrl + "GetSAPQuarantine/" + sAPQuarantine.MBLNR))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        reservationList = JsonConvert.DeserializeObject<List<SAPQuarantineFromSAP>>(apiResponse);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return await Task.FromResult(reservationList);
        }

        public Task<string> GetSerial(Quarantines _quarantines)
        {
            throw new NotImplementedException();
        }

        public Task<(bool, string)> InsertGradToGradQtWeight(Quarantines _quarantines)
        {
            throw new NotImplementedException();
        }

        public Task<(bool, string)> InsertSerialQT(List<Quarantines> _quarantine, List<SAPQuarantineFromSAP> sAPQuarantinesLst)
        {
            throw new NotImplementedException();
        }

        public List<ITEMMASTER> ITEMMASTERList()
        {
            throw new NotImplementedException();
        }

        public Task<string> PrintQT(QuarantineDTO quarantineDTO)
        {
            throw new NotImplementedException();
        }

        public List<QuarantineDTO> QuarantineDTOList()
        {
            throw new NotImplementedException();
        }

        public List<SAPQuarantineFromSAP> sapQuarantinefrmSAPList()
        {
            return new List<SAPQuarantineFromSAP>();
        }

        public List<SAPQuarantine> sapQuarantineList()
        {
            throw new NotImplementedException();
        }




        public List<Quarantines> QuarantinesList()
        {
            return new List<Quarantines>();
        }


        public SAPQuarantine objsapQuarantine()
        {
            return new SAPQuarantine();
        }





    }
}
