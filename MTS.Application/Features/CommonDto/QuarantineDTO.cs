using MTS.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Application.Features.CommonDto;


public class QuarantineDTO : CommonFields
{
    public int? REF_No { get; set; }
    public string Serial_No { get; set; }
    public string Item_Code { get; set; }
    public string Item { get; set; }
    public string Manufacturer { get; set; }
    public string Supplier { get; set; }
    public string GINo { get; set; }
    public string BTNO { get; set; }
    public float? QTY { get; set; }
    public int? Container { get; set; }
    //public DateTime? Recevied_Date { get; set; }
    public string Recevied_Date { get; set; }
    public string UOM { get; set; }
    public string POSerialno { get; set; }
    public int? Status { get; set; }

    //public decimal? Weight { get; set; }
    public float? Weight { get; set; }
    //public DateTime? MFGDATE { get; set; }
    public string MFGDATE { get; set; }
    //public DateTime? EXPDATE { get; set; }
    public string EXPDATE { get; set; }
    public string INSPLOT { get; set; }

    //public decimal? DISPQTY { get; set; }
    public float? DISPQTY { get; set; }
    public string DISPORDER { get; set; }
    public string DISPST { get; set; }
    public string DISPUSER { get; set; }
    public string LOCATION { get; set; }
    public string PALLET { get; set; }
    public string UserID { get; set; }
    //public DateTime? CurrDT { get; set; }
    public string CurrDT { get; set; }
    public string GRNNO { get; set; }
    //public DateTime? SCANDT { get; set; }
    public string SCANDT { get; set; }
    public string SCANUSER { get; set; }
    public string APPNO { get; set; }
    public string INVNO { get; set; }
    //public DateTime? INVDATE { get; set; }
    public string INVDATE { get; set; }
    public string RETESTDT { get; set; }
    public string CONTNO { get; set; }
    public string LEGACYCODE { get; set; }
    public string LEGACYDESCRIPTION { get; set; }
    public string INSPECTIONLOTQTY { get; set; }
    public string INSPECTIONLOTUNIT { get; set; }
    public string NOOFPACKSFORTRF { get; set; }
    public string ARNO { get; set; }
    //public DateTime? RETESTDATEDUEON { get; set; }
    public string RETESTDATEDUEON { get; set; }
    public string TRANSFERREQUESTFROMMATERIAL { get; set; }
    public string MOVEMENTTYPE { get; set; }
    public string TRASFERREQUESTFROMBATCHTOBATCH { get; set; }
    //public DateTime? TRFDATE { get; set; }
    public string TRFDATE { get; set; }
    public string MATERIALTYPE { get; set; }
    public string Line { get; set; }
    public DateTime? RePrintedDate { get; set; }
    public string RePrintingSts { get; set; }
    public string RePrintedUser { get; set; }
    public string PallateStatus { get; set; }
    //public DateTime? PallateRemvDate { get; set; }
    public string PallateRemvDate { get; set; }
    public string Cancelation { get; set; }
    //public decimal? ActualWeight { get; set; }
    public float? ActualWeight { get; set; }
    public int? RejectedStatus { get; set; }
    public string MFG_CODE { get; set; }
    public string MFG_NAME { get; set; }
    //public DateTime? GRADE_TO { get; set; }
    public string GRADE_TO { get; set; }
    //public DateTime? GRADE_FROM { get; set; }
    public string GRADE_FROM { get; set; }
    public string StorageLocation { get; set; }
    public string CEPNO { get; set; }
    //public DateTime? VALID_FROM { get; set; }
    public string VALID_FROM { get; set; }
    //public DateTime? VALID_TO { get; set; }
    public string VALID_TO { get; set; }
    public string ORIGINAL_GI_NO { get; set; }
    public string PARENT_ID { get; set; }
    public string BaseUOM { get; set; }
    public string MatGroup { get; set; }
    public string Plantcode { get; set; }
    [NotMapped]
    public string IPAddress { get; set; }
    [NotMapped]
    public int? WMSTATUS { get; set; }
    [NotMapped]
    public string BIN { get; set; }
    [NotMapped]
    public string DOCNO { get; set; }
    [NotMapped]
    public string ContainerUOM { get; set; }
    [NotMapped]
    public string ARN { get; set; }
    [NotMapped]
    public decimal? BaseQty { get; set; }
    [NotMapped]
    public string IteamCode { get; set; }
    [NotMapped]
    public string BalanceQty { get; set; }
    [NotMapped]
    public string DevCode { get; set; }
    [NotMapped]
    public string Type { get; set; }
    [NotMapped]
    public string REF { get; set; }
    [NotMapped]
    public string MaterialMovement { get; set; }
    [NotMapped]
    public int? Foil { get; set; }
    [NotMapped]
    public string ReceiptType { get; set; }
    [NotMapped]
    public string RecdQty { get; set; }
    [NotMapped]
    public string RecdCont { get; set; }
    [NotMapped]
    public string GrossonLabel { get; set; }

    [NotMapped]
    public string WeighingScale { get; set; }

    [NotMapped]
    public string FormName { get; set; }

    [NotMapped]
    public string EventName { get; set; }
    [NotMapped]
    public string LIFNR { get; set; }
    [NotMapped]
    public string Quarantine { get; set; }
    [NotMapped]
    public string ServerIP { get; set; }
    [NotMapped]
    public string BARCODE { get; set; }
    [NotMapped]
    public string BARCODSTATUS { get; set; }
    [NotMapped]
    public string BARCODETYPE { get; set; }
    [NotMapped]
    public string Message { get; set; }
    [NotMapped]
    public string Form { get; set; }
    [NotMapped]
    public string DRUMS { get; set; }
    [NotMapped]
    public string Room { get; set; }
    [NotMapped]
    public string TRANSACTION_TYPE { get; set; }
    [NotMapped]
    public string DestBin { get; set; }
    [NotMapped]
    public string GrossWt { get; set; }
    [NotMapped]
    public string SerialNo { get; set; }
    [NotMapped]
    public string Process { get; set; }
    [NotMapped]
    public string TOTALCOUNT { get; set; }
    [NotMapped]
    public string SampleType { get; set; }
    [NotMapped]
    public string OSign { get; set; }
    [NotMapped]
    public string DiffQty { get; set; }
    [NotMapped]
    public string iStatus { get; set; }
    [NotMapped]
    public string QuarantineBR { get; set; }
    [NotMapped]
    public int Flag { get; set; }
    [NotMapped]
    public string TotalContinar { get; set; }
    [NotMapped]
    public string MTOM { get; set; }
    [NotMapped]
    public string GTOG { get; set; }
    [NotMapped]
    public string EXP { get; set; }
    [NotMapped]
    public string PrinterID { get; set; }
    [NotMapped]
    public int Count { get; set; }
    [NotMapped]
    public bool LegacyStatus { get; set; }
    [NotMapped]
    public int SAP_POST { get; set; }
    [NotMapped]
    public string Order { get; set; }
    [NotMapped]
    public string ProcessOrder { get; set; }
    [NotMapped]
    public string BatchSize { get; set; }
    [NotMapped]
    public string MaterialDescription { get; set; }
    [NotMapped]
    public string C_STAGE { get; set; }
    [NotMapped]
    public string N_STAGE { get; set; }
    [NotMapped]
    public string LOCKQTY { get; set; }
    [NotMapped]
    public string FGIEMDESC { get; set; }
    [NotMapped]
    public string FGBATCH { get; set; }
    [NotMapped]
    public string IssueQTY { get; set; }
    [NotMapped]
    public string vIsueUOM { get; set; }
    [NotMapped]
    public string Operation { get; set; }
    [NotMapped]
    public string Remarks { get; set; }
    public string MatCode { get; set; }
    public string strGRN { get; set; }
    public string strARN { get; set; }
    [NotMapped]
    public string MaterialNumber { get; set; }
    [NotMapped]
    public string ITEMDESCRIPTION { get; set; }
    [NotMapped]
    public string RITEMDESC { get; set; }
    [NotMapped]
    public int intCurr { get; set; }
    [NotMapped]
    public string LBARCODE { get; set; }
    [NotMapped]
    public string InnerLCBarcode { get; set; }
}
