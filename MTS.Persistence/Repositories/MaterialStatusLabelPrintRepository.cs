using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MTS.Application.Contracts.Logging;
using MTS.Application.Contracts.Persistance;
using MTS.Application.Features.CommonDto;
using MTS.Application.Shared;
using MTS.Domain;
using MTS.Persistence.DatabaseContext;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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
        public async Task<Tuple<List<SAPQuarantineFromSAP>, List<Quarantines>>> CheckGRNData(Quarantines quarantine)
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

        public async Task<List<SAPQuarantineFromSAP>> GetSAPQuarantine(SAPQuarantine _sapquarantines, List<SAPQuarantineFromSAP> _sapquarantinesList)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var SAPUrl = configuration.GetValue<string>("AppIdentitySettings:SAPUrl:SAPUrl");

                    using (var response = await httpClient.GetAsync(SAPUrl + "GetSAPQuarantine/" + _sapquarantines.MBLNR))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        _sapquarantinesList = JsonConvert.DeserializeObject<List<SAPQuarantineFromSAP>>(apiResponse);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return await Task.FromResult(_sapquarantinesList);
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

        public async Task<List<ITEMMASTER>> UpdateQuarantineTable(List<SAPQuarantineFromSAP> _itemMaster, List<ITEMMASTER> ObjItemMaster)
        {
            try
            {
                // "MBLNR"      '1   GRNNO
                // "MJAHR"      '2   Material Document Year(NOT USING)
                // "ZEILE")     '3   LINE
                // "MATNR")     '4   Item_code
                // "MAKTX")     '5   Item Description
                // "CHARG")     '6   [A.R.NO.]
                // "WERKS")     '7   Plant
                // "LIFNR")      '8   Account Number of Vendor or Creditor (NOT USING)
                // "SUPP_NAME1")'9   Supplier
                // "MFG_NAME2") '10  Manufacturer
                // "FRBNR")     '11  Number of Bill of Lading at Time of Goods Receipt(NOT USING)
                // "LICHA")     '12  BTNO
                // "ERFMG")     '13  INSPECTIONLOTQTY 
                // "ERFME")     '14  INSPECTIONLOTUNIT
                // "ANZGEB")    '15  Container
                // "BUDAT")     '16  Recevied_Date
                // "HSDAT")     '17  MFGDATE
                // "VFDAT")     '18  EXPDATE
                // "PRUEFLOS")  '19  INSPLOT
                // "XBLNR")     '20  Reference Document Number(NOT USING)
                // "RTDAT")     '21  Retest Date 
                // "ABLAD")     '22  Unloading Point(NOT USING)
                // "BLDAT")     '23  INVDATE
                // "QNDAT")     '24  RETESTDATEDUEON
                // "MATNR_PL")  '25  LEGACYCODE
                // "MAKTX_PL")  '26  LEGACYDESCRIPTION
                // "MENGE")     '27  Quantity
                // "MEINS")     '28  Base Unit of Measure
                // "MATKL")     '29  Material Group(NOT USING)
                // "SGTXT")     '30  Item Text (NOT USING)
                // "UMMAT")     '31  TRANSFERREQUESTFROMMATERIAL
                // "UMWRK")     '32  Receiving PLANT (NOT USING)
                // "UMCHA")     '33  TRASFERREQUESTFROMBATCHTOBATCH
                // "XAUTO")     '34  Item automatically created(NOT USING)
                // "TRANTYP")   '35  MOVEMENTTYPE
                // "BWART")     '36  MOVEMENTTYPE(NOT USING)
                // "MTART")      '37  MATERIALTYPE
                // "MLMFG_CODE")        '38 MANUFACTOR CODE
                // "MLMFG_NAME")        '39 MANUFACTOR NAME
                // "GRADE_TO")          '40 MATERIAL TO BE ANALYZED
                // "GRADE_FROM")        '41 GRADE
                // "LAGORTVORG")        '42 Storage Location for Inspection Lot Stock
                // "CEPNO")             '43 CEP NO
                // "VALID_FROM")        '44 Date from which the X-distr.-chain material status is valid
                // "VALID_TO")          '45 Valid to
                // "ORIGINAL_GI_NO")    '46 ORIGINAL_GI_NO
                // "PARENT_ID")         '47 PARENT_ID
                for (Int16 i = 0; i <= _itemMaster.Count - 1; i++)
                {
                    if (_itemMaster[i].TRANTYP.ToString() == "R" | _itemMaster[i].TRANTYP.ToString() == "G")
                        _itemMaster[i].SUPP_NAME1 = "N.A";
                    if (_itemMaster[i].TRANTYP.ToString() == "G")
                    {
                        string DuplicateItemCode = _itemMaster[i].MATNR.ToString();  // Item code   "MATNR")     '4   Item_code
                        _itemMaster[i].MATNR = _itemMaster[i].SGTXT.ToString();   // "UMMAT")     '31  TRANSFERREQUESTFROMMATERIAL is assigned to Item code
                        _itemMaster[i].SGTXT = DuplicateItemCode;  // Item Code is assind to Material to material
                    }


                    CultureInfo ci;
                    try
                    {
                        if (_itemMaster[i].BUDAT.ToString().Contains("AM") | _itemMaster[i].BUDAT.ToString().Contains("PM"))
                            ci = new CultureInfo("en-US");
                        else
                            ci = new CultureInfo("de-DE");
                        _itemMaster[i].BUDAT = (Convert.ToDateTime(_itemMaster[i].BUDAT.ToString(), ci));  // TRF DATE

                        if (_itemMaster[i].HSDAT.ToString().Contains("AM") | _itemMaster[i].HSDAT.ToString().Contains("PM"))
                            ci = new CultureInfo("en-US");
                        else
                            ci = new CultureInfo("de-DE");
                        _itemMaster[i].HSDAT = (Convert.ToDateTime(_itemMaster[i].HSDAT.ToString(), ci)); // MFG DATE

                        if (_itemMaster[i].VFDAT.ToString().Contains("AM") | _itemMaster[i].VFDAT.ToString().Contains("PM"))
                            ci = new CultureInfo("en-US");
                        else
                            ci = new CultureInfo("de-DE");
                        _itemMaster[i].VFDAT = (Convert.ToDateTime(_itemMaster[i].VFDAT.ToString(), ci)); // EXP DATE

                        if (_itemMaster[i].QNDAT.ToString().Contains("AM") | _itemMaster[i].QNDAT.ToString().Contains("PM"))
                            ci = new CultureInfo("en-US");
                        else
                            ci = new CultureInfo("de-DE");
                        _itemMaster[i].QNDAT = (Convert.ToDateTime(_itemMaster[i].QNDAT.ToString(), ci)); // RETEST DATE DUE ON
                        if (_itemMaster[i].BLDAT.ToString().Contains("AM") | _itemMaster[i].BLDAT.ToString().Contains("PM"))
                            ci = new CultureInfo("en-US");
                        else
                            ci = new CultureInfo("de-DE");
                        _itemMaster[i].BLDAT = (Convert.ToDateTime(_itemMaster[i].BLDAT.ToString(), ci)); // INVDATE
                    }
                    catch (Exception ex)
                    {
                    }
                    DataTable dt = new DataTable();
                    var con = (SqlConnection)_context.Database.GetDbConnection();
                    List<Quarantines> quarantines = await _context.Quarantines.Where(w => w.GRNNO == _itemMaster[i].MBLNR.ToString() && w.INSPLOT == _itemMaster[i].PRUEFLOS.ToString()).ToListAsync();
                    foreach (var item in quarantines)
                    {
                        Quarantines quarantiness = new Quarantines();
                        quarantiness.IteamCode = _itemMaster[i].MATNR.ToString();
                        quarantiness.Manufacturer = _itemMaster[i].MFG_NAME2.ToString();
                        quarantiness.Supplier = _itemMaster[i].SUPP_NAME1.ToString();
                        quarantiness.BTNO = _itemMaster[i].LICHA.ToString();
                        quarantiness.Recevied_Date = _itemMaster[i].BUDAT.ToString();
                        quarantiness.BaseUOM = _itemMaster[i].MEINS.ToString();
                        quarantiness.MFGDATE = _itemMaster[i].HSDAT.ToString();
                        quarantiness.EXPDATE = _itemMaster[i].VFDAT.ToString();
                        quarantiness.INVDATE = _itemMaster[i].BLDAT.ToString();
                        quarantiness.LEGACYCODE = _itemMaster[i].MATNR_PL.ToString();
                        quarantiness.LEGACYDESCRIPTION = _itemMaster[i].MAKTX_PL.ToString();
                        quarantiness.INSPECTIONLOTQTY = _itemMaster[i].ERFMG.ToString();
                        quarantiness.INSPECTIONLOTUNIT = _itemMaster[i].ERFME.ToString();
                        quarantiness.RETESTDATEDUEON = _itemMaster[i].QNDAT.ToString();
                        quarantiness.TRANSFERREQUESTFROMMATERIAL = _itemMaster[i].UMMAT.ToString();
                        quarantiness.MOVEMENTTYPE = _itemMaster[i].TRANTYP.ToString();
                        quarantiness.TRASFERREQUESTFROMBATCHTOBATCH = _itemMaster[i].UMCHA.ToString();
                        quarantiness.TRFDATE = _itemMaster[i].BUDAT.ToString();
                        quarantiness.MATERIALTYPE = _itemMaster[i].MATNR.ToString();
                        quarantiness.Line = _itemMaster[i].ZEILE.ToString();
                        quarantiness.GRADE_TO = _itemMaster[i].GRADE_TO.ToString();
                        quarantiness.GRADE_FROM = _itemMaster[i].GRADE_FROM.ToString();
                        quarantiness.MFG_CODE = _itemMaster[i].MLMFG_CODE.ToString();
                        quarantiness.MFG_NAME = _itemMaster[i].MLMFG_NAME.ToString();
                        quarantiness.StorageLocation = _itemMaster[i].LAGORTVORG.ToString();
                        quarantiness.CEPNO = _itemMaster[i].CEPNO.ToString();
                        quarantiness.VALID_FROM = _itemMaster[i].VALID_FROM.ToString();
                        quarantiness.VALID_TO = _itemMaster[i].VALID_TO.ToString();
                        quarantiness.ORIGINAL_GI_NO = _itemMaster[i].ORIGINAL_GI_NO.ToString();
                        quarantiness.PARENT_ID = _itemMaster[i].PARENT_ID.ToString();
                        quarantiness.MatGroup = _itemMaster[i].MATKL.ToString();
                        _context.Update(quarantiness);
                        _context.SaveChanges();
                    }


                }
            }

            catch (Exception ex)
            {
                await _logsRepository.WriteErrorMsg(DateTime.Now, "MaterialStatusLabelPrintRepository", "UpdateQuarantineTable", "", ex.Message.ToString(), "",
                   "", "", "", "Server");
            }
            return ObjItemMaster;
        }





    }
}
