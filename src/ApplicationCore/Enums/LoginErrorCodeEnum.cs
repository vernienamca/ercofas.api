using System.ComponentModel;

namespace ERCOFAS.ApplicationCore.Enums
{
    public enum LoginErrorCodeEnum : uint
    {
        [Description("Invalid username or password combination. Please try again.")]
        EDS_ERR_INVALID_LOGIN_NG = 0x00007D01,

        [Description("Your account is inactive. Please contact your system administrator.")]
        EDS_ACCOUNT_INACTIVE_NG = 0x000010D04,

        [Description("Your account has been locked. Please contact your system administrator.")]
        EDS_ERR_LOCKED_OUT_NG = 0x00009D03,

        [Description("You've reached the maximum login limit. Your account has been locked.")]
        EDS_ERR_MAXLOGIN_LIMIT_NG = 0x00009D05,

        [Description("No system parameter currently set-up in the system.")]
        EDS_ERR_NO_PARAMETER_NG = 0x00006D06
    }
}
