using MTS.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MTS.Application.Shared;


public class Common
{
    #region Display Messages
    public enum Messages
    {
        [Display(Name = "Your transaction was failed.")]
        TransactionFail,
        [Display(Name = "User Locked Successfully!")]
        UserLock,

        [Display(Name = "Failed to Lock User!!! Please Enter Valid User ID")]
        FailedUserLock,

        [Display(Name = "User UnLocked Successfully!")]
        UserUnLock,

        [Display(Name = "Failed to UnLock User!!! Please Enter Valid User ID")]
        FailedUserUnLock,

        [Display(Name = "User Passsword Re-set Successfully!")]
        ResetSucessful,

        [Display(Name = "Failed to Re-set User!!! Please Enter Valid User ID")]
        FailedResetSucessful,

        [Display(Name = "Failed to Re-set User!!! Please Assign Plant in SMTP Configuration for Password Generation")]
        SMTPConfig,

        [Display(Name = "Failed to Re-set Password. Please contact administrator..!!!")]
        PasswordResetFailed,

        [Display(Name = "Failed to save User!!! Please Assign Default Password for Plant in SMTP Configuration")]
        DefaultPasswordNotConfigureToPlant,
        [Display(Name = "Failed to Re-set User Password...!!! Please assign plant to user and do password reset")]
        ResetPasswordFailed,


        [Display(Name = "Created Successfully")]
        CustomCreated,
        [Display(Name = "Already Exists")]
        AlreadyExists,
        [Display(Name = "Updated Successfully")]
        CustomUpdated,
        [Display(Name = "LotQty Updated Successfully")]
        CustomLotQtyUpdated,
        [Display(Name = "Entered LotQty less then existing Lot Qty!.")]
        CustomLotQtyError,
        [Display(Name = "LotNo Updated Successfully")]
        CustomLotNoUpdated,
        [Display(Name = "Saved Successfully.")]
        Saved,
        [Display(Name = "Deleted Successfully.")]
        Deleted,
        [Display(Name = "No changes found")]
        NochangesFound,
    }
    #endregion

    #region Enum User Actions
    public enum EnumUserActions
    {

        [Display(Name = "In Active")]
        InActive = 1,
        [Display(Name = "Active")]
        Active = 0,

        //[Display(Name = "Standard Data")]
        //Std = 0,
        //[Display(Name = "Created")]
        //Created = 1,
        //[Display(Name = "Modified")]
        //Modified = 2,
        //[Display(Name = "Enabled")]
        //Enabled = 3,
        //[Display(Name = "Disabled")]
        //Released = 4,
        //[Display(Name = "Blocked")]
        //Blocked = 5,
        //[Display(Name = "Released")]
        //Disabled = 6,
    }
    #endregion

    #region Saving Log
    public void SaveAuditLog(AuditLog objLog)
    {

    }
    #endregion

    #region Enum Plant Codes
    public enum PlantCode
    {
        [Display(Name = "1")] Plant6,
        [Display(Name = "2")] Plant11,
        [Display(Name = "3")] Plant24,
        [Display(Name = "4")] Plant3,
        [Display(Name = "5")] Plant14
    }
    #endregion

    #region Enum TBL
    /// <summary>
    /// PURPOSE     :   TBL's
    /// CREATED BY  :   
    /// CREATED ON  :   26-JAN-2020
    /// </summary>
    public enum EnumTBL
    {
        DIP,
        MIS
    }
    #endregion

}

