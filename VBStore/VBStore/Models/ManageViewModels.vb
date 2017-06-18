Imports Microsoft.AspNet.Identity
Imports Microsoft.Owin.Security
Imports System.ComponentModel.DataAnnotations

Public Class IndexViewModel
    Property HasPassword As Boolean
    Property Logins As IList(Of UserLoginInfo)
    Property PhoneNumber As String
    Property TwoFactor As Boolean
    Property BrowserRemembered As Boolean
End Class

Public Class ManageLoginsViewModel
    Property CurrentLogins As IList(Of UserLoginInfo)
    Property OtherLogins As IList(Of AuthenticationDescription)
End Class

Public Class FactorViewModel
    Property Purpose As String
End Class

Public Class SetPasswordViewModel
    <Required>
    <StringLength(100, ErrorMessage:="The {0} must be at least {2} characters long.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="New password")>
    Property NewPassword As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirm new password")>
    <Compare(NameOf(NewPassword), ErrorMessage:="The new password and confirmation password do not match.")>
    Property ConfirmPassword As String
End Class

Public Class ChangePasswordViewModel
    <Required>
    <DataType(DataType.Password)>
    <Display(Name:="Current password")>
    Property OldPassword As String

    <Required>
    <StringLength(100, ErrorMessage:="The {0} must be at least {2} characters long.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="New password")>
    Property NewPassword As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirm new password")>
    <Compare(NameOf(NewPassword), ErrorMessage:="The new password and confirmation password do not match.")>
    Property ConfirmPassword As String
End Class

Public Class AddPhoneNumberViewModel
    <Required>
    <Phone>
    <Display(Name:="Phone Number")>
    Property Number As String
End Class

Public Class VerifyPhoneNumberViewModel
    <Required>
    <Display(Name:=NameOf(Code))>
    Property Code As String

    <Required>
    <Phone>
    <Display(Name:="Phone Number")>
    Property PhoneNumber As String
End Class

Public Class ConfigureTwoFactorViewModel
    Property SelectedProvider As String
    Property Providers As ICollection(Of SelectListItem)
End Class