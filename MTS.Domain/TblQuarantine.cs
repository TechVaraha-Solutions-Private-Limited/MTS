using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Domain
{
    public class TblQuarantine
    {


        public decimal? REF_No { get; set; }
        [Key]
        public string? Serial_No { get; set; }
        public string? Item_Code { get; set; }
        public string? Item { get; set; }
        public string? manufacturer { get; set; }
        public string? supplier { get; set; }
        public string? GINo { get; set; }
        public string? BTNO { get; set; }
        public decimal? QTY { get; set; }
        public int? Container { get; set; }
        public string? Recevied_Date { get; set; }
        public string? UOM { get; set; }
        public string? POSerialno { get; set; }
        public int? Status { get; set; }
        public double? Weight { get; set; }
        public string? MFGDATE { get; set; }
        public string? EXPDATE { get; set; }
        public string? INSPLOT { get; set; }
        public double? DISPQTY { get; set; }
        public string? DISPORDER { get; set; }
        public string? DISPST { get; set; }
        public string? DISPUSER { get; set; }
        public string? LOCATION { get; set; }
        public string? PALLET { get; set; }
        public string? UserID { get; set; }
        public string? CurrDT { get; set; }
        public string? GRNNO { get; set; }
        public string? SCANDT { get; set; }
        public string? SCANUSER { get; set; }
        public string? APPNO { get; set; }
        public string? INVNO { get; set; }
        public string? INVDATE { get; set; }
        public string? RETESTDT { get; set; }
        public string? CONTNO { get; set; }
        public string? LEGACYCODE { get; set; }
        public string? LEGACYDESCRIPTION { get; set; }
        public string? INSPECTIONLOTQTY { get; set; }
        public string? INSPECTIONLOTUNIT { get; set; }
        public string? NOOFPACKSFORTRF { get; set; }
        public string? RETESTDATEDUEON { get; set; }
        public string? TRANSFERREQUESTFROMMATERIAL { get; set; }
        public string? MOVEMENTTYPE { get; set; }
        public string? TRASFERREQUESTFROMBATCHTOBATCH { get; set; }
        public string? TRFDATE { get; set; }
        public string? MATERIALTYPE { get; set; }
        public string? Line { get; set; }
        public DateTime? RePrintedDate { get; set; }
        public string? RePrintingSts { get; set; }
        public string? RePrintedUser { get; set; }
        public string? PallateStatus { get; set; }
        public string? PallateRemvDate { get; set; }
        public string? Cancelation { get; set; }
        public double? ActualWeight { get; set; }
        public int? RejectedStatus { get; set; }
        public string? MFG_CODE { get; set; }
        public string? MFG_NAME { get; set; }
        public string? GRADE_TO { get; set; }
        public string? GRADE_FROM { get; set; }
        public string? StorageLocation { get; set; }
        public string? CEPNO { get; set; }
        public string? VALID_FROM { get; set; }
        public string? VALID_TO { get; set; }
        public string? ORIGINAL_GI_NO { get; set; }
        public string? PARENT_ID { get; set; }
        public string? BaseUOM { get; set; }
        public string? MatGroup { get; set; }


    }
}
