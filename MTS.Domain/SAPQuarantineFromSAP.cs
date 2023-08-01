using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Domain
{
    public class SAPQuarantineFromSAP
    {
        public string MBLNR { get; set; }
        public string MJAHR { get; set; }
        public string ZEILE { get; set; }
        public string MATNR { get; set; }
        public string MAKTX { get; set; }
        public string CHARG { get; set; }
        public string WERKS { get; set; }
        public string LIFNR { get; set; }
        public string SUPP_NAME1 { get; set; }
        public string MFG_NAME2 { get; set; }
        public string FRBNR { get; set; }
        public string LICHA { get; set; }
        public string ERFMG { get; set; }
        public string ERFME { get; set; }
        public string ANZGEB { get; set; }
        public DateTime? BUDAT { get; set; }
        public DateTime? HSDAT { get; set; }
        public DateTime? VFDAT { get; set; }
        public string PRUEFLOS { get; set; }
        public string XBLNR { get; set; }
        public string RTDAT { get; set; }
        public string ABLAD { get; set; }
        public DateTime? BLDAT { get; set; }
        public DateTime? QNDAT { get; set; }
        public string MATNR_PL { get; set; }
        public string MAKTX_PL { get; set; }
        public string MENGE { get; set; }
        public string MEINS { get; set; }
        public string MATKL { get; set; }
        public string SGTXT { get; set; }
        public string UMMAT { get; set; }
        public string UMWRK { get; set; }
        public string UMCHA { get; set; }
        public string XAUTO { get; set; }
        public string TRANTYP { get; set; }
        public string BWART { get; set; }
        public string MTART { get; set; }

        public string MLMFG_CODE { get; set; }
        public string MLMFG_NAME { get; set; }
        public string GRADE_TO { get; set; }
        public string GRADE_FROM { get; set; }
        public string LAGORTVORG { get; set; }
        public string CEPNO { get; set; }
        public string VALID_FROM { get; set; }
        public string VALID_TO { get; set; }
        public string ORIGINAL_GI_NO { get; set; }
        public string PARENT_ID { get; set; }
    }
}
