using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Domain;

[Table("tblQuarantine")]
public class Quarantines :CommonFields
{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int? REF_No { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string Serial_No { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string Item_Code { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string Item { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string Manufacturer { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string Supplier { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string GINo { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string BTNO { get; set; }
    [Column(TypeName = "numeric(18,0)")]
    public float? QTY { get; set; }
    public int? Container { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string Recevied_Date { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string UOM { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string POSerialno { get; set; }
    public int? Status { get; set; }
    [Column(TypeName = "decimal(18,4)")]
    public float? Weight { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string MFGDATE { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string EXPDATE { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string INSPLOT { get; set; }
    // [Column(TypeName = "decimal(18,4)")]
    public float? DISPQTY { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string DISPORDER { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string DISPST { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string DISPUSER { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string LOCATION { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string PALLET { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string UserID { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string CurrDT { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string GRNNO { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string SCANDT { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string SCANUSER { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string APPNO { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string INVNO { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string INVDATE { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string RETESTDT { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string CONTNO { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string LEGACYCODE { get; set; }
    [Column(TypeName = "varchar(120)")]
    public string LEGACYDESCRIPTION { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string INSPECTIONLOTQTY { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string INSPECTIONLOTUNIT { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string NOOFPACKSFORTRF { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string ARNO { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string RETESTDATEDUEON { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string TRANSFERREQUESTFROMMATERIAL { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string MOVEMENTTYPE { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string TRASFERREQUESTFROMBATCHTOBATCH { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string TRFDATE { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string MATERIALTYPE { get; set; }
    [Column(TypeName = "varchar(100)")]
    public string Line { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime? RePrintedDate { get; set; }
    [Column(TypeName = "varchar(10)")]
    public string RePrintingSts { get; set; }
    [Column(TypeName = "varchar(10)")]
    public string RePrintedUser { get; set; }
    [Column(TypeName = "varchar(10)")]
    public string PallateStatus { get; set; }
    [Column(TypeName = "varchar(100)")]
    public string PallateRemvDate { get; set; }
    [Column(TypeName = "varchar(100)")]
    public string Cancelation { get; set; }
    // [Column(TypeName = "decimal(18,4)")]
    public float? ActualWeight { get; set; }
    public int? RejectedStatus { get; set; }
    [Column(TypeName = "varchar(10)")]
    public string MFG_CODE { get; set; }
    [Column(TypeName = "varchar(35)")]
    public string MFG_NAME { get; set; }
    [Column(TypeName = "varchar(10)")]
    public string GRADE_TO { get; set; }
    [Column(TypeName = "varchar(10)")]
    public string GRADE_FROM { get; set; }
    [Column(TypeName = "varchar(10)")]
    public string StorageLocation { get; set; }
    [Column(TypeName = "varchar(25)")]
    public string CEPNO { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string VALID_FROM { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string VALID_TO { get; set; }
    [Column(TypeName = "varchar(20)")]
    public string ORIGINAL_GI_NO { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string PARENT_ID { get; set; }
    [Column(TypeName = "varchar(10)")]
    public string BaseUOM { get; set; }
    [Column(TypeName = "varchar(10)")]
    public string MatGroup { get; set; }
    [NotMapped]
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

    [NotMapped]
    public string MatCode { get; set; }
    [NotMapped]
    public string strGRN { get; set; }
    [NotMapped]
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
    public string IssueID { get; set; }

    [NotMapped]
    public string Stage { get; set; }
    [NotMapped]
    public string PackSize { get; set; }
    [NotMapped]
    public string PackUOM { get; set; }
    [NotMapped]
    public string StatusBarcode { get; set; }
    [NotMapped]
    public string AvailableQty { get; set; }
    [NotMapped]
    public string AdjustedQty { get; set; }
    [NotMapped]
    public string AdjustedBy { get; set; }
    [NotMapped]
    public string AdjustedOn { get; set; }
    [NotMapped]
    public string ORDERNO { get; set; }
    [NotMapped]
    public string LBARCODE { get; set; }
    [NotMapped]
    public string InnerLCBarcode { get; set; }
    [NotMapped]
    public string UpdateQty { get; set; }
    [NotMapped]
    public string Tolerence { get; set; }
    [NotMapped]
    public string approvedby { get; set; }
    [NotMapped]
    public string ApprovedOn { get; set; }
    [NotMapped]
    public string DoneBy { get; set; }
    [NotMapped]
    public string PlacedOn { get; set; }
    [NotMapped]
    public string INWARD_QTY { get; set; }






}
