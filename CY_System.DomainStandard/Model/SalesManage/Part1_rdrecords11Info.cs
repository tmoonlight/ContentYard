using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.DomainStandard
{
    /// <summary>
	/// Part1_rdrecords11实体类
    /// 作者: C
    /// 时间: 2018-01-25 11:02:52
    /// </summary>
    [POCO(DbConnName = CY_SystemConsts.ConnectionString_conn, TableName = "rdrecords11")]
    public class Part1_rdrecords11Info
    {
        /// <summary>
        /// AutoID属性
        /// <summary>
        public long? AutoID { get; set; }

        /// <summary>
        /// ID属性
        /// <summary>
        public long? ID { get; set; }

        /// <summary>
        /// cInvCode属性
        /// <summary>
        public string cInvCode { get; set; }

        /// <summary>
        /// iNum属性
        /// <summary>
        public decimal? iNum { get; set; }

        /// <summary>
        /// iQuantity属性
        /// <summary>
        public decimal? iQuantity { get; set; }

        /// <summary>
        /// iUnitCost属性
        /// <summary>
        public decimal? iUnitCost { get; set; }

        /// <summary>
        /// iPrice属性
        /// <summary>
        public double? iPrice { get; set; }

        /// <summary>
        /// iAPrice属性
        /// <summary>
        public double? iAPrice { get; set; }

        /// <summary>
        /// iPUnitCost属性
        /// <summary>
        public decimal? iPUnitCost { get; set; }

        /// <summary>
        /// iPPrice属性
        /// <summary>
        public double? iPPrice { get; set; }

        /// <summary>
        /// cBatch属性
        /// <summary>
        public string cBatch { get; set; }

        /// <summary>
        /// cObjCode属性
        /// <summary>
        public string cObjCode { get; set; }

        /// <summary>
        /// cVouchCode属性
        /// <summary>
        public long? cVouchCode { get; set; }

        /// <summary>
        /// cInVouchCode属性
        /// <summary>
        public string cInVouchCode { get; set; }

        /// <summary>
        /// cinvouchtype属性
        /// <summary>
        public string cinvouchtype { get; set; }

        /// <summary>
        /// iSOutQuantity属性
        /// <summary>
        public decimal? iSOutQuantity { get; set; }

        /// <summary>
        /// iSOutNum属性
        /// <summary>
        public decimal? iSOutNum { get; set; }

        /// <summary>
        /// coutvouchid属性
        /// <summary>
        public long? coutvouchid { get; set; }

        /// <summary>
        /// coutvouchtype属性
        /// <summary>
        public string coutvouchtype { get; set; }

        /// <summary>
        /// iSRedOutQuantity属性
        /// <summary>
        public decimal? iSRedOutQuantity { get; set; }

        /// <summary>
        /// iSRedOutNum属性
        /// <summary>
        public decimal? iSRedOutNum { get; set; }

        /// <summary>
        /// cFree1属性
        /// <summary>
        public string cFree1 { get; set; }

        /// <summary>
        /// cFree2属性
        /// <summary>
        public string cFree2 { get; set; }

        /// <summary>
        /// iFlag属性
        /// <summary>
        public byte? iFlag { get; set; }

        /// <summary>
        /// iSQuantity属性
        /// <summary>
        public decimal? iSQuantity { get; set; }

        /// <summary>
        /// iSNum属性
        /// <summary>
        public decimal? iSNum { get; set; }

        /// <summary>
        /// iFNum属性
        /// <summary>
        public decimal? iFNum { get; set; }

        /// <summary>
        /// iFQuantity属性
        /// <summary>
        public decimal? iFQuantity { get; set; }

        /// <summary>
        /// dVDate属性
        /// <summary>
        public DateTime? dVDate { get; set; }

        /// <summary>
        /// iTrIds属性
        /// <summary>
        public long? iTrIds { get; set; }

        /// <summary>
        /// cPosition属性
        /// <summary>
        public string cPosition { get; set; }

        /// <summary>
        /// cDefine22属性
        /// <summary>
        public string cDefine22 { get; set; }

        /// <summary>
        /// cDefine23属性
        /// <summary>
        public string cDefine23 { get; set; }

        /// <summary>
        /// cDefine24属性
        /// <summary>
        public string cDefine24 { get; set; }

        /// <summary>
        /// cDefine25属性
        /// <summary>
        public string cDefine25 { get; set; }

        /// <summary>
        /// cDefine26属性
        /// <summary>
        public double? cDefine26 { get; set; }

        /// <summary>
        /// cDefine27属性
        /// <summary>
        public double? cDefine27 { get; set; }

        /// <summary>
        /// cItem_class属性
        /// <summary>
        public string cItem_class { get; set; }

        /// <summary>
        /// cItemCode属性
        /// <summary>
        public string cItemCode { get; set; }

        /// <summary>
        /// cName属性
        /// <summary>
        public string cName { get; set; }

        /// <summary>
        /// cItemCName属性
        /// <summary>
        public string cItemCName { get; set; }

        /// <summary>
        /// cFree3属性
        /// <summary>
        public string cFree3 { get; set; }

        /// <summary>
        /// cFree4属性
        /// <summary>
        public string cFree4 { get; set; }

        /// <summary>
        /// cFree5属性
        /// <summary>
        public string cFree5 { get; set; }

        /// <summary>
        /// cFree6属性
        /// <summary>
        public string cFree6 { get; set; }

        /// <summary>
        /// cFree7属性
        /// <summary>
        public string cFree7 { get; set; }

        /// <summary>
        /// cFree8属性
        /// <summary>
        public string cFree8 { get; set; }

        /// <summary>
        /// cFree9属性
        /// <summary>
        public string cFree9 { get; set; }

        /// <summary>
        /// cFree10属性
        /// <summary>
        public string cFree10 { get; set; }

        /// <summary>
        /// cBarCode属性
        /// <summary>
        public string cBarCode { get; set; }

        /// <summary>
        /// iNQuantity属性
        /// <summary>
        public decimal? iNQuantity { get; set; }

        /// <summary>
        /// iNNum属性
        /// <summary>
        public decimal? iNNum { get; set; }

        /// <summary>
        /// cAssUnit属性
        /// <summary>
        public string cAssUnit { get; set; }

        /// <summary>
        /// dMadeDate属性
        /// <summary>
        public DateTime? dMadeDate { get; set; }

        /// <summary>
        /// iMassDate属性
        /// <summary>
        public int? iMassDate { get; set; }

        /// <summary>
        /// cDefine28属性
        /// <summary>
        public string cDefine28 { get; set; }

        /// <summary>
        /// cDefine29属性
        /// <summary>
        public string cDefine29 { get; set; }

        /// <summary>
        /// cDefine30属性
        /// <summary>
        public string cDefine30 { get; set; }

        /// <summary>
        /// cDefine31属性
        /// <summary>
        public string cDefine31 { get; set; }

        /// <summary>
        /// cDefine32属性
        /// <summary>
        public string cDefine32 { get; set; }

        /// <summary>
        /// cDefine33属性
        /// <summary>
        public string cDefine33 { get; set; }

        /// <summary>
        /// cDefine34属性
        /// <summary>
        public int? cDefine34 { get; set; }

        /// <summary>
        /// cDefine35属性
        /// <summary>
        public int? cDefine35 { get; set; }

        /// <summary>
        /// cDefine36属性
        /// <summary>
        public DateTime? cDefine36 { get; set; }

        /// <summary>
        /// cDefine37属性
        /// <summary>
        public DateTime? cDefine37 { get; set; }

        /// <summary>
        /// iMPoIds属性
        /// <summary>
        public long? iMPoIds { get; set; }

        /// <summary>
        /// iCheckIds属性
        /// <summary>
        public long? iCheckIds { get; set; }

        /// <summary>
        /// cBVencode属性
        /// <summary>
        public string cBVencode { get; set; }

        /// <summary>
        /// bGsp属性
        /// <summary>
        public bool? bGsp { get; set; }

        /// <summary>
        /// cGspState属性
        /// <summary>
        public string cGspState { get; set; }

        /// <summary>
        /// cCheckCode属性
        /// <summary>
        public string cCheckCode { get; set; }

        /// <summary>
        /// iCheckIdBaks属性
        /// <summary>
        public long? iCheckIdBaks { get; set; }

        /// <summary>
        /// cRejectCode属性
        /// <summary>
        public string cRejectCode { get; set; }

        /// <summary>
        /// iRejectIds属性
        /// <summary>
        public long? iRejectIds { get; set; }

        /// <summary>
        /// cCheckPersonCode属性
        /// <summary>
        public string cCheckPersonCode { get; set; }

        /// <summary>
        /// dCheckDate属性
        /// <summary>
        public DateTime? dCheckDate { get; set; }

        /// <summary>
        /// cMassUnit属性
        /// <summary>
        public int? cMassUnit { get; set; }

        /// <summary>
        /// cMoLotCode属性
        /// <summary>
        public string cMoLotCode { get; set; }

        /// <summary>
        /// iMaterialFee属性
        /// <summary>
        public double? iMaterialFee { get; set; }

        /// <summary>
        /// iProcessCost属性
        /// <summary>
        public decimal? iProcessCost { get; set; }

        /// <summary>
        /// iProcessFee属性
        /// <summary>
        public double? iProcessFee { get; set; }

        /// <summary>
        /// dMSDate属性
        /// <summary>
        public DateTime? dMSDate { get; set; }

        /// <summary>
        /// iSMaterialFee属性
        /// <summary>
        public double? iSMaterialFee { get; set; }

        /// <summary>
        /// iSProcessFee属性
        /// <summary>
        public double? iSProcessFee { get; set; }

        /// <summary>
        /// iOMoDID属性
        /// <summary>
        public int? iOMoDID { get; set; }

        /// <summary>
        /// bFilled属性
        /// <summary>
        public long? bFilled { get; set; }

        /// <summary>
        /// bChecked属性
        /// <summary>
        public bool? bChecked { get; set; }

        /// <summary>
        /// iOMoMID属性
        /// <summary>
        public long? iOMoMID { get; set; }

        /// <summary>
        /// cmworkcentercode属性
        /// <summary>
        public string cmworkcentercode { get; set; }

        /// <summary>
        /// bLPUseFree属性
        /// <summary>
        public bool? bLPUseFree { get; set; }

        /// <summary>
        /// iRSRowNO属性
        /// <summary>
        public int? iRSRowNO { get; set; }

        /// <summary>
        /// iOriTrackID属性
        /// <summary>
        public long? iOriTrackID { get; set; }

        /// <summary>
        /// coritracktype属性
        /// <summary>
        public string coritracktype { get; set; }

        /// <summary>
        /// cbaccounter属性
        /// <summary>
        public string cbaccounter { get; set; }

        /// <summary>
        /// dbKeepDate属性
        /// <summary>
        public DateTime? dbKeepDate { get; set; }

        /// <summary>
        /// bCosting属性
        /// <summary>
        public bool? bCosting { get; set; }

        /// <summary>
        /// bVMIUsed属性
        /// <summary>
        public bool? bVMIUsed { get; set; }

        /// <summary>
        /// iVMISettleQuantity属性
        /// <summary>
        public decimal? iVMISettleQuantity { get; set; }

        /// <summary>
        /// iVMISettleNum属性
        /// <summary>
        public decimal? iVMISettleNum { get; set; }

        /// <summary>
        /// cvmivencode属性
        /// <summary>
        public string cvmivencode { get; set; }

        /// <summary>
        /// iInvSNCount属性
        /// <summary>
        public int? iInvSNCount { get; set; }

        /// <summary>
        /// cwhpersoncode属性
        /// <summary>
        public string cwhpersoncode { get; set; }

        /// <summary>
        /// cwhpersonname属性
        /// <summary>
        public string cwhpersonname { get; set; }

        /// <summary>
        /// iMaIDs属性
        /// <summary>
        public long? iMaIDs { get; set; }

        /// <summary>
        /// cserviceoid属性
        /// <summary>
        public string cserviceoid { get; set; }

        /// <summary>
        /// cbserviceoid属性
        /// <summary>
        public string cbserviceoid { get; set; }

        /// <summary>
        /// iinvexchrate属性
        /// <summary>
        public decimal? iinvexchrate { get; set; }

        /// <summary>
        /// corufts属性
        /// <summary>
        public string corufts { get; set; }

        /// <summary>
        /// comcode属性
        /// <summary>
        public string comcode { get; set; }

        /// <summary>
        /// cmocode属性
        /// <summary>
        public string cmocode { get; set; }

        /// <summary>
        /// invcode属性
        /// <summary>
        public string invcode { get; set; }

        /// <summary>
        /// imoseq属性
        /// <summary>
        public int? imoseq { get; set; }

        /// <summary>
        /// iopseq属性
        /// <summary>
        public string iopseq { get; set; }

        /// <summary>
        /// copdesc属性
        /// <summary>
        public string copdesc { get; set; }

        /// <summary>
        /// strContractGUID属性
        /// <summary>
        public Guid? strContractGUID { get; set; }

        /// <summary>
        /// iExpiratDateCalcu属性
        /// <summary>
        public int? iExpiratDateCalcu { get; set; }

        /// <summary>
        /// cExpirationdate属性
        /// <summary>
        public string cExpirationdate { get; set; }

        /// <summary>
        /// dExpirationdate属性
        /// <summary>
        public DateTime? dExpirationdate { get; set; }

        /// <summary>
        /// cciqbookcode属性
        /// <summary>
        public string cciqbookcode { get; set; }

        /// <summary>
        /// iBondedSumQty属性
        /// <summary>
        public decimal? iBondedSumQty { get; set; }

        /// <summary>
        /// productinids属性
        /// <summary>
        public int? productinids { get; set; }

        /// <summary>
        /// iorderdid属性
        /// <summary>
        public int? iorderdid { get; set; }

        /// <summary>
        /// iordertype属性
        /// <summary>
        public byte? iordertype { get; set; }

        /// <summary>
        /// iordercode属性
        /// <summary>
        public string iordercode { get; set; }

        /// <summary>
        /// iorderseq属性
        /// <summary>
        public int? iorderseq { get; set; }

        /// <summary>
        /// isodid属性
        /// <summary>
        public string isodid { get; set; }

        /// <summary>
        /// isotype属性
        /// <summary>
        public byte? isotype { get; set; }

        /// <summary>
        /// csocode属性
        /// <summary>
        public string csocode { get; set; }

        /// <summary>
        /// isoseq属性
        /// <summary>
        public int? isoseq { get; set; }

        /// <summary>
        /// ipesodid属性
        /// <summary>
        public string ipesodid { get; set; }

        /// <summary>
        /// ipesotype属性
        /// <summary>
        public byte? ipesotype { get; set; }

        /// <summary>
        /// cpesocode属性
        /// <summary>
        public string cpesocode { get; set; }

        /// <summary>
        /// ipesoseq属性
        /// <summary>
        public int? ipesoseq { get; set; }

        /// <summary>
        /// cBatchProperty1属性
        /// <summary>
        public decimal? cBatchProperty1 { get; set; }

        /// <summary>
        /// cBatchProperty2属性
        /// <summary>
        public decimal? cBatchProperty2 { get; set; }

        /// <summary>
        /// cBatchProperty3属性
        /// <summary>
        public decimal? cBatchProperty3 { get; set; }

        /// <summary>
        /// cBatchProperty4属性
        /// <summary>
        public decimal? cBatchProperty4 { get; set; }

        /// <summary>
        /// cBatchProperty5属性
        /// <summary>
        public decimal? cBatchProperty5 { get; set; }

        /// <summary>
        /// cBatchProperty6属性
        /// <summary>
        public string cBatchProperty6 { get; set; }

        /// <summary>
        /// cBatchProperty7属性
        /// <summary>
        public string cBatchProperty7 { get; set; }

        /// <summary>
        /// cBatchProperty8属性
        /// <summary>
        public string cBatchProperty8 { get; set; }

        /// <summary>
        /// cBatchProperty9属性
        /// <summary>
        public string cBatchProperty9 { get; set; }

        /// <summary>
        /// cBatchProperty10属性
        /// <summary>
        public DateTime? cBatchProperty10 { get; set; }

        /// <summary>
        /// cbMemo属性
        /// <summary>
        public string cbMemo { get; set; }

        /// <summary>
        /// applydid属性
        /// <summary>
        public int? applydid { get; set; }

        /// <summary>
        /// applycode属性
        /// <summary>
        public string applycode { get; set; }

        /// <summary>
        /// irowno属性
        /// <summary>
        public int? irowno { get; set; }

        /// <summary>
        /// strowguid属性
        /// <summary>
        public Guid? strowguid { get; set; }

        /// <summary>
        /// cservicecode属性
        /// <summary>
        public string cservicecode { get; set; }

        /// <summary>
        /// rowufts属性
        /// <summary>
        public string rowufts { get; set; }

        /// <summary>
        /// ipreuseqty属性
        /// <summary>
        public decimal? ipreuseqty { get; set; }

        /// <summary>
        /// ipreuseinum属性
        /// <summary>
        public decimal? ipreuseinum { get; set; }

        /// <summary>
        /// bsupersede属性
        /// <summary>
        public int? bsupersede { get; set; }

        /// <summary>
        /// isupersedeqty属性
        /// <summary>
        public decimal? isupersedeqty { get; set; }

        /// <summary>
        /// isupersedempoids属性
        /// <summary>
        public int? isupersedempoids { get; set; }

        /// <summary>
        /// imoallocatesubid属性
        /// <summary>
        public Guid? imoallocatesubid { get; set; }

        /// <summary>
        /// cInVoucherLineID属性
        /// <summary>
        public int? cInVoucherLineID { get; set; }

        /// <summary>
        /// cInVoucherCode属性
        /// <summary>
        public string cInVoucherCode { get; set; }

        /// <summary>
        /// cInVoucherType属性
        /// <summary>
        public string cInVoucherType { get; set; }

        /// <summary>
        /// cbsysbarcode属性
        /// <summary>
        public string cbsysbarcode { get; set; }

        /// <summary>
        /// cSourceMOCode属性
        /// <summary>
        public string cSourceMOCode { get; set; }

        /// <summary>
        /// iSourceMODetailsid属性
        /// <summary>
        public int? iSourceMODetailsid { get; set; }

        /// <summary>
        /// cplanlotcode属性
        /// <summary>
        public string cplanlotcode { get; set; }

        /// <summary>
        /// bcanreplace属性
        /// <summary>
        public int? bcanreplace { get; set; }

        /// <summary>
        /// iposflag属性
        /// <summary>
        public int? iposflag { get; set; }


    }
}

