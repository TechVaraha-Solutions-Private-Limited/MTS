using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Application.Features.CommonDto
{
    public class SAPQuarantine
    {
        [DisplayName("GRNNO")]
        public string MBLNR { get; set; }//GRNNO
        public string MJAHR { get; set; }//Material Document Year(NOT USING)
        [DisplayName("LINE")]
        public string ZEILE { get; set; }//LINE
        [DisplayName("Item_code")]
        public string MATNR { get; set; }//Item_code
        [DisplayName("ItemDescription")]
        public string MAKTX { get; set; }//Item Description
        [DisplayName("A.R.NO.")]
        public string CHARG { get; set; }//[A.R.NO.]
        [DisplayName("MaterialDocumentYear")]
        public string WERKS { get; set; }//Plant
        public string LIFNR { get; set; }// Account Number of Vendor or Creditor (NOT USING)
        [DisplayName("Supplier")]
        public string SUPP_NAME1 { get; set; }//Supplier
        [DisplayName("Manufacturer")]
        public string MFG_NAME2 { get; set; }//Manufacturer
        public string FRBNR { get; set; }//Number of Bill of Lading at Time of Goods Receipt(NOT USING)
        [DisplayName("BTNO")]
        public string LICHA { get; set; }//BTNO
        [DisplayName("INSPECTIONLOTQTY")]
        public string ERFMG { get; set; }//INSPECTIONLOTQTY 
        [DisplayName("INSPECTIONLOTUNIT")]
        public string ERFME { get; set; }//INSPECTIONLOTUNIT
        [DisplayName("Container")]
        public string ANZGEB { get; set; }//Container
        [DisplayName("Recevied_Date")]
        public DateTime? BUDAT { get; set; }//Recevied_Date
        [DisplayName("MFGDATE")]
        public DateTime? HSDAT { get; set; }//MFGDATE
        [DisplayName("EXPDATE")]
        public DateTime? VFDAT { get; set; }//EXPDATE
        [DisplayName("INSPLOT")]
        public string PRUEFLOS { get; set; }//INSPLOT
        public string XBLNR { get; set; }//Reference Document Number(NOT USING)
        [DisplayName("RetestDate ")]
        public DateTime? RTDAT { get; set; }//Retest Date 
        public string ABLAD { get; set; }//Unloading Point(NOT USING)
        [DisplayName("INVDATE")]
        public DateTime? BLDAT { get; set; }//INVDATE
        [DisplayName("RETESTDATEDUEON")]
        public DateTime? QNDAT { get; set; }//RETESTDATEDUEON
        [DisplayName("LEGACYCODE")]
        public string MATNR_PL { get; set; }//LEGACYCODE
        [DisplayName("LEGACYDESCRIPTION")]
        public string MAKTX_PL { get; set; }//LEGACYDESCRIPTION
        [DisplayName("Quantity")]
        public string MENGE { get; set; }//Quantity
        [DisplayName("BaseUnitofMeasure")]
        public string MEINS { get; set; }//Base Unit of Measure
        public string MATKL { get; set; }//Material Group(NOT USING)
        public string SGTXT { get; set; }//Item Text (NOT USING)
        [DisplayName("TRANSFERREQUESTFROMMATERIAL")]
        public string UMMAT { get; set; }//TRANSFERREQUESTFROMMATERIAL
        [DisplayName("ReceivingPLANT")]
        public string UMWRK { get; set; }// Receiving PLANT (NOT USING)
        [DisplayName("TRASFERREQUESTFROMBATCHTOBATCH")]
        public string UMCHA { get; set; }//TRASFERREQUESTFROMBATCHTOBATCH
        [DisplayName("Item")]
        public string XAUTO { get; set; }//Item automatically created(NOT USING)
        [DisplayName("MOVEMENTTYPE")]
        public string TRANTYP { get; set; }//MOVEMENTTYPE
        public string BWART { get; set; }//MOVEMENTTYPE(NOT USING)
        [DisplayName("MATERIALTYPE")]
        public string MTART { get; set; }//MATERIALTYPE
        [DisplayName("MANUFACTORCODE")]
        public string MLMFG_CODE { get; set; }//MANUFACTOR CODE
        [DisplayName("MANUFACTORNAME")]
        public string MLMFG_NAME { get; set; }//MANUFACTOR NAME
        [DisplayName("MATERIALTOBEANALYZED")]
        public string GRADE_TO { get; set; }//MATERIAL TO BE ANALYZED
        [DisplayName("GRADE")]
        public string GRADE_FROM { get; set; }//GRADE
        [DisplayName("StorageLocation")]
        public string LAGORTVORG { get; set; }//Storage Location for Inspection Lot Stock
        [DisplayName("CEPNO")]
        public string CEPNO { get; set; }//CEP NO
        [DisplayName("X-distr")]
        public DateTime? VALID_FROM { get; set; }//Date from which the X-distr.-chain material status is valid
        [DisplayName("ValidTo")]
        public DateTime? VALID_TO { get; set; }//Valid to
        [DisplayName("ORIGINAL_GI_NO")]
        public string ORIGINAL_GI_NO { get; set; }//ORIGINAL_GI_NO
        [DisplayName("PARENT_ID")]
        public string PARENT_ID { get; set; }//PARENT_ID
    }
}
